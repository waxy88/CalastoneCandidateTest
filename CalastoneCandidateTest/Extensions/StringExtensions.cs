using System;

namespace CalastoneCandidateTest.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }

        public static bool IsNotNullOrWhiteSpace(this string s)
        {
            return !s.IsNullOrWhiteSpace();
        }

        public static bool Contains(this string s, string value, StringComparison comparison)
        {
            return s.IndexOf(value, comparison) >= 0;
        }

        public static string GetMiddleCharacters(this string s)
        {
            return s.IsNullOrWhiteSpace() || s.Length < 3 ? s :
                s.Length % 2 == 0 ? s.Substring((s.Length / 2) - 1, 2) : s[s.Length / 2].ToString();
        }
    }
}
