using System;
namespace CSharpLearning
{
    public class TwoDArray
    {

        public void TwoDArrayExample()
        {
            int[,] array = new int[3,3];//2d Array
            array[0, 0] = 10;
            array[0, 1] = 20;
            array[0, 2] = 30;

            array[1, 0] = 40;
            array[1, 1] = 50;
            array[1, 2] = 60;

            array[2, 0] = 70;
            array[2, 1] = 80;
            array[2, 2] = 90;

            Console.WriteLine(array.GetLength(1));
           /* for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+"  ");
                }
                Console.WriteLine();
            }*/

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }


        }
    }
}
