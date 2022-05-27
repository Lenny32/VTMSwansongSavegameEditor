using System;
using System.Diagnostics;
using VampireSwansong.Editor.Constants;

namespace VampireSwansong.Editor;

[DebuggerDisplay("IsPlayer:{IsPlayer}, Title:{Title}")]
public class Character
{
    public string Title { get; set; } = string.Empty;

    public byte[] Data { get; set; } = Array.Empty<byte>();
    public int StartIndex { get; set; }
    public int Length { get; set; }
    public CharacterSkills Skills { get; set; } = new CharacterSkills();

    public bool IsPlayer => Title == ConstantsPlayer.Emem ||
                            Title == ConstantsPlayer.Leysha ||
                            Title == ConstantsPlayer.Galeb;

    public override string ToString() => Title;
}
