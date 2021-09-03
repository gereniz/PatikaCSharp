using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Ayşe";
            employee1.Surname = " Kara";
            employee1.Number = 12345678;
            employee1.Department = "İnsan Kaynakları";

            employee1.InfoOfEmployee();

            Console.WriteLine("---------");
            
            Employee employee2 = new Employee();
            employee2.Name = "Deniz";
            employee2.Surname = " Arda";
            employee2.Number = 165432178;
            employee2.Department = "Satın Alma Departmanı ";

            employee2.InfoOfEmployee();
        }
    }


    class Employee{

        public string Name;
        public string Surname;
        public int Number;
        public string Department;

        public void InfoOfEmployee(){
            Console.WriteLine("Çalışan Adı : {0}",Name);
            Console.WriteLine("Çalışan Soyadı : {0}",Surname);
            Console.WriteLine("Çalışan Numarası : {0}",Number);
            Console.WriteLine("Çalışan Departmanı : {0}",Department);
        }
    }
}
