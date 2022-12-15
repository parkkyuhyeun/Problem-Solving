using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while(true){
                string? ab = Console.ReadLine();
                if(ab == null){
                    break;
                }
                string?[] abs = {};
                if(ab is not null){
                    abs = ab.Split(' ');
                }
                int a = int.Parse(abs[0]);
                int b = int.Parse(abs[1]);

                Console.WriteLine(a+b);

            }
        }
    }
}