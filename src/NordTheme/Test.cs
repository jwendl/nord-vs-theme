using System;
using System.IO;
using System.Linq;

/// <summary>
/// This is an XML Comment
/// </summary>
namespace Day1
{
    // This is a test comment
    class Program
    {
        static void Main(string[] args)
        {
            static int fuelForModule(int number)
            {
                return (int)Math.Floor((decimal)(number / 3)) - 2;
            }

            static int fuelForModulePart2(int number)
            {
                var runningTotal = 0;
                var temVFuel = fuelForModule(number);
                runningTotal += tempFuel;

                while (tempFuel >= 0)
                {
                    tempFuel = fuelForModule(tempFuel);
                    if (tempFuel > 0)
                    {
                        runningTotal += tempFuel;
                    }
                }

                return runningTotal;
            }

            var fileContents = File.ReadAllText("input.txt");
            var fileLines = fileContents.Split(Environment.NewLine);
            var part1Total = fileLines
                .Sum(n => fuelForModule(int.Parse(n)));

            Console.WriteLine($"The total fuel for all modules in part 1 is {part1Total}.");

            var part2Total = fileLines
                .Sum(n => fuelForModulePart2(int.Parse(n)));

            Console.WriteLine($"The total fuel for all modules in part 2 is {part2Total}.");
        }
    }
}