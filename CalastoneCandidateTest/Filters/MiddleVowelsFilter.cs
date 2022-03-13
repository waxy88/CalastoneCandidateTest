using System.Linq;
using System.Text.RegularExpressions;
using CalastoneCandidateTest.Extensions;

namespace CalastoneCandidateTest.Filters
{
    public class MiddleVowelsFilter : IFilter
    {
        private Regex alphanumRgx = new Regex("[^a-zA-Z0-9 -]");

        public string Filter(string word)
        {
            var cleanedStr = alphanumRgx.Replace(word, "").TrimEnd();

            return word.IsNullOrWhiteSpace() ? word :
                    cleanedStr.GetMiddleCharacters().All(v => v.IsVowel()) ? string.Empty : word;
        }
    }

}
