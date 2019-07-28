using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Basic_Stack
{
    class BasicStack
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input[0] - input[1]; i++)
            {
                stack.Push(numbers[i]);
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            int smallest = int.MaxValue;
            while (stack.Count > 0)
            {
                int current = stack.Pop();
                if (current == input[2])
                {
                    Console.WriteLine("true");
                    smallest = int.MaxValue;
                    break;                  
                }
                else if (smallest > current)
                {
                    smallest = current;
                }               
            }
            if (smallest != int.MaxValue)
            {
                Console.WriteLine(smallest);
            }
        }
    }
}
