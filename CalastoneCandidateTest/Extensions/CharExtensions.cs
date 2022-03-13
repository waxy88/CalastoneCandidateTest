using System.Linq;

namespace CalastoneCandidateTest.Extensions
{
    public static class CharExtensions
    {
        private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static bool IsVowel(this char c)
        {
            return Vowels.Any(v => v.ToString().ToUpperInvariant().Equals(c.ToString().ToUpperInvariant()));
        }
    }
}
