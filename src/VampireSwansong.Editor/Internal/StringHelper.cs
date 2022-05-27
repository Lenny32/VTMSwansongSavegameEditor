using System.Text.RegularExpressions;

namespace VampireSwansong.Editor.Internal;

internal static class StringHelper
{
    public static bool IsMatch(this string str, string regex)
    {
        return Regex.IsMatch(str, regex);
    }
}