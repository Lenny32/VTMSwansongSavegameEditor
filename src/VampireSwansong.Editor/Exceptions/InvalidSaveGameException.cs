namespace VampireSwansong.Editor.Exceptions;

public class InvalidSaveGameException : VampireSwansongException
{
    public InvalidSaveGameException() : base("The SaveGame file is not valid")
    {
    }
}
