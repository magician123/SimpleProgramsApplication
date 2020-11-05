using System.Collections.Generic;

namespace SimplePrograms.Logic
{
    public class StringManipulation
    {
        public Dictionary<char, int> CountCharacterOccurance(string text)
        {

            //var keys = text.ToCharArray();
            Dictionary<char, int> occurrenceKeyValue = new Dictionary<char, int>();

            foreach (var key in text.Replace(" ", string.Empty))
            {
                int count = 1;

                if (occurrenceKeyValue.ContainsKey(key))
                    occurrenceKeyValue[key] = occurrenceKeyValue[key] + count;

                else
                    occurrenceKeyValue.Add(key, count);


            }

            return occurrenceKeyValue;

        }

        public string RemoveDuplicatedCharacter(string text)
        {
            Dictionary<char, char> textKeyValue = new Dictionary<char, char>();
            string newText = string.Empty;

            foreach (var key in text.Replace(" ",string.Empty))
            {
                if (!textKeyValue.ContainsKey(key))
                {
                    textKeyValue.Add(key, key);
                    newText += key;
                }                       
                    
            }

            return newText;
        }
    }
}
