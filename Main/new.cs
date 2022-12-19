using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
 
            string[] input2 = Console.ReadLine().Split(' ');
            int[] numbers = new int[n];
            for (int i = 0; i<n; i++)
            {
                numbers[i] = int.Parse(input2[i]);
            }

            int minNumber = numbers[numbers.Length - 1];
            int maxNumber = numbers[numbers.Length - 1];
            for (int i = 0; i < numbers.Length; i++)
            {
 
                int endN = numbers[numbers.Length - (i+1)];
            
                if (maxNumber <= endN)
                {
                    maxNumber = endN;
                }
 
                if (minNumber >= endN)
                {
                    minNumber = endN;
                }
            }
 
            Console.WriteLine("{0} {1}", minNumber, maxNumber);
        }
    }
}