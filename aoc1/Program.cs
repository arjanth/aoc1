using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> numbers = ParseNumberFile("C://Repos//aoc1//aoc1//aoc1//input.txt").ToList();

            int rest;
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                rest = 2020 - number;
                if (numbers.Contains(rest))
                {
                    Console.WriteLine($"{number} * {rest} = {number * rest}");
                    Console.WriteLine();
                }
            }







            // functie om file te lezen
            static int[] ParseNumberFile(string filename)
            {
                string fileContent = File.ReadAllText(filename);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                    integers[n] = int.Parse(integerStrings[n]);
                return integers;
            }


        }

    }
}
