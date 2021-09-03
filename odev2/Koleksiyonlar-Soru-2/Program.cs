using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            ArrayList maxList = new ArrayList();
            ArrayList minList = new ArrayList();

            for(int i = 0 ; i <20 ; i++){
                Console.WriteLine((i+1) +". sayıyı giriniz ");
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
            }
            list.Sort();
            for(int i = 0 ; i < 3 ; i++){
                minList.Add(list[i]);
                maxList.Add(list[list.Count-i-1]);
            }

            Console.WriteLine("Liste");
            foreach(int number in list){
                Console.WriteLine(number);
            }

            double minListSum = 0 ;
            Console.WriteLine("Min Liste");
            foreach(int number in minList){
                Console.WriteLine(number);
                minListSum+=number;
            }

            double maxListSum = 0 ;
            Console.WriteLine("Max Liste");
            foreach(int number in maxList){
                Console.WriteLine(number);
                maxListSum+=number;
            }

            Console.WriteLine("Min Liste Ortalaması : " + (minListSum / minList.Count));
            Console.WriteLine("Max Liste Ortalaması : " + (maxListSum / maxList.Count));
            Console.WriteLine("Min Liste ve Max Liste Ortalaması Toplamı : " + ((minListSum / minList.Count)+(maxListSum / maxList.Count)));
        }
    }
}
