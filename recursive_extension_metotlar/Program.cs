using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resursive - Öz Yinelemeli
            //3^4

            int result = 1 ;
            for(int i = 0 ; i<4;i++){
                result*=3;
            }

            Console.WriteLine(result);

            Islemler islem = new();
            Console.WriteLine(islem.Expo(3,4));

            //Extension
            string ifade =  "Ayşe Demir";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);

            if(sonuc){
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.ConsoleWrite();

            int number = 5;
            Console.WriteLine(number.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }

    public class  Islemler{
        public int Expo(int sayi,int us){
            if(us<2){
                return sayi;
            }
            return Expo(sayi,us-1) * sayi;
        }
        //Expo(3,4)
        //Expo(3,3) * 3
        //Expo(3,2) * 3 * 3
        //Expo(3,1) * 3 * 3 * 3
        //3 * 3 * 3 * 3
    }

    public static class Extension{  //Extension class ve method lar static olmak zorundadır
        public static bool CheckSpace(this string param){ //this ile Extension metot yapılır
           return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param){
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param){
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param){
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param){
            Array.Sort(param);
            return param;
        }

        public static void ConsoleWrite(this int[] param){
            foreach(var par in param){
                Console.WriteLine(par);
            }
        }

        public static bool IsEvenNumber(this int param){
            if(param % 2 == 0){
                return true;
            }
            return false;
        }

        public static string GetFirstCharacter(this string param){
            return param.Substring(0,1);
        }

    }   
}
