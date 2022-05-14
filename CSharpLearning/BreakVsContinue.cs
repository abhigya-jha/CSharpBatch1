using System;
namespace CSharpLearning
{
    public class BreakVsContinue
    {
        public void breakVsContinue() {


            for(int i = 1; i <= 10; i++)
            {
                if (i == 5 || i==8)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

    }
}
