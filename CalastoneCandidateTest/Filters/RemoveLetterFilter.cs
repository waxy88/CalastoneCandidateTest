using System;
using System.Text.RegularExpressions;

namespace CalastoneCandidateTest.Filters
{
    public class RemoveLetterFilter : IFilter
    {
        public RemoveLetterFilter(char filterChar)
        {
            _filterChar = filterChar;
        }

        private char _filterChar = new char();

        public string Filter(string word)
        {
            return Regex.IsMatch(word.ToLower().TrimEnd(), _filterChar.ToString()) ? string.Empty : word;
        }
    }
}
