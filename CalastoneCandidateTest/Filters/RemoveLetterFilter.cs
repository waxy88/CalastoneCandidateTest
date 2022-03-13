using System;
using System.Text.RegularExpressions;

namespace CalastoneCandidateTest.Filters
{
    public class RemoveLetterFilter : IFilter
    {
        const Char filterChar = 't';

        public string Filter(string word)
        {
            return Regex.IsMatch(word.ToLower().TrimEnd(), filterChar.ToString()) ? string.Empty : word;
        }
    }
}
