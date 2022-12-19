using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9];
            int maxNumber = array[0];
            int arrayNumber = 0;
            for(int i = 0; i < 9; i++){
                array[i] = int.Parse(Console.ReadLine());
                if(array[i] > maxNumber){
                    maxNumber = array[i];
                }
                if(maxNumber == array[i]){
                    arrayNumber = i+1;
                }
            }
            Console.WriteLine($"{maxNumber}\n{arrayNumber}");
            // for(int i = 1; i <= array.Length; i++){
            //     if(maxNumber == array[i]){
            //         Console.WriteLine(i);
            //     }
            // }
        }
    }
}