using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using VampireSwansong.Editor.Types;

namespace VampireSwansong.Editor;

public class BasicSaveGame
{
    private static IEnumerable<PropertyInfo> _properties;

    static BasicSaveGame()
    {
        _properties = typeof(CharacterSkills).GetProperties().Where(x => x.PropertyType == typeof(SkillValue));
    }
    public byte[] Header { get; set; } = Array.Empty<byte>();
    public IEnumerable<Character> Characters { get; set; } = Array.Empty<Character>();
    public byte[] Rebuild()
    {
        using MemoryStream memoryStream = new MemoryStream();
        using BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

        binaryWriter.Write(Header);

        foreach (Character character in Characters)
        {
            if(character.Skills != null)
            {
                foreach (var property in _properties)
                {
                    var skill = property.GetValue(character.Skills) as SkillValue;
                    if(skill == null || !skill.IsDirty)
                        continue;

                    var offset = skill.Offset;
                    byte dataValue = character.Data[offset];
                    if (dataValue == skill.OriginalValue)
                    {
                        character.Data[offset] = skill.Value;
                    }
                }
            }
            
            binaryWriter.Write(character.Data);
        }
        binaryWriter.Flush();
        return memoryStream.ToArray();
    }
}
