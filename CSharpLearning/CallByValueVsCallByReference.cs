using System;
namespace CSharpLearning
{
    public class CallByValueVsCallByReference
    {
        //call by value

        public void doubleANumber(int number) {
            number = number * 2;
            Console.WriteLine("Doubled Number: "+number);//20
        }

        //call by reference

        public void doubleANumberByReference(ref int num)
        {
            num = num * 2;
            Console.WriteLine("Doubled Number: " + num);//20

        }
    }
}
