using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList oluşturma

            ArrayList list = new ArrayList();

            //Veri ekleme
            list.Add("Ayşe");
            list.Add(2);
            list.Add(true);
            list.Add('c');

            //Veri erişimi
            Console.WriteLine(list[1]);
            foreach(var item in list){
                Console.WriteLine(item);
            }

            //AddRange
            Console.WriteLine("----AddRange---");
            string[] colors = {"Kırmızı","Sarı","Yeşil"};
            List<int> numbers = new List<int>(){1,8,7,4,5,2};
            list.AddRange(colors);
            list.AddRange(numbers);

            foreach(var item in list){
                Console.WriteLine(item);
            }

            //Sort
            Console.WriteLine("----Sort---");
            ArrayList list1 = new ArrayList();
            list1.AddRange(numbers);
            list1.Sort();

            foreach(var item in list1){
                Console.WriteLine(item);
            }

            //BinarySearch -> Önce sırala sonra indexi ver
            Console.WriteLine("----Binary Search---");
            Console.WriteLine(list1.BinarySearch(7));

            //Reverse
            Console.WriteLine("----Reverse---");
            list1.Reverse();
            foreach(var item in list1){
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("----Clear---");
            list1.Clear();
        }
    }
}
