﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalQuestion
{
    public class _03countOccurrence : ITechnical
    {
        /* 
        How to count the occurrence of each character in a string?
        
        The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

        input: hello world;
        output: h – 1
                e – 1
                l – 3
                o – 2
                w – 1
                r – 1
                d – 1
        */
        public void AnswerToQuestion()
        {
            var str = "hello world";
            Countcharacter(str);
        }

        void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
    }
}
