using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeList = new ArrayList();
            ArrayList notPrimeList = new ArrayList();
            bool isPrimeNumber = true;
            for(int  i = 0 ; i <20 ; i++){
                while(true){
                    Console.Write((i+1) + ". sayıyı giriniz : ");
                    bool isNumber = int.TryParse(Console.ReadLine(),out int number);
                    if(isNumber == true){
                        if(number>0){
                            if(number == 1){
                                notPrimeList.Add(number);
                            }else if(number == 2){
                                primeList.Add(number);
                            }
                            else{
                                for(int j = 2 ; j < number ; j++){
                                    if(number % j == 0){
                                        notPrimeList.Add(number);
                                        isPrimeNumber = false;
                                        break;
                                    }
                                }
                                if(isPrimeNumber == true){
                                    primeList.Add(number);
                                }
                                isPrimeNumber = true;
                            }
                            break;
                        }else{
                            Console.WriteLine("Negatif sayı girdiniz.Tekrar deneyin");
                        }
                    }else{
                        Console.WriteLine("Nümeric olmayan değer girdiniz.Tekrar deneyiniz");
                    }
                }
 
            }
            double primeListSum = 0 ;
            double notPrimeListSum = 0 ;
            Console.WriteLine("Asal Sayılar :");
            primeList.Sort();
            foreach(int number in primeList){
                Console.WriteLine(number);
                primeListSum+=number;
            }
            Console.WriteLine("Asal Sayılar Listesinin Eleman Sayısı : " + primeList.Count);
            Console.WriteLine("Asal Sayılar Listesiniz Ortalaması : " + (primeListSum / primeList.Count));


            notPrimeList.Sort();
            Console.WriteLine("Asal Olmayan Sayılar :");
            foreach(int number in notPrimeList){
                Console.WriteLine(number );
                notPrimeListSum+=number;
            }
            Console.WriteLine("Asal Olmayan Sayılar Listesinin Eleman Sayısı : " + notPrimeList.Count);
            Console.WriteLine("Asal Olmayan Sayılar Listesiniz Ortalaması : " + (notPrimeListSum / notPrimeList.Count));
        }
    }
}
