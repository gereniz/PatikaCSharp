using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {

            //Datetime Kütüphanesi
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek); 
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datetime Format
            //02.09.2021 
            Console.WriteLine(DateTime.Now.ToString("dd")); //02
            Console.WriteLine(DateTime.Now.ToString("ddd")); //Per
            Console.WriteLine(DateTime.Now.ToString("dddd")); //Perşemce

            Console.WriteLine(DateTime.Now.ToString("MM")); //09
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Eyl
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //Eylül

            Console.WriteLine(DateTime.Now.ToString("yy"));  //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021

            Console.WriteLine(DateTime.Now.ToString("dd:MM:yyyy"));

            //Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25)); //negatif -> pozitif

            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10)); 
            Console.WriteLine(Math.Tan(10)); 

            Console.WriteLine(Math.Ceiling(22.3)); //üst 23
            Console.WriteLine(Math.Floor(22.7));   //alt  22
            Console.WriteLine(Math.Round(22.3));   //duruma göre 22
            Console.WriteLine(Math.Round(22.7));   //23

            Console.WriteLine(Math.Min(2,6));  
            Console.WriteLine(Math.Max(2,6));  

            Console.WriteLine(Math.Pow(2,3));  
            Console.WriteLine(Math.Sqrt(9));  
            Console.WriteLine(Math.Log(10));   //e tabanında
            Console.WriteLine(Math.Exp(3));    //e üzeri
            Console.WriteLine(Math.Log10(10));  
        }
    }
}
