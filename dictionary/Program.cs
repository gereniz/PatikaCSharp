using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary Tanımlama
            Dictionary<int,string> users = new Dictionary<int, string>();
            
            //Veri ekleme
            Console.WriteLine("---Veri Ekleme---");
            users.Add(10,"Ayşe Demir");
            users.Add(12,"Ali Demir");
            users.Add(15,"Deniz Arda");
            users.Add(18,"Özcan Coşar");

            //Veri erişimi
            Console.WriteLine("---Veri Erişimi---");
            foreach(var user in users){
                Console.WriteLine(user);
            }

            //Veri sayısı
            Console.WriteLine("---Veri Sayısı---");
            Console.WriteLine(users.Count);

            //Contains
            Console.WriteLine("---Contains---");
            Console.WriteLine(users.ContainsKey(10));
            Console.WriteLine(users.ContainsValue("Mehmet"));

            //Remove
            Console.WriteLine("---Remove---");
            users.Remove(12);
            foreach(var user in users){
                Console.WriteLine(user);
            }

            //Key-Value
            Console.WriteLine("---Key / Value---");
            foreach(var key in users.Keys){
                Console.WriteLine(key);
            }

            foreach(var value in users.Values){
                Console.WriteLine(value);
            }

        }
    }
}
