using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? nx = Console.ReadLine();
            string[] nxs = {};
            if(nx is not null) nxs = nx.Split(' ');
            int n = int.Parse(nxs[0]);
            int x = int.Parse(nxs[1]);
            string? a = Console.ReadLine();
            string[] a_array = {};
            if(a is not null) a_array = a.Split(' ');
            int?[] int_array = new int?[n];
            for(int i = 0; i < n; i++){
                int_array[i] = int.Parse(a_array[i]);
                if(int_array[i] < x){
                    Console.Write(int_array[i] + " ");
                }
            }
        }
    }
}