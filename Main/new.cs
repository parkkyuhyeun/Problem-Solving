using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true){
                string? ab = Console.ReadLine();
                string?[] abs = {};
                if(ab is not null){
                    abs = ab.Split(' ');
                }
                int a = int.Parse(abs[0]);
                int b = int.Parse(abs[1]);

                if(a == 0 && b == 0){
                    break;
                }
                Console.WriteLine(a+b);
            }
        }
    }
}