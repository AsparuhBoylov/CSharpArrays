using System;
using System.Linq;

namespace _04.TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isMach = false;
            
            

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j <= numbers.Length - 1; j++)
                {
                    int sum = numbers[i] + numbers[j];

                    if (numbers.Contains(sum))
                    {
                        isMach = true;
                        Console.WriteLine($"{numbers[i]} + {numbers[j]} == {sum}");
                    }                   
                    
                }
                
            }
            if (isMach != true)
            {
                Console.WriteLine("No");
            }

        }
    }
}
