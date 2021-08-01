using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)

            Console.WriteLine("---Implicit Conversion(Bilinçsiz Dönüşüm)---");
            
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d : " + d);

            long h =  d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i : " + i);

            string e = "ayşe";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g : " + g);

            //Emplicit Conversion(Bilinçli Dönüşüm)

            Console.WriteLine("---Emplicit Conversion(Bilinçli Dönüşüm)---");

            int x = 4;
            byte y = (byte) x;
            Console.WriteLine("y : " + y);
            
            int z = 100;
            byte t = (byte) z;
            Console.WriteLine("t : " + t);

            float w = 10.3f;
            byte v = (byte) w;
            Console.WriteLine("v : " + v);

            //ToString Metodu

            Console.WriteLine("---ToString Metodu---");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy : " + yy);

            
            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz);

            //System.Convert Sınıfı

            Console.WriteLine("---System.Convert Sınıfı---");

            string s1 = "10" ,s2 = "20";
            int number1,number2;
            int sum;

            number1 = Convert.ToInt32(s1);
            number2 = Convert.ToInt32(s2);
            sum = number1 +number2;
            Console.WriteLine("Toplam : " + sum);

            //Parse Metodu

            Console.WriteLine("---Parse Metodu---");

            string m1 = "10";
            string m2 = "10.25";
            int num1;
            double double1;

            num1 = Int32.Parse(m1);
            double1 = Double.Parse(m2);

            Console.WriteLine("num1: " + num1);
            Console.WriteLine("double1 : " + double1);

        }
    }
}
