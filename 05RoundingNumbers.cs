using System;

namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
            }
            foreach (var item in numbers)
            {
                int roundedNumber = (int)Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{item} => {roundedNumber}");
            }
        }
    }
}
