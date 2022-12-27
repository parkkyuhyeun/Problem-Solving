using System;
using System.Collections;
using System.Linq;

namespace Test
{
    public class Program
    {
        public class Student
        {
            public string Name{get;set;}
            public int ID{get;set;}
            public List<int> Scores{get;set;}
        }
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            data.Add(2);
            data.Add(5);
            data.Add(7);
            data.Add(123);
            data.Add(244);
            data.Add(44);

            var sortedEven = from dt in data
                             where (dt%2)==0
                             orderby dt
                             select dt;
            foreach(int num in sortedEven){
                Console.Write(num + " ");
            }
            Console.WriteLine("");

            var lstEven = from lstDt in data
                          where (lstDt>20)
                          orderby lstDt descending
                          select lstDt;
            foreach(int num in lstEven){
                Console.Write(num+" ");
            }
            Console.WriteLine("");
            var lstSorted = from lstSort in lstEven
                            orderby lstSort
                            select lstSort * 2;
            foreach(int num in lstSorted){
                Console.Write(num+" ");
            }
            Console.WriteLine("");

            List<int> lstData = new List<int>();
            lstData.Add(1);
            lstData.Add(4);
            lstData.Add(536);
            lstData.Add(134);
            lstData.Add(421);
            lstData.Add(453);
            lstData.Add(314);
            lstData.Add(6533);
            var lstOdd = from odd in lstData
                         where (odd%2)==1
                         orderby odd
                         select odd;
            foreach(int i in lstOdd.ToList<int>()){
                Console.Write(i+" ");
            }
            Console.WriteLine("");
            var arrEven = from arr in lstData
                          where (arr%2)==0
                          orderby arr
                          select arr;
            foreach(int i in arrEven.ToArray<int>()){
                Console.Write(i+" ");
            }
           
            List<Student> students = new List<Student>(){
                new Student(){Name="박규현",ID=0413,Scores=new List<int>(){90,91,92}},
                new Student(){Name="한서진",ID=0413,Scores=new List<int>(){89,79,100}},
                new Student(){Name="이지훈",ID=0413,Scores=new List<int>(){92,96,99}},
                new Student(){Name="박현호",ID=0413,Scores=new List<int>(){100,100,100}}
            };
            static void HighScore(int exam, int cut){
                var highScores = from st in students
                                 where (st.Scores > cut)
                                 select {}

            }
        }
    }
}