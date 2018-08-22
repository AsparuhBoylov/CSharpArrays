using System;

namespace _03.LastKNumbersSumSeq
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] numbers = new long[n];
            numbers[0] = 1;

            for (long currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                long startIndex = Math.Max(0, currentElement - k);
                long endIndex = currentElement;

                long sum = 0;
                for (long i = startIndex; i <= endIndex; i++)
                {
                    sum += numbers[i];
                }
                numbers[currentElement] = sum;
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
