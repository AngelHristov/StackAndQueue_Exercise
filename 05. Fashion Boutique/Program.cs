namespace _05._Fashion_Boutique
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

            Stack<int> box = new Stack<int>(input);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currentRack = 0;
            while (box.Count > 0)
            {
                 currentRack += box.Peek();
                if (currentRack <= capacity)
                {
                    box.Pop();
                }
                else
                {
                    currentRack = 0;
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
