namespace VampireSwansong.Editor.Exceptions;

public class SaveGameFileNameNotValidException : VampireSwansongException
{
    public SaveGameFileNameNotValidException() : base("The SaveGame file name is not valid")
    {
    }
}
