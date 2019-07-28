
namespace _02.Basic_Queue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = input[1]; i < input[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            int smallest = int.MaxValue;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
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
