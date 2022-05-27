namespace VampireSwansong.Editor.Exceptions;

public class MissingSaveGameException : VampireSwansongException
{
    public MissingSaveGameException() : base("The SaveGame is missing")
    {
    }
    public MissingSaveGameException(int slot) : base($"The SaveGame is missing, with slot : {slot}")
    {
    }
}