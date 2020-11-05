using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SimplePrograms.Logic
{
  
    [TestClass] 
    public class PalindromeTests
    {
        Palindrome palindrome;
        [TestInitialize]
        public void Setup()
        {
            palindrome = new Palindrome();
        }

        [TestMethod]
        public void IsPalindrome_WhenStringIsPalindrome_ReturnTrue()
        {
            var result = palindrome.IsPalindrome("dad");

            Assert.AreEqual(true,result);
        }

        [TestMethod]
        public void IsPalindrome_WhenStringIsNotPalindrome_ReturnFalse()
        {
            var result = palindrome.IsPalindrome("father");

            Assert.AreEqual(false,result);
        }

        [DataTestMethod]
        [DataRow(null)]
        [DataRow("")]
        [ExpectedException(typeof(ArgumentException))]
        public void IsPalindrome_WhenPassedValueIsNullOrEmpty_ThrowArgumentException(string parameter)
        {
            var result = palindrome.IsPalindrome(parameter);
          
        }
        
        
    }
}
