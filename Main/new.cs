using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? nm = Console.ReadLine();
            string[] nms = {};
            if(nm is not null){nms = nm.Split(' ');}
            int n = int.Parse(nms[0]);
            int m = int.Parse(nms[1]);
            int?[] array = new int?[n];
            for(int v = 0; v < m; v++)
            {
                string? ball = Console.ReadLine();
                string[] balls = {};
                if(ball is not null){balls = ball.Split(' ');}
                int i = int.Parse(balls[0]);
                int j = int.Parse(balls[1]);
                int k = int.Parse(balls[2]);
                for(int q = i-1; q <= j-1; q++)
                {
                    array[q] = k;
                }
            }
            for(int t = 0; t < n; t++)
            {
                if(array[t] == null){Console.Write("0 ");}
                else{Console.Write(array[t] + " ");}
            }
        }
    }
}