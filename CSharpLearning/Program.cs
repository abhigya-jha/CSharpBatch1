using System;

namespace CSharpLearning
{
    class Program
    {
        static void Main(string[] args)
        {

            /*FunctionWithReturn obj = new FunctionWithReturn();
            Console.WriteLine("Please enter a integer value");
            int num = Convert.ToInt32(Console.ReadLine());
            obj.printEvenOrOdd(num);*/

            CallByValueVsCallByReference obj = new CallByValueVsCallByReference();
            int num = 10;//original value
            Console.WriteLine("Original Value before calling the function: "+num);
           // obj.doubleANumber(num);
            obj.doubleANumberByReference(ref num);
            Console.WriteLine("Original Value after calling the function: " + num);




        }
    }
}
