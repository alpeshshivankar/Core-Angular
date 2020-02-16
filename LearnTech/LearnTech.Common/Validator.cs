using System;
using System.Text.RegularExpressions;

namespace LearnTech.Common
{
    public static class Validator
    {
        public static bool IsValidName(this string name)
        {
            bool isVal = false;
            string pattern = "[A-Z]";
            Regex nameRegex = new Regex(pattern, RegexOptions.IgnoreCase);
            isVal = nameRegex.IsMatch(name);
            return isVal;
        }
    }
}
