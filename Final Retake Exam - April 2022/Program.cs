using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Data;

namespace Final_Retake_Exam___April_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalTime = 0;
            Dictionary<string, int> bandNameTime = new Dictionary<string, int>();
            Dictionary<string, List<string>> bandNameMembers = new Dictionary<string, List<string>>();
            while (input != "Start!")
            {
                string[] inputArr = input.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                string bandName = inputArr[1];
                if (command == "Add")
                {
                    string names = inputArr[2];
                    string[] namesArr = names.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < namesArr.Length; i++)
                    {
                        string name = namesArr[i];
                        //Console.WriteLine(name);
                        if (!bandNameMembers.ContainsKey(bandName))
                        {
                            bandNameMembers.Add(bandName,new List<string>());
                        }
                        bandNameMembers[bandName].Add(name);
                    }
                }
                if (command == "Play")
                {
                    int time = int.Parse(inputArr[2]);

                    if (!bandNameTime.ContainsKey(bandName))
                    {
                        bandNameTime.Add(bandName, time);
                    }
                    else
                    {
                        bandNameTime[bandName] += time;
                    }
                    totalTime += time;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in bandNameTime)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            foreach (var item in bandNameMembers)
            {
                Console.WriteLine($"ioiooioio");
                Console.WriteLine($"{item.Key}{item.Value}");
            }
        }
    }
}
