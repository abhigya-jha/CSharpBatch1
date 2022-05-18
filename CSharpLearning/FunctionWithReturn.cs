using System;
namespace CSharpLearning
{
    public class FunctionWithReturn
    {

        //printEvenOrOdd
        //CheckEvenOrODD

        public void printEvenOrOdd(int number) {
            bool result = checkEvenOrOdd(number);//result=true
            if (result)//false
            {
                Console.WriteLine("Number " +number+" is even");
            }
            else
            {
                Console.WriteLine("Number " + number + " is odd");
            }
           

        }

        public bool checkEvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
