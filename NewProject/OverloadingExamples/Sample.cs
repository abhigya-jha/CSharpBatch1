using System;
namespace NewProject.OverloadingExamples
{
    public class Sample
    {

        /*static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.add(10,20);
            obj.add(10, 20.5);

        }*/


        public void add(int a, int b)
        {
            Console.WriteLine(a+b);

        }
        public void add(int a, double b)
        {
            Console.WriteLine(a + b);

        }

        public void add(double a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void add(double a, double b)
        {
            Console.WriteLine(a + b);
        }



        public void add(int i, int j, int k)
        {
            Console.WriteLine(i+j+k);

        }




    }
}
