using VampireSwansong.Editor.Exceptions;
using VampireSwansong.Editor.Internal;
using System.IO.Abstractions;
using System.Collections.Generic;
using System;
using System.Linq;

namespace VampireSwansong.Editor;

public class SaveGame
{
    public SaveGame(IFileSystem fileSystem)
    {
        _fileSystem = fileSystem;
    }

    public const string DefaultLocation = "C:\\Users\\{0}\\AppData\\Local\\Vampire\\Saved\\SaveGames";
    public static readonly string DefaultSaveGamesPath = string.Format(DefaultLocation, Environment.UserName);
    public const string GameSettings = "GameSettings.sav";
    public const string PlayerStatsEOS = "PlayerStatsEOS.sav";
    
    public bool GameSettingsFound { get; private set; }
    public bool PlayerStatsEOSFound { get; private set; }
    
    public Dictionary<int, List<string>> Slots { get; internal set; } = new();
    
    private readonly IFileSystem _fileSystem;

    public const string ValidFileNameRegex = "(Slot.*?)(_([\\w]*).([\\w]*).([\\w]*))?.sav";

     
    public void Load()
    {
        
        if (!_fileSystem.Directory.Exists(DefaultSaveGamesPath))
        {
            throw new SaveGameDirectoryNotFoundException(DefaultSaveGamesPath);
        }
        var files = _fileSystem.Directory.GetFiles(DefaultSaveGamesPath);
        foreach (string file in files)
        {
            var fileInfo = _fileSystem.FileInfo.FromFileName(file);
            string fileName = fileInfo.Name;
            if (fileName.Equals(GameSettings, StringComparison.InvariantCultureIgnoreCase))
                GameSettingsFound = true;
            else if (fileName.Equals(GameSettings, StringComparison.InvariantCultureIgnoreCase))
                PlayerStatsEOSFound = true;
            else if(fileName.IsMatch(ValidFileNameRegex))
            {
                if(int.TryParse(fileName[4].ToString(), out int slotNumber)) 
                {
                    if (Slots.ContainsKey(slotNumber))
                        Slots[slotNumber].Add(fileName);
                    else
                        Slots.Add(slotNumber, new List<string>() { fileName });
                }
            }
        }
    }

    public int ReadSlotNumber(string fileName)
    {
        const int position = 12;
        
        if(!_fileSystem.File.Exists(fileName))
            throw new SaveGameFileNotFoundException(fileName);

        if (!fileName.IsMatch(ValidFileNameRegex))
            throw new SaveGameFileNameNotValidException();

        using var sr = _fileSystem.File.OpenRead(fileName);

        if (sr.Length < position)
            throw new InvalidSaveGameException();

        sr.Position = position;
        var c = (char)sr.ReadByte();

        return int.TryParse(c.ToString(), out int slotNumber) ? slotNumber : throw new SaveGameFileNameNotValidException();
    }

    public void ChangeSlotNumber(string fileName, int slotNumber)
    {
        const int position = 12;

        if(slotNumber < byte.MinValue || slotNumber > byte.MaxValue)
            throw new VampireSwansongException("Slot number must be between 0 and 255");

        if (!_fileSystem.File.Exists(fileName))
            throw new SaveGameFileNotFoundException(fileName);

        if (!fileName.IsMatch(ValidFileNameRegex))
            throw new SaveGameFileNameNotValidException();
        

        using var sr = _fileSystem.File.OpenWrite(fileName);

        if (sr.Length < position)
            throw new InvalidSaveGameException();

        sr.Position = position;

        var zeroC = (byte)'0';
        zeroC += (byte)slotNumber;

        sr.WriteByte(zeroC);
    }

    public void DuplicateSlot(int slotIn, int slotOut, bool backup = true)
    {
        if (!Slots.ContainsKey(slotIn))
            throw new MissingSaveGameException(slotIn);

        var filesToBeReplaced = _fileSystem.Directory.EnumerateFiles(DefaultSaveGamesPath, $"Slot{slotOut}").ToList();

        if (backup && filesToBeReplaced.Any())
        {
            foreach (string file in filesToBeReplaced)
            {
                var fileInfo = _fileSystem.FileInfo.FromFileName(file);
                string fileName = fileInfo.Name;

                var backupDirectory = _fileSystem.Directory.GetParent(DefaultSaveGamesPath).CreateSubdirectory("Backup").CreateSubdirectory(DateTime.Now.ToString("yyyyMMddHHmmss"));
                _fileSystem.File.Copy(file, System.IO.Path.Combine(backupDirectory.FullName, fileName));
            }
        }
        filesToBeReplaced.ForEach(file => _fileSystem.File.Delete(file));

        var toDuplicateFile = _fileSystem.Directory.EnumerateFiles(DefaultSaveGamesPath, $"Slot{slotIn}*").ToList();

        foreach (string file in toDuplicateFile)
        {
            string newFileName = file.Replace($"Slot{slotIn}", $"Slot{slotOut}");
            _fileSystem.File.Copy(file, newFileName);
            ChangeSlotNumber(newFileName, slotOut);
        }
    }
}
