using System;
namespace CSharpLearning
{
    public class LocalVariableExample
    {

        public void print()
        {
            int i;//local variable
            i = 10;
            int k = 20;
            Console.WriteLine(i);
            if (i == 10) {
                int j = 20;//local variable
            }
            //Console.WriteLine(j);
        }

    }
}
