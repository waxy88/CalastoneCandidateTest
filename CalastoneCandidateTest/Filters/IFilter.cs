using System;
using System.Collections.Generic;
using System.Text;

namespace CalastoneCandidateTest.Filters
{
    public interface IFilter
    {
        string Filter(string word);

        List<string> Filter(List<string> inStr);
    }
}
