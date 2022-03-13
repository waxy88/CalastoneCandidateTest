using NUnit.Framework;
using CalastoneCandidateTest.Extensions;
using CalastoneCandidateTest.Filters;

namespace CalastoneCandidateTest.Test
{
    public class MiddleVowelsFilterTests
    {
        [Test]
        public void Returns_true_if_odd_len_word_contains_vowels_in_middle()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsTrue(mvf.Filter("cat").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_false_if_odd_len_word_does_not_contain_vowels_in_middle()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsFalse(mvf.Filter("another").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_false_if_even_len_word_does_contain_a_vowel_in_middle()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsFalse(mvf.Filter("flat").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_even_len_word_contains_vowels_in_middle()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsTrue(mvf.Filter("bout").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_even_len_mixed_case_word_contains_vowels_in_middle()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsTrue(mvf.Filter("Bout").IsNullOrWhiteSpace());
        }

        [Test]
        public void Returns_true_if_odd_len_word_contains_vowels_in_middle_and_punctuation()
        {
            var mvf = new MiddleVowelsFilter();

            Assert.IsTrue(mvf.Filter("cat!").IsNullOrWhiteSpace());
        }
    }
}
