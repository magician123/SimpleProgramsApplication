using SimplePrograms.Logic;
using System;

namespace SimplePrograms.View
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTriagle binaryTriagle = new BinaryTriagle();

            // binaryTriagle.GenerateBinaryTriangle(5);


            Palindrome palindrome = new Palindrome();

            palindrome.IsPalindrome("dad");

            Console.ReadKey();
        }
    }
}
