using System;
using System.Linq;

namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] resultArr = new int[Math.Max(firstLine.Length, secondLine.Length)];

            for (int i = 0; i < resultArr.Length; i++)
            {
                int firstValue = firstLine[i % firstLine.Length];
                int secondValue = secondLine[i % secondLine.Length];

                int sum = firstValue + secondValue;
                Console.Write(sum + " ");
            }  
        }
    }
}
