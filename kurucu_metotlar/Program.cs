using System;

namespace kurucu_metotlar
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

            Console.WriteLine("---------");

            Employee employee3 = new Employee("Ali","Demir",98765431,"İnsan Kaynakları");

            employee3.InfoOfEmployee();

            Console.WriteLine("---------");

            Employee employee4 = new Employee("Ahmet","Yılmaz");

            employee4.InfoOfEmployee();
        }
    }

    class Employee{

        public string Name;
        public string Surname;
        public int Number;
        public string Department;

        public Employee(){}

        public Employee(string name,string surname){
            this.Name = name;
            this.Surname = surname;

        }
        public Employee(string name , string surname , int number , string department){
                this.Name = name;
                this.Surname = surname;
                this.Number = number;
                this.Department = department;
        }

        public void InfoOfEmployee(){
            Console.WriteLine("Çalışan Adı : {0}",Name);
            Console.WriteLine("Çalışan Soyadı : {0}",Surname);
            Console.WriteLine("Çalışan Numarası : {0}",Number);
            Console.WriteLine("Çalışan Departmanı : {0}",Department);
        }
    }
}
