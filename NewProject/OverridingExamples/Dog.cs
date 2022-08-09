using System;
namespace NewProject.OverridingExamples
{
    public class Dog : Animal 
    {
        public Dog()
        {
        }



        /*static void Main(String[] args)
        {
            Dog obj = new Dog();
            obj.sound();
        }*/

        public new void  sound()
        {
            Console.WriteLine("woof woof");
            
        }

    }
}
