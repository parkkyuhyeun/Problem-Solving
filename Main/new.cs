using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i = 1; i<=T; i++){
                string? ab = Console.ReadLine();
                string[] abs = {};
                if(ab is not null){
                    abs = ab.Split(' ');
                }
                int a = int.Parse(abs[0]);
                int b = int.Parse(abs[1]);

                Console.WriteLine("Case #{0}: {1}",i,a+b);
            }
        }
    }
}