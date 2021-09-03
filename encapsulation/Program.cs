using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Ayşe";
            student1.Surname = "Demir";
            student1.StudentNumber = 123;
            student1.ClassNumber = 3;

            student1.PrintInfoOfStudent();

            student1.UpGrade();
            student1.PrintInfoOfStudent();

            Student student2 = new Student("Deniz","Arda",124,2);
            student2.PrintInfoOfStudent();

            student2.DownGrade();
            student2.PrintInfoOfStudent();

            student2.DownGrade();
            student2.PrintInfoOfStudent();

        }
    }

    class Student{

        private string name;
        private string surname;
        private int studentNumber;
        private int classNumber;

        public string Name { 
            get {
                return name;
            }
            set {
                name = value;
            }
            
        }
        public string Surname { get => surname; set => surname = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }
        public int ClassNumber { 
            get => classNumber; 
            set {
                if(value <= 1){
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    classNumber = 1;
                }else{
                    classNumber = value;
                }
            } 
        }

        public Student(string name, string surname = null, int studentNumber = 0, int classNumber = 0)
        {
            Name = name;
            Surname = surname;
            StudentNumber = studentNumber;
            ClassNumber = classNumber;
        }

        public Student(){}

        public void PrintInfoOfStudent(){
            Console.WriteLine("----Öğrenci Bilgileri---");
            Console.WriteLine("Öğrenci Adı : " + this.Name);
            Console.WriteLine("Öğrenci Soyadı : " + this.Surname);
            Console.WriteLine("Öğrenci Numarası : " + this.StudentNumber);
            Console.WriteLine("Öğrenci Sınıfı : " + this.ClassNumber);
        }

        public void UpGrade(){
            this.ClassNumber++;
        }

        public void DownGrade(){
            this.ClassNumber--;

        }
    }
}
