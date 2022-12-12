using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            string[] s_array = {};
            if(input is not null){
                s_array = input.Split(' ');
            }

            float a = float.Parse(s_array[0]);
            float b = float.Parse(s_array[1]);
            float c = MathF.Truncate(b-2);
            float d = MathF.Truncate(b-1);
            
            Console.WriteLine($"{a} {b} {c} {d}");
        }
    }
}