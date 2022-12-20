using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] originalNumber = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            int[] checkNumber = new int[28];
            int[] dontCheckNumber = new int[2];
            for(int i = 0; i < 28; i++){
                checkNumber[i] = int.Parse(Console.ReadLine());
                dontCheckNumber = originalNumber.Where(num => num != checkNumber[i]).ToArray();
                Console.WriteLine(originalNumber.Where(num => num != checkNumber[i]));
            }
            int a = (dontCheckNumber[0]>dontCheckNumber[1]?dontCheckNumber[1]:dontCheckNumber[0]);
            int b = (dontCheckNumber[0]<dontCheckNumber[1]?dontCheckNumber[1]:dontCheckNumber[0]);
            Console.WriteLine($"{a}\n{b}");
        }
    }
}