using System;
using System.Collections;

namespace Test
{
    public class Program
    {
        public class Rectangle
        {
            private int width;
            public int GetWidth(){
                return width;
            }
            public void SetWidth(int width){
                if(width > 0) this.width = width;
            }
            private int height;
            public int GetHeight(){
                return height;
            }
            public void SetHeight(int height){
                if(height > 0) this.height = height;
            }
        }
        public class RectWithProp
        {
            public int Width{get;set;}
            public int Height{get;set;}
        }
        public class RectWithfullProp
        {
            private int width;
            public int Width{
                get => width;
                set{if(value > 0) width = value;}
            }
            private int height;
            public int Height{
                get => height;
                set{if(value > 0) height = value;}
            }
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            RectWithProp rectWP = new RectWithProp();
            RectWithfullProp rectWFP = new RectWithfullProp();
            rect.SetWidth(-10);
            rect.SetHeight(-10);
            rectWP.Width = -10;
            rectWP.Height = -10;
            rectWFP.Width = -10;
            rectWFP.Height = -10;

            Console.WriteLine($"Rect(W:{rect.GetWidth()} H:{rect.GetHeight()})\nRectWP(W:{rectWP.Width} H:{rectWP.Height})\nRectWFP(W:{rectWFP.Width} H:{rectWFP.Height})");
        }
    }
}