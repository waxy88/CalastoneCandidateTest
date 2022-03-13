using NUnit.Framework;
using CalastoneCandidateTest.Filters;

namespace CalastoneCandidateTest.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var ctf = new RemoveLetterFilter();


            Assert.Pass(ctf.Filter("taxes"));
        }
    }
}
