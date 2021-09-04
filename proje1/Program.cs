using System;
using System.Collections;

namespace proje1
{
    class Program
    {

        static void Main(string[] args)
        {


            Person.TelephoneBook();
            Entrance();

            static void Entrance()
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("**********************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek \n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");
                Console.Write("İşlem : ");
                Operation(int.Parse(Console.ReadLine()));

            }

            static void Continue()
            {
                Console.WriteLine("İşleme devam etmek istiyor musunuz ? (1)Evet (2)Hayır ");
                int x = int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Entrance();
                }
            }

            static void Operation(int select)
            {
                switch (select)
                {
                    case 1:
                        Person.Add();
                        Continue();
                        break;
                    case 2:
                        Person.Remove();
                        Continue();
                        break;
                    case 3:
                        Person.Update();
                        Continue();
                        break;
                    case 4:
                        Person.Get();
                        Continue();
                        break;
                    case 5:
                        Person.Search();
                        Continue();
                        break;

                }
            }
        }
    }

    class Person
    {

        private string name;
        private string surname;
        private long telephoneNumber;

        public Person() { }
        public Person(string _name, string _surname, long _telephoneNumber)
        {
            name = _name;
            surname = _surname;
            telephoneNumber = _telephoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long TelephoneNumber { get => telephoneNumber; set => telephoneNumber = value; }

        static ArrayList telephoneBook = new ArrayList();
        public static void TelephoneBook()
        {

            Person person1 = new Person("Ali", "Demir", 05434567890);
            Person person2 = new Person("Ayşe", "Yılmaz", 05434534590);
            Person person3 = new Person("Mehmet", "Aslan", 05437657890);
            Person person4 = new Person("Kadir", "Kaplan", 054235567890);
            Person person5 = new Person("Ahmet", "Demir", 05434566540);

            telephoneBook.Add(person1);
            telephoneBook.Add(person2);
            telephoneBook.Add(person3);
            telephoneBook.Add(person4);
            telephoneBook.Add(person5);
        }

        public static void Add()
        {
            Person newPerson = new Person();
            Console.Write("Lütfen isim giriniz : ");
            newPerson.Name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz : ");
            newPerson.Surname = Console.ReadLine();
            while (true)
            {
                Console.Write("Lütfen telefon numarası giriniz : ");
                bool isNumber = long.TryParse(Console.ReadLine(), out long number);
                if (isNumber == true)
                {
                    if (number.ToString().Length == 11)
                    {
                        newPerson.telephoneNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                }
            }
            telephoneBook.Add(newPerson);
            Person.Get();
        }

        public static void Get()
        {
            Console.WriteLine("**********************************************");
            foreach (Person item in telephoneBook)
            {
                Console.WriteLine("Ad : " + item.Name);
                Console.WriteLine("Soyad :" + item.Surname);
                Console.WriteLine("Telefon Numarası : " + item.TelephoneNumber);
                Console.WriteLine("-");
            }
        }

        public static void Remove()
        {
            string select = "";
            Console.WriteLine("**********************************************");
            Console.WriteLine("  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string remove = Console.ReadLine();
            foreach (Person item in telephoneBook)
            {
                if ((remove == item.Name) || remove == item.Surname)
                {
                    Console.WriteLine("{0} {1} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item.Name, item.Surname);
                    select = Console.ReadLine();
                    if (select == "y")
                    {
                        telephoneBook.Remove(item);
                    }
                    break;
                }
            }
            if (select != "y" && select != "n")
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n*Yeniden denemek için      : (2)");
                int selectNumber = int.Parse(Console.ReadLine());
                if (selectNumber == 2)
                {
                    Remove();
                }
            }

        }

        public static void Update()
        {
            string select = "";
            Console.WriteLine("**********************************************");
            Console.WriteLine("  Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string update = Console.ReadLine();
            foreach (Person item in telephoneBook)
            {
                if ((update == item.Name) || update == item.Surname)
                {
                    while (true)
                    {
                        Console.Write("Lütfen telefon numarası giriniz : ");
                        bool isNumber = long.TryParse(Console.ReadLine(), out long number);
                        if (isNumber == true)
                        {
                            if (number.ToString().Length == 10)
                            {
                                Console.WriteLine("{0} {1} isimli kişinin numarasını güncellemeye onaylıyor musunuz ?(y/n)", item.Name, item.Surname);
                                select = Console.ReadLine();
                                if (select == "y")
                                {
                                    item.telephoneNumber = number;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                        }
                    }
                }
            }
            if (select != "y" && select != "n")
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n* Güncellemeyi sonlandırmak için : (1)\n*Yeniden denemek için      : (2)");
                int selectNumber = int.Parse(Console.ReadLine());
                if (selectNumber == 2)
                {
                    Update();
                }
            }

        }

        public static void Search()
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)\nTelefon numarasına göre arama yapmak için: (2)");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                string search = Console.ReadLine();
                foreach (Person item in telephoneBook)
                {
                    if ((item.Name == search) || (item.Surname == search))
                    {
                        Console.WriteLine("Ad : " + item.Name);
                        Console.WriteLine("Soyad :" + item.Surname);
                        Console.WriteLine("Telefon Numarası : " + item.TelephoneNumber);
                        Console.WriteLine("-");
                    }
                }

            }
            else if (select == 2)
            {
                while (true)
                {
                    Console.Write("Lütfen telefon numarası giriniz : ");
                    bool isNumber = long.TryParse(Console.ReadLine(), out long number);
                    if (isNumber == true)
                    {
                        if (number.ToString().Length == 10)
                        {
                            foreach (Person item in telephoneBook)
                            {
                                if (item.TelephoneNumber == number)
                                {
                                    Console.WriteLine("Ad : " + item.Name);
                                    Console.WriteLine("Soyad :" + item.Surname);
                                    Console.WriteLine("Telefon Numarası : " + item.TelephoneNumber);
                                    Console.WriteLine("-");
                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hatalı telefon numarası girdiniz.Tekrar Deneyiniz.");
                    }
                }

            }


        }
    }
}
