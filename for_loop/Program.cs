using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekranda girilen sayıya kadar olan tek sayıları yazdırma
            Console.Write("Bir sayı giriniz : ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasında tek ve çift toplamları yazdırma
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 0; i <=1000; i++)
            {
                if(i%2==0){
                    ciftToplam+=i;
                }else{
                    tekToplam+=i;
                }
            }
            Console.WriteLine("Çift sayıların toplamı : " + ciftToplam);
            Console.WriteLine("Tek sayıların toplamı : " + tekToplam);


            for (int i = 1; i < 10; i++){
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------");

            
            for (int i = 1; i < 10; i++){
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}
