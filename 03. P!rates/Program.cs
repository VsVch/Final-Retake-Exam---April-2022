using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cityPopGold = new Dictionary<string, List<int>>();
            string inputFirst = Console.ReadLine();
            while (inputFirst != "Sail")
            {
                string[] inputFirstArray = inputFirst.Split("||");
                string cities = inputFirstArray[0];
                int population = int.Parse(inputFirstArray[1]);
                int gold = int.Parse(inputFirstArray[2]);
                if (cityPopGold.ContainsKey(cities))
                {
                    cityPopGold[cities][0] += population;
                    cityPopGold[cities][1] += gold;

                }
                else
                {
                    cityPopGold.Add(cities, new List<int>() {population, gold});

                }


                inputFirst = Console.ReadLine();
            }
            string secondInput = Console.ReadLine();
            while (secondInput != "End")
            {
                string[] secondInputArray = secondInput.Split("=>" , StringSplitOptions.RemoveEmptyEntries);
                string command = secondInputArray[0];
                string town = secondInputArray[1];
                if (command == "Plunder")
                {
                    int population = int.Parse(secondInputArray[2]);
                    int gold = int.Parse(secondInputArray[3].Trim());

                    cityPopGold[town][0] -= population;
                    cityPopGold[town][1] -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {population} citizens killed.");
                    if (cityPopGold[town][0] <= 0 || cityPopGold[town][1] <= 0)
                    {

                        Console.WriteLine($"{town} has been wiped off the map!");
                        cityPopGold.Remove(town);
                    }










                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(secondInputArray[2].Trim());
                    if (gold >=0 )
                    {
                        cityPopGold[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityPopGold[town][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                }
                


                secondInput = Console.ReadLine();
            }
            if (cityPopGold.Count <= 0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityPopGold.Count} wealthy settlements to go to:");
                foreach (var item in cityPopGold)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }

            }
        }
    }
}
