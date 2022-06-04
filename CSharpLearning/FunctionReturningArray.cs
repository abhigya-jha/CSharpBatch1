using System;
namespace CSharpLearning
{
    public class FunctionReturningArray
    {
        //How can we return and pass array in a function

        // write a function to accept an array as argument and print the array elements in that function

        public void printArray(int[] array)//parameter(s)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }

      public int[] returnArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return array;
        }




        //Write a function where you will create an array and return it.
        //print the elemnts of the array returned by func in the main function
    }
}
