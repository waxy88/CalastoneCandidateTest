using CalastoneCandidateTest.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace CalastoneCandidateTest.Filters
{
    public class MiddleVowelsFilter : IFilter
    {
        public string Filter(string word)
        {
            return word.IsNullOrWhiteSpace() ? word :
                    word.TrimEnd().GetMiddleCharacters().All(v => v.IsVowel()) ? string.Empty : word;
        }

        public List<string> Filter(List<string> inStr)
        {
            var result = new List<string>();

            foreach (var str in inStr)
            {
                var appendStr = str.IsNullOrWhiteSpace() ? str :
                    str.TrimEnd().GetMiddleCharacters().All(v => v.IsVowel()) ? string.Empty : str;
                if (appendStr.IsNotNullOrWhiteSpace()) result.Add(appendStr);
            }

            return result;
        }
    }

}
