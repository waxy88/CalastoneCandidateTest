using NUnit.Framework;
using CalastoneCandidateTest.Extensions;
using CalastoneCandidateTest.Filters;


namespace CalastoneCandidateTest.Test
{
    public class LessThanThreeFilterTests
    {
        [Test]
        public void Returns_true_if_word_is_less_than_three()
        {
            var lttf = new LessThanThreeFilter();

            Assert.IsTrue(lttf.Filter("so").IsNullOrWhiteSpace());
        }
    }
}
