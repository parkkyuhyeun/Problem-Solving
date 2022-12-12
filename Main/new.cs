using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            string[] seperateInput = {};
            if(input is not null){
                seperateInput = input.Split(' ');
            }

            double a = double.Parse(seperateInput[0]);
            double b = double.Parse(seperateInput[1]);

            double ab = Math.Round(a/b, 10);
            Console.WriteLine(ab);
        }
    }
}