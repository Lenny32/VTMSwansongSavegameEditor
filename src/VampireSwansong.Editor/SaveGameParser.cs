using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VampireSwansong.Editor.Constants;
using VampireSwansong.Editor.Internal;
using VampireSwansong.Editor.Types;

namespace VampireSwansong.Editor;

public class SaveGameParser
{
    public byte[] Save { get; set; }

    public SaveGameParser(byte[] save)
    {
        if (save == null || save.Length == 0)
            throw new InvalidSaveGameException();
        Save = save;
    }
    public SaveGameParser(Stream stream) : this(ReadAll(stream))
    {
    }
    public SaveGameParser(string fileName) : this(ReadAll(fileName))
    {
    }
    private string GetTitleFromByteArray(byte[] data)
    {
        var buffer = new StringBuilder();
        foreach (char c in data)
        {
            if (c == '\0')
                break;
            buffer.Append(c);
        }

        return buffer.ToString();
    }
    public BasicSaveGame? Parse()
    {
        List<Character> Positions = new();
        var positions = Save.Locate(ConstantsPlayer.Characters_AsByteArray);

        if (positions.Length == 0)
            return null;

        byte[]? header = Save[..positions[0]];

        for (int i = 0; i < positions.Length; i++)
        {
            var current = positions[i];
            var next = positions.Length > i+1 ? positions[i+1] : Save.Length;

            var data = Save[current..next];
            var title = GetTitleFromByteArray(data);

            var character = new Character()
            {
                Data = data,
                Title = title,
                StartIndex = current,
                Length = next - current
            };

            if(character.IsPlayer)
                character.Skills = CharacterAttributesParser(data);

            Positions.Add(character);
        }
        return new BasicSaveGame() { Header = header, Characters = Positions };
    }

    private (byte? Value, int? Offset) GetValue(byte[] data, byte[] type)
    {
        const int skipNoneWordLength = 5;
        var span = data.AsSpan();

        //Gameplay.Attributes.XYZ
        var offsets = span.ToArray().Locate(type);
        foreach (var offset in offsets)
        {
            if (offset == -1)
                return (null, null);

            var dd2 = span.Slice(offset).ToArray();

            var dd2Span = dd2.AsSpan();
            var indexOfNone = dd2Span.IndexOf(ConstantsGameplaySkills.None_AsByteArray);
            var dd3 = dd2Span.Slice(indexOfNone).ToArray();
            var value = dd3[skipNoneWordLength];
            if (value <= 5)
                return (value, offset + indexOfNone + skipNoneWordLength);
            else
                continue;
        }
        return (null, null);
    }

    public CharacterSkills CharacterAttributesParser(byte[] data)
    {
        CharacterSkills characterSkills = new CharacterSkills();

        (byte? Value, int? Offset) value;

        value = GetValue(data, ConstantsGameplaySkills.Physical_AsByteArray);
        if(value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Physical = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Social_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Social = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Mental_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Mental = new SkillValue(value.Value.Value, value.Offset.Value);


        value = GetValue(data, ConstantsGameplaySkills.Rhetoric_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Rhetoric = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Intimidation_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Intimidation = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Persuasion_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Persuasion = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Psychology_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Psychology = new SkillValue(value.Value.Value, value.Offset.Value);


        value = GetValue(data, ConstantsGameplaySkills.Security_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Security = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Technology_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Technology = new SkillValue(value.Value.Value, value.Offset.Value);


        value = GetValue(data, ConstantsGameplaySkills.Deduction_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Deduction = new SkillValue(value.Value.Value, value.Offset.Value);

        value = GetValue(data, ConstantsGameplaySkills.Education_AsByteArray);
        if (value.Value.HasValue && value.Offset.HasValue)
            characterSkills.Education = new SkillValue(value.Value.Value, value.Offset.Value);

        return characterSkills;
    }
       


    private static byte[] ReadAll(string fileName)
    {
        if (!File.Exists(fileName))
            throw new SaveGameFileNotFoundException(fileName);
        return File.ReadAllBytes(fileName);
    }
    private static byte[] ReadAll(Stream stream)
    {
        if (stream == null || !stream.CanSeek)
            throw new InvalidStreamException();
        
        Span<byte> buffer = new();
        stream.Position = 0;
        using BinaryReader br = new BinaryReader(stream);
        br.Read(buffer);

        return buffer.ToArray();
    }
}
