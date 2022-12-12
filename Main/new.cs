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

            int a = int.Parse(seperateInput[0]);
            int b = int.Parse(seperateInput[1]);

            Console.WriteLine(a + b);
        }
    }
}