using System;
namespace NewProject.ConstructorExamples
{
    public class Student
    {
        string studentName;//instance variable
        int rollNumber;//instance variable

        public Student(string studentName, int rollNumber)
        {
            this.studentName = studentName;
            this.rollNumber = rollNumber;

        }


        /*public static void Main(string[] args)
                {
                    Student student1 = new Student("Rahul",101);
                    Console.WriteLine("Name--> "+student1.studentName);
                    Console.WriteLine("RollNumber--> "+student1.rollNumber);

                    Student student2 = new Student("Abhigya",102);
                    Console.WriteLine("Name--> " + student2.studentName);
                    Console.WriteLine("RollNumber--> " + student2.rollNumber);
                }

            }*/
    }
}
