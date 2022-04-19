using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Data;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalTime = 0;
            Dictionary<string, List<string>> bandNameMember = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandNameTime = new Dictionary<string, int>();
            List<string> commandList = new List<string>();
            string name = string.Empty;
            while (input != "Start!")
            {
                string[] inputArr = input.Split("; ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                string bandName = inputArr[1];
                
                if (command == "Add")
                {

                    string[] members = inputArr[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);





                    for (int i = 0; i < members.Length; i++)
                    {
                        commandList.Add(members[i]);
                    }


                    if (!bandNameMember.ContainsKey(commandList[1]))
                    {
                        bandNameMember.Add(commandList[1], new List<string>());
                       // bandNameMember.Add(commandList[1], 0);
                    }
                    for (int i = 2; i < commandList.Count; i++)
                    {
                        if (!bandNameMember[commandList[1]].Contains(commandList[i]))
                        {
                            bandNameMember[commandList[1]].Add(commandList[i]);
                        }
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
            foreach (var itemff in bandNameMember)
            {
                Console.WriteLine($"=> {itemff.Value} {itemff.Key} ");
            }








            //int numCars = int.Parse(Console.ReadLine());
            //Dictionary<string, List<int>> carMilFuel = new Dictionary<string, List<int>>();
            //for (int i = 0; i < numCars; i++)
            //{
            //    string[] inputCars = Console.ReadLine().Split("|");
            //    string car = inputCars[0];
            //    int mileage = int.Parse(inputCars[1]);
            //    int fuel = int.Parse(inputCars[2]);
            //    carMilFuel.Add(car, new List<int>() {mileage, fuel});
            //}
            //string input = Console.ReadLine();
            //while (input!="Stop")
            //{
            //    string[] inputArr = input.Split(" : ");
            //    string command = inputArr[0];
            //    string car = inputArr[1];
            //    if (command == "Drive")
            //    {
            //        int distance = int.Parse(inputArr[2]);
            //        int fuel = int.Parse(inputArr[3]);
            //        if (fuel > carMilFuel[car][1])
            //        {
            //            Console.WriteLine($"Not enough fuel to make that ride");
            //        }
            //        else
            //        {
            //            carMilFuel[car][0] += distance;
            //            carMilFuel[car][1] -= fuel;
            //            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            //            if (carMilFuel[car][0] >= 100000)
            //            {
            //                carMilFuel.Remove(car);
            //                Console.WriteLine($"Time to sell the {car}!");
            //            }

            //        }
            //    }
            //    if (command == "Refuel")
            //    {
            //        int cur = carMilFuel[car][1];
            //        int fuel = int.Parse(inputArr[2]);
            //        carMilFuel[car][1] += fuel;
            //        if (carMilFuel[car][1] > 75)
            //        {
            //            carMilFuel[car][1] = 75;
            //            Console.WriteLine($"{car} refueled with {75-cur} liters");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{car} refueled with {fuel} liters");
            //        }
            //    }
            //    if (command == "Revert")
            //    {
            //        int cur = carMilFuel[car][0];
            //        int distance = int.Parse(inputArr[2]);
            //        carMilFuel[car][0] -= distance;
            //        if (carMilFuel[car][0] < 10000)
            //        {
            //            carMilFuel[car][0] = 10000;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
            //        }
            //    }



            //    input = Console.ReadLine();
            //}

            //foreach (var item in carMilFuel)
            //{
            //    Console.WriteLine($"{item.Key} -> Mileage: {item.Value[0]} kms, Fuel in the tank: {item.Value[1]} lt.");
            //}
        }
    }
}
