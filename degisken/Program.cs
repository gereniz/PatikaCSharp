using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;     //1 byte
            sbyte sb = 5;   //1 byte
            short s = 5;    //1 byte
            ushort us = 5;   //2 byte

            Int16 i16 = 2;   //2 byte
            int i = 2;       //4 byte
            Int32 i32 = 2;   //4 byte
            Int64 i64 = 2;   //8 byte

            uint ui = 2 ;    //4 byte
            long l = 4;      //8 byte
            ulong ul= 4;     //8 byte

            //REEL SAYILAR
            float f = 5;     //4 byte
            double d = 5;    //8 byte
            decimal de = 5;  //16 byte

            char c = '2';    //2 byte
            string str = "Ayşe"; //infinite

            bool b1 = true;
            bool b2 = false;

            DateTime date = DateTime.Now;

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler
            string str1 = string.Empty;
            str1 = "Ayşe Demir";
            string name = "Ayşe";
            string surname = "Demir";
            string fullname = name + " " + surname;

            //Integer ifadeler
            int i1 = 5;
            int i2 = 3;
            int i3 = i1 * i2;

            //Boolean İfadeler
            bool b3 = 10>2;
            bool b4 = 10<2;

            //Değişken Dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string newValue1 = str20 + int20.ToString();
            int newValue2 = int20 + Convert.ToInt32(str20);
            int newValue3 = int20 + int.Parse(str20);

            Console.WriteLine(newValue1);  //çıktı 2020
            Console.WriteLine(newValue2);  //çıktı 40
            Console.WriteLine(newValue3);  //çıktı 40

            //Datetime
            //string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            //Console.WriteLine(datetime1);   //çıktı 30.07.2021

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);   //çıktı 30/07/2021

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);   //çıktı 18:34

        }
    }
}
