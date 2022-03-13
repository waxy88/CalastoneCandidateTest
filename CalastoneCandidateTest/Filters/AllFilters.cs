
using System.Collections.Generic;
using CalastoneCandidateTest.Extensions;

namespace CalastoneCandidateTest.Filters
{
    public class AllFilters
    {
        public AllFilters(){}

        private LessThanThreeFilter lessThanThreeFilter = new LessThanThreeFilter();
        private MiddleVowelsFilter middleVowelsFilter = new MiddleVowelsFilter();
        private RemoveLetterFilter removeLetterFilter = new RemoveLetterFilter();

        public string Apply(List<string> listInStr)
        {
            var result = new List<string>();
            foreach(var word in listInStr)
            {
                if (middleVowelsFilter.Filter(word).IsNotNullOrWhiteSpace() &&
                    lessThanThreeFilter.Filter(word).IsNotNullOrWhiteSpace() &&
                    removeLetterFilter.Filter(word).IsNotNullOrWhiteSpace())
                    result.Add(word);
            }

            return string.Join("", result);
        }

    }
}
