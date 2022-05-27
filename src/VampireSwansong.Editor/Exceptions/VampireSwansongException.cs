using System;

namespace VampireSwansong.Editor.Exceptions;

public class VampireSwansongException : Exception
{
    public VampireSwansongException(string message) : base(message)
    {
    }
}
