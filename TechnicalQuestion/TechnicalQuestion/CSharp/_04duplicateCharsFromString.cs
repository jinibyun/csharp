using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalQuestion
{
    public class _04duplicateCharsFromString : ITechnical
    {
        /* 
        The user will input a string and the method should remove multiple occurrences of characters in the string
        
        input: csharpcorner, output: csharpone
        */
        public void AnswerToQuestion()
        {
            var str = "csharpcorner";
            removeduplicate(str);
        }

        void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
