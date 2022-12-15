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
                for(int j = count-i; j > 0; j--){
                    Console.Write(" ");
                }
                for(int l = 0; l <= i-1; l++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}