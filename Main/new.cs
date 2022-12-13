using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            for(int i = 0; i < testCase; i++){
                string num = Console.ReadLine();
                string[] nums = {};
                if(num is not null){
                    nums = num.Split(' ');
                }
                int a = int.Parse(nums[0]);
                int b = int.Parse(nums[1]);

                Console.WriteLine(a+b);
            }
        }
    }
}