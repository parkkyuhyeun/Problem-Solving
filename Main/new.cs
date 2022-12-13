using System;
using System.Collections;

namespace BaekJoon
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? eye = Console.ReadLine();
            string[] eyes = {};
            if(eye is not null){
                eyes = eye.Split(' ');
            }
            int a = int.Parse(eyes[0]);
            int b = int.Parse(eyes[1]);
            int c = int.Parse(eyes[2]);
            
            if(a==b && b==c && c==a){
                Console.WriteLine(10000+a*1000);
            }
            else if((a==b&&a!=c&&b!=c) || (b==c&&b!=a&&c!=a) || (a==c&&c!=b&&a!=b)){
                if(a==b&&a!=c&&b!=c){
                    Console.WriteLine(1000+a*100);
                }
                else if(b==c&&b!=a&&c!=a){
                    Console.WriteLine(1000+b*100);
                }
                else if(a==c&&c!=b&&a!=b){
                    Console.WriteLine(1000+c*100);
                }
            }
            else if(a!=b && b!=c && c!=a){
                Console.WriteLine((a>b?(a>c?a:c):(b>c?b:c))*100);
            }
        }
    }
}