using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Namergy = new int[10];
            for(int i = 0; i < 10; i++){
                int a = int.Parse(Console.ReadLine());
                Namergy[i] = a%42;
            }
            int[] distArray = Namergy.Distinct().ToArray();
            Console.WriteLine(distArray.Length);
        }
    }
}