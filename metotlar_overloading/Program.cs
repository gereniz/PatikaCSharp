using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi ="99";
            bool sonuc = int.TryParse(sayi,out int outSayi);
            if(sonuc == true){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else{
                Console.WriteLine("Başarısız");
            }

            Metotlar metotlar = new Metotlar();
            metotlar.Topla(2,3,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metot Aşırı Yükleme - Overloading

            int ifade = 999;
            metotlar.EkranaYazdir(ifade);
            metotlar.EkranaYazdir("Ayşe","Demir");
        }
    }

    class Metotlar{
        public void Topla(int a,int b,out int toplam){
            toplam = a+ b;
        }

        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1,string veri2){
            Console.WriteLine(veri1 + veri2);
        }
    }
}
