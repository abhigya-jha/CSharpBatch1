using System;
namespace CSharpLearning
{
    public class ForLoopExample
    {
        public void forLoop()
        {
            for(int i = 1; i <= 10; i++)//i=11;11<=10-->false
            {
                Console.WriteLine(i);//10
            }

        }
        public void whileLoop()
        {
            int i = 11;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
