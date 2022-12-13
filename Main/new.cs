using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            for(int i = 1; i <= n; i++){
                num = num+i;
            }
            Console.WriteLine(num);
        }
    }
}