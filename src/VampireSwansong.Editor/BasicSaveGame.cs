using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using VampireSwansong.Editor.Types;

namespace VampireSwansong.Editor;

public class BasicSaveGame
{
    private readonly static IEnumerable<PropertyInfo> _properties;

    static BasicSaveGame()
    {
        _properties = typeof(CharacterSkills).GetProperties().Where(x => x.PropertyType == typeof(SkillValue));
    }
    public byte[] Header { get; set; } = Array.Empty<byte>();
    public IEnumerable<Character> Characters { get; set; } = Array.Empty<Character>();
    public byte[] Rebuild()
    {
        using MemoryStream memoryStream = new ();
        using BinaryWriter binaryWriter = new (memoryStream);

        binaryWriter.Write(Header);

        foreach (Character character in Characters)
        {
            if(character.Skills != null)
            {
                foreach (var property in _properties)
                {
                    if (property.GetValue(character.Skills) is not SkillValue skill || !skill.IsDirty)
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
