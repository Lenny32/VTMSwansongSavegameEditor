using System.Text;

namespace VampireSwansong.Editor.Constants;

public class ConstantsPlayer
{
    public const string Characters = "SubLevelReference.Characters";
    public static readonly byte[] Characters_AsByteArray = Encoding.UTF8.GetBytes(Characters);

    public const string Emem = "SubLevelReference.Characters.Emem";
    public static readonly byte[] Emem_AsByteArray = Encoding.UTF8.GetBytes(Emem);

    public const string Leysha = "SubLevelReference.Characters.Leysha";
    public static readonly byte[] Leysha_AsByteArray = Encoding.UTF8.GetBytes(Leysha);

    public const string Galeb = "SubLevelReference.Characters.Galeb";
    public static readonly byte[] Galeb_AsByteArray = Encoding.UTF8.GetBytes(Galeb);

}
