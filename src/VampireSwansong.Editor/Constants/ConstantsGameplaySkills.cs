using System.Text;

namespace VampireSwansong.Editor.Constants;

public class ConstantsGameplaySkills
{
    public const string Physical = "Gameplay.Attributes.Physical";
    public static readonly byte[] Physical_AsByteArray = Encoding.UTF8.GetBytes(Physical);
    public const string Social = "Gameplay.Attributes.Social";
    public static readonly byte[] Social_AsByteArray = Encoding.UTF8.GetBytes(Social);
    public const string Mental = "Gameplay.Attributes.Mental";
    public static readonly byte[] Mental_AsByteArray = Encoding.UTF8.GetBytes(Mental);

    //Dialog
    public const string Rhetoric = "Gameplay.Skills.Etiquette";
    public static readonly byte[] Rhetoric_AsByteArray = Encoding.UTF8.GetBytes(Rhetoric);
    public const string Intimidation = "Gameplay.Skills.Intimidation";
    public static readonly byte[] Intimidation_AsByteArray = Encoding.UTF8.GetBytes(Intimidation);
    public const string Persuasion = "Gameplay.Skills.Persuasion";
    public static readonly byte[] Persuasion_AsByteArray = Encoding.UTF8.GetBytes(Persuasion);
    public const string Psychology = "Gameplay.Skills.Psychology";
    public static readonly byte[] Psychology_AsByteArray = Encoding.UTF8.GetBytes(Psychology);

    //Exploration
    public const string Security = "Gameplay.Skills.Security";
    public static readonly byte[] Security_AsByteArray = Encoding.UTF8.GetBytes(Security);
    public const string Technology = "Gameplay.Skills.Technology";
    public static readonly byte[] Technology_AsByteArray = Encoding.UTF8.GetBytes(Technology);

    //Knowledge
    public const string Deduction = "Gameplay.Skills.Deduction";
    public static readonly byte[] Deduction_AsByteArray = Encoding.UTF8.GetBytes(Deduction);
    public const string Education = "Gameplay.Skills.Erudition";
    public static readonly byte[] Education_AsByteArray = Encoding.UTF8.GetBytes(Education);

    public const string None = "None";
    public static readonly byte[] None_AsByteArray = Encoding.UTF8.GetBytes(None);
}
