using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {

            //Liste oluşturma
            List<int> sayiListesi = new List<int>();
            List<string> renkListesi = new List<string>();

            //Eleman ekleme
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

           
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

             //Eleman Sayısı
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Eleman erişimi
            foreach(var sayi in sayiListesi){
                Console.WriteLine(sayi);
            }
            foreach(var renk in renkListesi){
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Eleman silme
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Eleman arama
            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 liste içinde bulundu");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        }
    }
}
