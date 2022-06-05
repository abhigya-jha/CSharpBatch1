using System;
namespace NewProject.OverloadingExamples
{
    public class Child:Parent
    {
        public Child(int value):base(value)
        {
            
            Console.WriteLine("Child class Single-arg constructor "+value);
        }


        static void Main(string[] args)
        {
            Child c = new Child(100);
        }
    }
}
