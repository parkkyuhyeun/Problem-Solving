using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? count = 0;
            int n = int.Parse(Console.ReadLine());
            int?[] int_array = new int?[n];
            string? number = Console.ReadLine();
            string?[] numbers = {};
            if(number is not null){
                numbers = number.Split(' ');
            }
            for(int i = 0; i < n; i++){
                int_array[i] = int.Parse(numbers[i]);
            }
            int v = int.Parse(Console.ReadLine());
            for(int j = 0; j < n; j++){
                if(int_array[j] == v) count++;
            }
            Console.WriteLine(count);
        }
    }
}