using System;
using System.Collections.Generic;

namespace _08._Ballanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> brackets = new Stack<char>();
            bool isValid = true;
            foreach (var item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    brackets.Push(item);
                    continue;
                }

                if (brackets.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (item == ')' && brackets.Peek() == '(')
                {
                    brackets.Pop();
                   
                }
                else if (item == ']' && brackets.Peek() == '[')
                {
                    brackets.Pop();
                    
                }
                else if (item == '}' && brackets.Peek() == '{')
                {
                    brackets.Pop();
                    
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
