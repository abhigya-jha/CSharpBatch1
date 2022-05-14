using System;
namespace CSharpLearning
{
    public class OneDArray
    {
        //syntax of creating 1d array
        public  char s;
        public void arrayExample()
        {
            int[] array = new int[5];// An array will created
            //Console.WriteLine("First Index Value--> "+array[5]);//default value
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            /*//Console.WriteLine(array[1]);//20
            for (int i=0;i<array.Length;i++)//i=5
            {
                Console.WriteLine(array[i]);//array[2]
            }
            //print array in reverse order
            Console.WriteLine("Printing the array in reverse order");
            for (int i = array.Length-1; i>=0; i--)//i=4; 4<=0
            {
                Console.WriteLine(array[i]);//array[2]
            }*/

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

            //String s = new String("Hi");//string class object will created
            //string s1 = "Hello";//string class object will get created
            

        }

    }
}
