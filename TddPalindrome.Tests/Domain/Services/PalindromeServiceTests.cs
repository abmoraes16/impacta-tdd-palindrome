using System;
using TddPalindrome.Domain.Services;
using Xunit;

namespace TddPalindrome.Tests.Domain.Services
{
    public class PalindromeTests
    {
        public PalindromeService palindromeService;

        [Theory]
        [InlineData("Rotator")]
        [InlineData("bob")]
        [InlineData("madam")]
        [InlineData("mAlAyAlam")]
        [InlineData("1")]
        [InlineData("Able was I, ere I saw Elba")]
        [InlineData("Madam I'm Adam")]
        [InlineData("Step on no pets.")]
        [InlineData("Top spot!")]
        [InlineData("02/02/2020")]
        public void TestPalindromeServicePhraseOrWordIsValid(String text)
        {
            palindromeService = new PalindromeService();
            var isValid = palindromeService.IsValid(text);

            Assert.True(isValid);
        }

        [Theory]
        [InlineData("")]
        [InlineData("xyz")]
        [InlineData("elephant")]
        [InlineData("Country")]
        [InlineData("Top . post!")]
        [InlineData("Wonderful-fool")]
        [InlineData("Wild imagination!")]
        public void TestPalindromeServicePhraseOrWordIsInvalid(String text)
        {
            palindromeService = new PalindromeService();
            var isValid = palindromeService.IsValid(text);

            Assert.False(isValid);
        }
    }
}
