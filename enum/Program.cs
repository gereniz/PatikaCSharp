using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int) Days.Tuesday);

            int heat = 32;
            if(heat <= (int) Weather.Normal){
                Console.WriteLine("Dışarı çıkmak için havanın ısınması bekle");
            }else if(heat >= (int)Weather.Hot){
                 Console.WriteLine("Dışarı çıkmak için hava sıcak");
            }else if(heat>=(int)Weather.Normal && heat<=(int)Weather.Normal){
                 Console.WriteLine("Hadi dışarı çıkalım");
            }

        }
    }

    enum Days{
        Monday = 1,
        Tuesday, //2
        Wednesday, //3
        Thursday, //4
        Friday = 21, 
        Saturday,  //22
        Sunday   //23
    }

    enum Weather{

        Cold = 5,
        Normal =20,
        Hot = 30,
        VeryHot = 40
    }
}
