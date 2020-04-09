using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalQuestion
{
    public class _01ReverseString : ITechnical
    {
        /* 
        How to reverse a string? 
        
        Ans.: The user will input a string and the method should return the reverse of that string

        input: hello, output: olleh
        input: hello world, output: dlrow olleh
        */
        public void AnswerToQuestion()
        {
            var str = "hello";
            ReverseString(str);
        }

        void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
