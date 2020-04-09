using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalQuestion
{
    public class _02ReverseSentence : ITechnical
    {
        /* 
        How to reverse the order of words in a given string?
        
        Ans.: The user will input a sentence and we need to reverse the sequence of words in the sentence.

        input: Welcome to Csharp corner, output: corner Csharp to Welcome
        */
        public void AnswerToQuestion()
        {
            var str = "Welcome to Csharp corner";
            ReverseWordOrder(str);
        }

        void ReverseWordOrder(string str)
        {
            int i;
            StringBuilder reverseSentence = new StringBuilder();

            int Start = str.Length - 1;
            int End = str.Length - 1;

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverseSentence.Append(str[i]);
                        i++;
                    }
                    reverseSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }

            for (i = 0; i <= End; i++)
            {
                reverseSentence.Append(str[i]);
            }
            Console.WriteLine(reverseSentence.ToString());
        }
    }
}
