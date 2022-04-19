using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            int totalTime = 0;

            List<string> input = new List<string>();

            var bandTime = new Dictionary<string, int>(); 
            var bandMembers = new Dictionary<string, List<string>>(); 

            while ((command = Console.ReadLine()) != "Start!")
            {
                input = command.Split("; ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string action = input[0];
                string band = input[1];

                if (action == "Add")
                {
                    List<string> members = input[2].Split(", ").ToList(); 

                    if (!bandMembers.ContainsKey(band))  
                    {
                        bandMembers.Add(band, new List<string>()); 
                    }

                    for (int i = 0; i < members.Count; i++)
                    {
                        if (!bandMembers[band].Contains(members[i])) 
                        {
                            bandMembers[band].Add(members[i]);
                        }
                    }
                }

                else if (action == "Play")
                {
                    int time = int.Parse(input[2]);
                    totalTime += time;

                    if (!bandTime.ContainsKey(band)) 
                    {
                        bandTime.Add(band, time);
                    }

                    else 
                    {
                        bandTime[band] += time; 
                    }
                }
            }

            

            Console.WriteLine($"Total time: {totalTime}"); 
            foreach (var item in bandTime)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            foreach (var item in bandMembers.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($" -> {item.Value}");
            }
        }
    }
}