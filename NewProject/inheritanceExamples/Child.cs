using System;
namespace NewProject.inheritanceExamples
{
    public class Child : Base
    {


        /*public static void Main(string[] args)
        {
            Child obj = new Child();
            obj.display();//base class is using display method
            //Base.display();


        }*/

        public void display()
        {
            Console.WriteLine("display method of Child class");
            base.display();


        }



    }
}
