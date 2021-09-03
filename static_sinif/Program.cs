using System;

namespace static_sinif
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : " + Employee.EmployeeCount);
            
            Employee employee1 = new Employee("Ali","Demir","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı : " + Employee.EmployeeCount);
            
            Employee employee2 = new Employee("Ayşe","Demir","İnsan Kaynakları");
            Employee employee3 = new Employee("Mehmet","Demir","İnsan Kaynakları");
            Console.WriteLine("Çalışan Sayısı : " + Employee.EmployeeCount);


            Console.WriteLine("Toplama işlemi sonucu : " + Operation.Add(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu : " + Operation.Remove(400,200));

        }
    }

    class Employee{
        private static int employeeCount;   
        public static int EmployeeCount { get => employeeCount; }
    
        private string Name;
        private string Surname;
        private string Department;

        static Employee(){
            employeeCount = 0;
        }
        public Employee(string name, string surname, string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeCount++;
        }
    }

    static class Operation{
        public static int Add(int number1,int number2){
            return number1+number2;
        }

        public static int Remove(int number1,int number2){
            return number1-number2;
        }
    }
}
