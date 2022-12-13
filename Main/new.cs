using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int number = 0;

            for(int i = 0; i < n; i++){
                string? ss = Console.ReadLine();
                string[] tt = {};
                if(ss is not null){
                    tt = ss.Split(' ');
                }
                int cost = int.Parse(tt[0]);
                int num = int.Parse(tt[1]);

                number = number + cost*num;
            }
            Console.WriteLine(number==x?"Yes":"No");
        }
    }
}