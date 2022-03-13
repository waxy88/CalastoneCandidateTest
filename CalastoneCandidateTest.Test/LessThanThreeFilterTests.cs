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

        [Test]
        public void Returns_false_if_word_is_greater_than_three()
        {
            var lttf = new LessThanThreeFilter();

            Assert.IsFalse(lttf.Filter("three").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_word_is_less_than_three_and_contains_whitespace()
        {
            var lttf = new LessThanThreeFilter();

            Assert.IsTrue(lttf.Filter("so ").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_word_is_less_than_three_and_contains_punctation()
        {
            var lttf = new LessThanThreeFilter();

            Assert.IsTrue(lttf.Filter("so!").IsNullOrWhiteSpace());
        }

    }
}
