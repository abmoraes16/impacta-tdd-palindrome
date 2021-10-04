using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TddPalindrome.Domain.Services
{
    public class PalindromeService
    {
        public bool IsValid(string text)
        {
            if(string.IsNullOrEmpty(text))
                return false;

            text = Regex.Replace(text.ToLower(), @"[\.\\\/\?\!\,\' *]", "");
            string inverted = new string(text.Reverse().ToArray());

            if(text == inverted)
                return true;

            return false;
        }
    }
}
