using System.Reflection;

namespace VampireSwansong.UI;
public partial class SkillEditor : UserControl
{
    //Not clean but I am tired.
    static readonly PropertyInfo[] _properties = typeof(EditorSkills).GetProperties();
    public EditorSkills Skills { get; init; }
    public SkillEditor()
    {
        InitializeComponent();

        Skills = new EditorSkills(
            skillPhysical,
            skillSocial,
            skillMental,
            skillRhetoric,
            skillIntimidation,
            skillPersuasion,
            skillPsychology,
            skillSecurity,
            skillTechnology,
            skillDeduction,
            skillEducation
        );
    }

    public void AllowValueChangeEvent(bool allow)
    {
        if (allow)
        {
            skillSecurity.ValueChanged += ValueChanged;
            skillPhysical.ValueChanged += ValueChanged;
            skillSocial.ValueChanged += ValueChanged;
            skillMental.ValueChanged += ValueChanged;
            skillRhetoric.ValueChanged += ValueChanged;
            skillTechnology.ValueChanged += ValueChanged;
            skillEducation.ValueChanged += ValueChanged;
            skillPersuasion.ValueChanged += ValueChanged;
            skillPsychology.ValueChanged += ValueChanged;
            skillIntimidation.ValueChanged += ValueChanged;
            skillDeduction.ValueChanged += ValueChanged;
        }
        else
        {
            skillSecurity.ValueChanged -= ValueChanged;
            skillPhysical.ValueChanged -= ValueChanged;
            skillSocial.ValueChanged -= ValueChanged;
            skillMental.ValueChanged -= ValueChanged;
            skillRhetoric.ValueChanged -= ValueChanged;
            skillTechnology.ValueChanged -= ValueChanged;
            skillEducation.ValueChanged -= ValueChanged;
            skillPersuasion.ValueChanged -= ValueChanged;
            skillPsychology.ValueChanged -= ValueChanged;
            skillIntimidation.ValueChanged -= ValueChanged;
            skillDeduction.ValueChanged -= ValueChanged;
        }
    }

    public void ValueChanged(string sender, byte value)
    {
        _properties.Single(x => x.Name == sender).SetValue(Skills, value);
    }



    public void Reset()
    {
        Skills.Physical = 0;
        Skills.Social = 0;
        Skills.Mental = 0;
        Skills.Rhetoric = 0;
        Skills.Intimidation = 0;
        Skills.Persuasion = 0;
        Skills.Psychology = 0;
        Skills.Security = 0;
        Skills.Technology = 0;
        Skills.Deduction = 0;
        Skills.Education = 0;
    }

    public class EditorSkills
    {
        public EditorSkills(
            SkillSetEditor skillPhysical,
            SkillSetEditor skillSocial,
            SkillSetEditor skillMental,
            SkillSetEditor skillRhetoric,
            SkillSetEditor skillIntimidation,
            SkillSetEditor skillPersuasion,
            SkillSetEditor skillPsychology,
            SkillSetEditor skillSecurity,
            SkillSetEditor skillTechnology,
            SkillSetEditor skillDeduction,
            SkillSetEditor skillEducation
            )
        {
            _skillPhysical = skillPhysical;
            _skillSocial = skillSocial;
            _skillMental = skillMental;
            _skillRhetoric = skillRhetoric;
            _skillIntimidation = skillIntimidation;
            _skillPersuasion = skillPersuasion;
            _skillPsychology = skillPsychology;
            _skillSecurity = skillSecurity;
            _skillTechnology = skillTechnology;
            _skillDeduction = skillDeduction;
            _skillEducation = skillEducation;
        }
        private readonly SkillSetEditor _skillPhysical;
        private readonly SkillSetEditor _skillSocial;
        private readonly SkillSetEditor _skillMental;
        private readonly SkillSetEditor _skillRhetoric;
        private readonly SkillSetEditor _skillIntimidation;
        private readonly SkillSetEditor _skillPersuasion;
        private readonly SkillSetEditor _skillPsychology;
        private readonly SkillSetEditor _skillSecurity;
        private readonly SkillSetEditor _skillTechnology;
        private readonly SkillSetEditor _skillDeduction;
        private readonly SkillSetEditor _skillEducation;

        public byte? Physical { get => _skillPhysical.Value; set => _skillPhysical.Value = value; }
        public byte? Social { get => _skillSocial.Value; set => _skillSocial.Value = value; }
        public byte? Mental { get => _skillMental.Value; set => _skillMental.Value = value; }

        public byte? Rhetoric { get => _skillRhetoric.Value; set => _skillRhetoric.Value = value; }
        public byte? Intimidation { get => _skillIntimidation.Value; set => _skillIntimidation.Value = value; }
        public byte? Persuasion { get => _skillPersuasion.Value; set => _skillPersuasion.Value = value; }
        public byte? Psychology { get => _skillPsychology.Value; set => _skillPsychology.Value = value; }

        public byte? Security { get => _skillSecurity.Value; set => _skillSecurity.Value = value; }
        public byte? Technology { get => _skillTechnology.Value; set => _skillTechnology.Value = value; }

        public byte? Deduction { get => _skillDeduction.Value; set => _skillDeduction.Value = value; }
        public byte? Education { get => _skillEducation.Value; set => _skillEducation.Value = value; }
    }
}
