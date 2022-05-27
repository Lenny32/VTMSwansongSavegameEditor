namespace VampireSwansong.Editor.Exceptions;

public class SaveGameNullException : VampireSwansongException
{
    public SaveGameNullException() : base("The SaveGame is null.")
    {
    }
}
