using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            string[] colors = new string[5];

            string[] animals = {"Kedi","Köpek","Kuş","Tavşan"};

            int[] dizi;
            dizi = new int[5];

            //Atama ve Erişim
            colors[0] = "Mavi";

            dizi[3] = 10;

            Console.WriteLine(animals[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(colors[0]);

            //Döngüler ile Kullanım

            //Klavyeden girilen sayıya kadar ortalama hesaplama
            Console.Write("Dizi eleman sayısını giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i = 0 ; i < diziUzunlugu ; i++){
                Console.Write("Lütfen dizini {0}. sayısını giriniz : " ,(i+1));
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayiDizisi){
                toplam += sayi;
            }
            Console.WriteLine("Ortalama : " + ( toplam/diziUzunlugu));
        }
    }
}
