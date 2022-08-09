using System;
namespace NewProject.AbstractAndInterface
{
    public abstract class Animal
    {
        int size;
        public abstract void Sound();

        public static void Eat()
        {
            Console.WriteLine("Eat method of Animal");
        }
    }
}
