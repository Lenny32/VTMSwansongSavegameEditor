using System;

namespace VampireSwansong.Editor.Types;

public class SkillValue
{
    public virtual byte MaxValue => 5;
    public virtual byte MinValue => 0;
    public SkillValue(byte value, int offset)
    {
        IsValid(value);
        _value = OriginalValue = value;
        Offset = offset;
    }

    public bool IsDirty { get; private set; }

    internal byte OriginalValue { get; init; }
    private byte _value;
    public byte Value
    {
        get
        {
            return _value;
        }
        set
        {
            IsValid(value);
            if (value != _value)
                IsDirty = true;
            _value = value;
        }
    }

    internal int Offset { get; init; }

    private bool IsValid(byte value)
    {
        if (value < MinValue || value > MaxValue)
            throw new ArgumentOutOfRangeException(nameof(value));
        return true;
    }


    public static implicit operator byte(SkillValue d) => d.Value;
    public static bool operator ==(SkillValue skill, int value) => skill.Value == value;
    public static bool operator !=(SkillValue skill, int value) => skill.Value != value;

    public override string ToString() => $"{Value}";

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        else if (ReferenceEquals(this, obj))
            return true;
        return false;
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}
