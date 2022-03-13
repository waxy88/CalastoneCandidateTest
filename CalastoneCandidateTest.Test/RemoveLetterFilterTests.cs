using NUnit.Framework;
using CalastoneCandidateTest.Extensions;
using CalastoneCandidateTest.Filters;

namespace CalastoneCandidateTest.Test
{
    public class RemoveLetterFilterTests
    {
        [Test]
        public void Returns_true_if_word_contains_filter_char()
        {
            var rlf = new RemoveLetterFilter();

            Assert.IsTrue(rlf.Filter("cat").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_uppercase_word_contains_filter_char()
        {
            var rlf = new RemoveLetterFilter();

            Assert.IsTrue(rlf.Filter("CAT").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_false_if_word_does_not_contain_filter_char()
        {
            var rlf = new RemoveLetterFilter();

            Assert.IsFalse(rlf.Filter("people").IsNullOrWhiteSpace());
        }
    }
}
