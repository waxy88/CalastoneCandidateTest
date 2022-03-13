using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CalastoneCandidateTest.Filters
{
    public class LessThanThreeFilter : IFilter
    {
        public LessThanThreeFilter() {}

        private Regex alphanumRgx = new Regex("[^a-zA-Z0-9 -]");

        public string Filter(string word)
        {
            return alphanumRgx.Replace(word, "").TrimEnd().Length < 3 ? string.Empty : word;
        }

        public List<string> Filter(List<string> inStr)
        {
            var result = new List<string>();

            foreach(var str in inStr)
            {
                if (alphanumRgx.Replace(str,"").TrimEnd().Length >= 3)
                    result.Add(str);
            }

            return result;
        }
    }
}
