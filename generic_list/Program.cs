using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {

            //Liste oluşturma
            List<int> numberList = new List<int>();
            List<string> colorList = new List<string>();

            //Eleman ekleme
            numberList.Add(23);
            numberList.Add(10);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(92);
            numberList.Add(34);

           
            colorList.Add("Kırmızı");
            colorList.Add("Mavi");
            colorList.Add("Turuncu");
            colorList.Add("Sarı");
            colorList.Add("Yeşil");

             //Eleman Sayısı
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numberList.Count);

            //Eleman erişimi
            foreach(var number in numberList){
                Console.WriteLine(number);
            }
            foreach(var color in colorList){
                Console.WriteLine(color);
            }

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            //Eleman silme
            numberList.Remove(4);
            colorList.Remove("Yeşil");

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            numberList.RemoveAt(0);
            colorList.RemoveAt(1);

            numberList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(renk => Console.WriteLine(renk));

            //Eleman arama
            if(numberList.Contains(10)){
                Console.WriteLine("10 liste içinde bulundu");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(colorList.BinarySearch("Sarı"));

            //Diziyi List e çevirme
            string[] animals= {"Kedi","Köpek","Kuş"};
            List<string> animalList = new List<string>(animals);

            //Listeyi temizle
            animalList.Clear();

            //List içerisine nesne tutmak

            List<Users> userList = new List<Users>();
            Users user1 = new Users();
            user1.Name = "Ayşe";
            user1.Surname = "Demir";
            user1.Age=24;

            Users user2 = new Users();
            user2.Name = "Ali";
            user2.Surname = "Demir";
            user2.Age=25;

            userList.Add(user1);
            userList.Add(user2);
            userList.Add(new Users(){
                Name = "Deniz",
                Surname = "Arda",
                Age =20
            });

            foreach(var user in userList){
                Console.WriteLine("Kullanıcı Adı : " + user.Name);
                Console.WriteLine("Kullanıcı Soyadı : " + user.Surname);
                Console.WriteLine("Kullanıcı Yaşı: " + user.Age);
            }

            
        }
    }

    public class Users{
        private string name;
        private string surname;
        private int age;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
    }
}
