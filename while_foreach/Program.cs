using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayarak console den girilen sayıya kdar olan sayıların toplamı
            Console.Write("Bir sayı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int count = 1;
            int sum = 0;
            while (count <= number)
            {
                sum+=count;
                count++;
            }
            Console.WriteLine("Ortalama : " + (sum/number));

            // 'a'dan 'z'ye kadar olan harfleri yazdır
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character + " ");
                character++;
            }
            Console.WriteLine("---------");

            string[] cars = {"BMW","Ford","Toyoto","Nissan"};
            foreach(var car in cars){
                Console.WriteLine(car);
            }
        }
    }
}
