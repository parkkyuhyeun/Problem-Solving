using System;
using System.Collections;

namespace Test
{
    public class Program
    {
        public static int Count(int[] a, Predicate<int> prd){
            int cnt = 0;
            for(int i = 0; i<a.Length; i++){
                if(prd(i) == true){
                    cnt++;
                }
            }
            return cnt;
        }
        static void Main(string[] args)
        {
            Predicate<int> isOdd = (a) => {if(a%2==1) return true;else return false;};
            Console.WriteLine(isOdd(7));
            Predicate<string[]> isLowerCase = (a) => 
            {
                for(int i = 0; i < a.Length; i++){
                    if(a[i]==a[i].ToLower()){
                        return true;
                    }
                }
                return false;
            };
            string? st = Console.ReadLine();
            string[] st_array = {};
            if(st is not null){
                st_array = st.Split(' ');
            }
            Console.WriteLine(isLowerCase(st_array));


            int[] arr = {1,2,3,5,6,7,8};
            Predicate<int> prd = (arr) => {if(arr%2==0) return true; else return false;};
            int n = Count(arr, prd);
            Console.WriteLine("짝수 개수 : {0}개",n);
            Predicate<int> prd2 = (arr) => {if(arr%2==1) return true; else return false;};
            n = Count(arr, prd2);
            Console.WriteLine("홀수 개수 : {0}개",n);


            List<string> myList = new List<string>();
            myList.Add("cat");
            myList.Add("rabbit");
            myList.Add("tiger");
            myList.Add("elephant");
            myList.Add("zebra");
            myList.Add("lion");
            myList.Add("snake");
            bool exist = myList.Exists((str)=>str.Contains("z"));
            Console.WriteLine(exist);
            string name = myList.Find((str)=>str.Length==3);
            Console.WriteLine(name);
            List<string> longName = myList.FindAll((str)=>str.Length==6);
            foreach(string obj in longName){
                Console.WriteLine(obj);
            }
        }
    }
}