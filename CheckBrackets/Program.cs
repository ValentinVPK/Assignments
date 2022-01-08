using System;
using System.Collections.Generic;

namespace CheckBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("abc()")); // true
            Console.WriteLine(Solution("abc(})adada")); // false
            Console.WriteLine(Solution("abc{(})adada")); // false
            Console.WriteLine(Solution("[abc()]adada")); // true
        }

        public static bool Solution(string input)
        {
            Stack<char> openingBrackets = new Stack<char>();

            bool isCorrect = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    openingBrackets.Push(input[i]);
                    continue;
                }
                else if (input[i] != '}' && input[i] != ')' && input[i] != ']') continue;


                if (openingBrackets.Count > 0)
                {
                    if (input[i] == '}')
                    {
                        if (openingBrackets.Peek() == '{') openingBrackets.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }

                    if (input[i] == ')')
                    {
                        if (openingBrackets.Peek() == '(') openingBrackets.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }

                    if (input[i] == ']')
                    {
                        if (openingBrackets.Peek() == '[') openingBrackets.Pop();
                        else
                        {
                            isCorrect = false;
                            break;
                        }
                    }
                }
                else
                {
                    isCorrect = false;
                    break;
                }
            }

            if (openingBrackets.Count > 0) isCorrect = false;

            return isCorrect;
        }
    }
}
