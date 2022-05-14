using System;
namespace CSharpLearning
{
    public class SwitchCaseExample
    {
        public void switchcase()
        {
            int i = 20;

            switch (i)//10
            {
                case 10:
                    Console.WriteLine("it is 10");
                    break;
                    
                case 20:
                    Console.WriteLine("it is 20");
                    break;
                case 30:
                    Console.WriteLine("it is 30");
                    break;
                default:
                    Console.WriteLine("it is not matching");
                    break;
                    

            }

        }
    }
}
