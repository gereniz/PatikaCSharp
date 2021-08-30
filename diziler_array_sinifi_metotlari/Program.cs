using System;

namespace diziler_array_sinifi_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("--- Sırasız Dizi ---");
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--- Sıralı Dizi ---");
            Array.Sort(sayiDizisi);
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--- Clear ---");
            Array.Clear(sayiDizisi,2,3); // 2. indexten itibaren 3 eleman sıfırlandı
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--- Reverse ---");
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

            Console.WriteLine("--- IndexOf ---");  
            Console.WriteLine(Array.IndexOf(sayiDizisi,23)); // 23 kaçıncı indexte
            
            Console.WriteLine("--- Resize ---");
            Array.Resize<int>(ref sayiDizisi,9); //Boyutu 9 yaptık
            sayiDizisi[8] = 99;
            foreach(var sayi in sayiDizisi){
                Console.WriteLine(sayi);
            }

        }
    }
}
