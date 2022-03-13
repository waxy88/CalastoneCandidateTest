using System.Linq;
using CalastoneCandidateTest.Extensions;

namespace CalastoneCandidateTest.Filters
{
    public class MiddleVowelsFilter : IFilter
    {
        public string Filter(string word)
        {
            return word.IsNullOrWhiteSpace() ? word :
                    word.TrimEnd().GetMiddleCharacters().All(v => v.IsVowel()) ? string.Empty : word;
        }
    }

}
