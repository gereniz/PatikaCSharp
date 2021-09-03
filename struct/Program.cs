using System;

namespace structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.longShort = 4;
            rectangle.shortEdge = 3;

            Console.WriteLine("Class Alan Hesabı : " + rectangle.CalculateAres());

            RectangleStruct rectangleStruct = new RectangleStruct();
            rectangleStruct.longShort = 4;
            rectangleStruct.shortEdge = 3;

            Console.WriteLine("Struct Alan Hesabı : " + rectangleStruct.CalculateAres());
        }
    }

    class Rectangle{

        public int shortEdge;
        public int longShort;


        public long CalculateAres(){
            return this.shortEdge * this.longShort;
        }
    }

    struct RectangleStruct{

        public int shortEdge;
        public int longShort;


        public long CalculateAres(){
            return this.shortEdge * this.longShort;
        }
    }
}
