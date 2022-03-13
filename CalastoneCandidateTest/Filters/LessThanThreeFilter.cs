using System.Text.RegularExpressions;

namespace CalastoneCandidateTest.Filters
{
    public class LessThanThreeFilter : IFilter
    {
        private Regex alphanumRgx = new Regex("[^a-zA-Z0-9 -]");

        public string Filter(string word)
        {
            return alphanumRgx.Replace(word, "").TrimEnd().Length < 3 ? string.Empty : word;
        }
    }
}
