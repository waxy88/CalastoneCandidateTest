
using System.Collections.Generic;

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

            var result = middleVowelsFilter.Filter(listInStr);
            result = lessThanThreeFilter.Filter(result);
            result = removeLetterFilter.Filter(result);

            return string.Join("", result);
        }

    }
}
