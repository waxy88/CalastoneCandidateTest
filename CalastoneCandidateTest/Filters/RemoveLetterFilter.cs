using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CalastoneCandidateTest.Filters
{
    public class RemoveLetterFilter : IFilter
    {
        const Char filterChar = 't';

        public string Filter(string word)
        {
            return Regex.IsMatch(word.TrimEnd(), filterChar.ToString()) ? string.Empty : word;
        }

        public List<string> Filter(List<string> inStrList)
        {
            var result = new List<string>();

            foreach(var str in inStrList)
            {
                if (!Regex.IsMatch(str.TrimEnd(), filterChar.ToString()))
                    result.Add(str);
            }

            return result;
        }
    }
}
