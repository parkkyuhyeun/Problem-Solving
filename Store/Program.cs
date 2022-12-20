using System;
using System.Collections;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();
            int result = 0;
            Action<int> act2 = (x) => result = x*x;
            act2(2);
            Console.WriteLine(result);
            Action<float, float> act3 = (x,y) => Console.WriteLine(x/y);
            act3(6,2);
        }
    }
}