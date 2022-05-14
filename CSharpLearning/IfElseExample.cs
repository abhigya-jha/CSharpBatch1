using System;
namespace CSharpLearning
{
    public class IfElseExample
    {
        public void printOddEven() {

            /*int i = 10;
            if (i % 2 == 0)
            {
                Console.WriteLine("i is an evemn number");
            }
            else
            {
                Console.WriteLine("i is an odd number");
            }*/
            // if size <=10 -->print small
            //if size >10 and size <=50--> print medium
            //if size >50--> print large


            int size = 100;

            if (size <= 10)
            {
                Console.WriteLine("small");
            }
            else if(size >10 && size <= 50)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("large");
            }



        }
    }
}
