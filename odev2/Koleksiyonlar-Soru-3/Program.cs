using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[]  vowel = {'a','e','ı','i','o','ö','u','ü','A','E','I','İ','O','Ö','U','Ü'};

            ArrayList list = new ArrayList();

            Console.Write("Bir cümle giriniz : ");
            string sentence = Console.ReadLine();

            foreach(char  s in sentence){
                foreach(char v in vowel){
                    if( s == v){
                        list.Add(v);
                        break;
                    }
                }
            }
            Console.WriteLine("Cümledeki sesli harfler : ");
            list.Sort();
            foreach(char item in list){
                Console.Write(item + " ");
            }
        }
    }
}
