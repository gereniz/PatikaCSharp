using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
            Console.WriteLine("---Atama ve İşlemli Atama---");

            int x = 3;
            int y = 5;
            y += 2;   //y = y+2;
            Console.WriteLine(y);
            y /= 1;   //y = y/1;
            Console.WriteLine(y);
            x *= 4;   //x = x*4;
            Console.WriteLine(x);
            x -=2;    //x = x-2;
            Console.WriteLine(x);

            //Mantıksal Operatörler
            Console.WriteLine("---Mantıksal Operatörler---");

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            if(isSuccess && !(isCompleted))
                Console.WriteLine("Fine");

            //İlişkisel Operatörler
            Console.WriteLine("---İlişkisel Operatörler---");

            int a = 3;
            int b = 4;

            bool result = a<b;
            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a<=b;
            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);
            result = a==b;
            Console.WriteLine(result);
            result = a!=b;
            Console.WriteLine(result);

            //Aritmetik Operatörleri
            Console.WriteLine("---Aritmetik Operatörleri---");

            int number1 = 10;
            int number2 = 5;

            int result1 = number1 / number2;
            Console.WriteLine(result1);
            result1 = number1 * number2;
            Console.WriteLine(result1);
            result1 = number1 + number2;
            Console.WriteLine(result1);
            result1 = number1 - number2;
            Console.WriteLine(result1);
            result1 = number1++; //önce atar sonra 1 artırır.
            Console.WriteLine(result1);
            result1 = number1 % number2;  //number1 = 11;
            Console.WriteLine(result1);

        }
    }
}
