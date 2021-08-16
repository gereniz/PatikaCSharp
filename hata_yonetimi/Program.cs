using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Console.WriteLine("Bir sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı : " + sayi);
         
            }
            catch(Exception e){
                Console.WriteLine("Hata : " + e.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem bitti");
            }

            // Hata Örnekleri 
            try
            {
                //int a = int.Parse(null);
                //int b = int.Parse("Text");
                int c = int.Parse("-200000000000000");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(e);
            }
            catch(FormatException e){
                Console.WriteLine("Veri tipi uygun değildir.");
                Console.WriteLine(e);
            }
            catch(OverflowException e){
                Console.WriteLine("Sınırı aşan değer girdiniz");
                Console.WriteLine(e);
            }
        }
    }
}
