namespace _04._Fast_Food
{ 
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int food = int.Parse(Console.ReadLine());

            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Queue<int> orders = new Queue<int>(input);

            if (input.Count > 0)
            {
                Console.WriteLine(input.Max());
                if (input.Sum() <= food)
                {
                    Console.WriteLine("Orders complete");
                }
                else
                {
                    while(orders.Count > 0 )
                    { 
                        food -= orders.Peek();
                        if (food <= 0)
                        {
                            break;
                        }
                        else
                        {
                            orders.Dequeue();
                        }
                    }
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                }                
            }
        }
    }
}
