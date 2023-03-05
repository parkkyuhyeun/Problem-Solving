using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n/4; i++)
            {
                Console.Write("long ");
            }
            Console.Write("int");
        }
    }
}