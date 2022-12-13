using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float num2_1 = num2 % 10;
            float num2_10 = num2 % 100 - num2 % 10;
            float num2_100 = num2 - num2%100;

            Console.WriteLine($"{num1 * num2_1}\n{num1 * num2_10 / 10}\n{num1 * num2_100/ 100}\n{num1 * num2}");
        }
    }
}