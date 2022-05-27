using System.IO;

namespace VampireSwansong.Editor.Exceptions;

public class SaveGameDirectoryNotFoundException : DirectoryNotFoundException
{
    public SaveGameDirectoryNotFoundException(string directory) : base($"The SaveGame directory was not found. {directory}")
    {
    }
}
