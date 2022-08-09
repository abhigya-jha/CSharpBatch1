using System;
using System.Text;

namespace NewProject.AbstractAndInterface
{
    public class Cat:Animal
    {
        public override void Sound()
        {
            StringBuilder s = new StringBuilder("Hi");
            Console.WriteLine(s);
            s.Append(" Hello");
            Console.WriteLine(s);
            Console.WriteLine(s.Equals("Hi Hello"));


        }
    }
}
