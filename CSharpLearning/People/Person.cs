using System;
namespace CSharpLearning.People
{
     public class Person
    {


       
        public void publicMethod()
        {
            Console.WriteLine("public method");
        }

        private static void privateMethod()
        {
            Console.WriteLine("private method");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protected method");
        }

        internal void internalMethod()
        {
            Console.WriteLine("internal method");
        }
       
    }
}
