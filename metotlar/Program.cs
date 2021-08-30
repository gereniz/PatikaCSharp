using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Topla(2,3);
            Console.WriteLine(sonuc);

            
            Metot metot = new Metot();
            metot.ekranaYazdir(Convert.ToString(sonuc)); 

            int a = 2;
            int b =3 ;
            int sonuc2 = metot.arttırVeTopla(ref a, ref b);
            metot.ekranaYazdir(Convert.ToString(sonuc2));
            metot.ekranaYazdir(Convert.ToString(a+b)); //ref siz 5
        }

        static int Topla(int x ,int y){
            return x+y;
        }
        
    }

    class Metot{
        public void ekranaYazdir(string veri){
            Console.WriteLine(veri);
        }

        public int arttırVeTopla(ref int deger1,ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
