namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] carList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> cars = new Queue<string>(carList);
            List<string> servedCars = new List<string>();
            string command = string.Empty;

            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                if (command.ToLower() == "service" && cars.Count > 0)
                {                    
                    Console.WriteLine($"Vehicle {cars.Peek()} got served.");
                    servedCars.Add(cars.Dequeue());
                }
                else if (command.ToLower() == "history" && servedCars.Count > 0)
                {
                    servedCars.Reverse();
                    Console.WriteLine(string.Join(", ", servedCars));
                    servedCars.Reverse();
                }
                else if (command.Contains("Info"))
                {
                    string[] input = command.Split("-");
                    if (servedCars.Contains(input[1]))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
            }
            if (cars.Count > 0)
            {
                Console.WriteLine("Vehicles for service: " + string.Join(", ", cars));
            }
            
            servedCars.Reverse();
            Console.WriteLine("Served vehicles: " + string.Join(", ", servedCars));
        }
    }
}
