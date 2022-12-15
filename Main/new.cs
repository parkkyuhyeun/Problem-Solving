using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for(int i = 1; i <= count; i++){
                for(int j = 0; j < i; j++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}