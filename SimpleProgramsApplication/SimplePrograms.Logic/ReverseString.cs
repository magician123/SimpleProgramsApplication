using System;

namespace SimplePrograms.Logic
{
    public class ReverseString
    {
        public string Reverse(string text)
        {
            //var textArray = text.ToArray();
            //string newText = string.Empty;

            //for (int i = textArray.Length - 1; i >= 0; i--)
            //{
            //    newText += textArray[i].ToString();
            //}

            //return newText;


            var charArray = text.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);

        }
    }
}
