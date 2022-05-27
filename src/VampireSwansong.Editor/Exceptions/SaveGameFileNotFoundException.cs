using System.IO;

namespace VampireSwansong.Editor.Exceptions;

public class SaveGameFileNotFoundException : FileNotFoundException
{
    public SaveGameFileNotFoundException(string fileName) : base("The SaveGame file was not found", fileName)
    {
    }
}
