using System.IO;

namespace VampireSwansong.Editor.Exceptions;

public class InvalidStreamException : FileNotFoundException
{
    public InvalidStreamException() : base("The stream is either not usable or cannot be seeked.")
    {
    }
}
