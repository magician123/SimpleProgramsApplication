using System;
using System.Collections.Generic;
using System.Text;

namespace SimplePrograms.Logic
{
    public class Palindrome
    {
        public bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("The value is cannot be null or empty");

            string newWord = string.Empty;

            for (int i = word.Length; i > 0; i--)
            {
                newWord += word.Substring(i);
            }

            return (word == newWord) ? true : false;
        }
    }
}
