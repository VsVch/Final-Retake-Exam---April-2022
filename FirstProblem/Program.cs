using System;
using System.Text;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "For Azeroth")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                switch (command)
                {
                    case "GladiatorStance":
                        initial = initial.ToUpper();
                        Console.WriteLine(initial);
                        break;
                    case "DefensiveStance":
                        initial = initial.ToLower();
                        Console.WriteLine(initial);
                        break;
                    case "Dispel":
                        int index = int.Parse(inputArr[1]);
                        char letter = char.Parse(inputArr[2]);
                        if (index >= 0 && index < initial.Length)
                        {
                            StringBuilder sb = new StringBuilder(initial);
                            sb[index] = letter;
                            initial = sb.ToString();
                            Console.WriteLine("Success!");
                        }
                        else
                        {
                            Console.WriteLine("Dispel too weak.");
                        }
                        break;
                    case "Target":
                        string subCommand = inputArr[1];
                        switch (subCommand)
                        {
                            case "Change":
                                string subString = inputArr[2];
                                string secondSubstring = inputArr[3];
                                if (initial.Contains(subString))
                                {
                                    initial = initial.Replace(subString, secondSubstring);
                                    Console.WriteLine(initial);
                                }
                                break;
                            case "Remove":
                                subString = inputArr[2];
                                if (initial.Contains(subString))
                                {
                                    index = initial.IndexOf(subString);
                                    initial = initial.Remove(index, subString.Length);
                                    Console.WriteLine(initial);
                                }
                                break;
                            default:
                                Console.WriteLine("Command doesn't exist!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }

            }
        }
    }
}
