using System;
namespace SeleniumBasics.SeleniumClass2.collectionExamples
{
    public class TestExceptionHandling
    {

        static public void Main(string[] args)
        {
            TestExceptionHandling.divide(1, 0);

        }

        public static void divide(int num, int den)
        {
            try
            { 
                Console.WriteLine(num / den);//throw new AttempByZeroExcepion();
            }
            catch(Exception e)//Exception e= new AttempByZeroExcepion();
            {
               Console.WriteLine( e.Message);
            }
            finally
            {
                Console.WriteLine("This will always executed");
            }
        }

    }
}
