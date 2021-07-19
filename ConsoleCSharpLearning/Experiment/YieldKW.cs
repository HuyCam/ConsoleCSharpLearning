using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpLearning.Experiment
{
    /*
     * Yield technically help us create a collection on the fly without creating a Collection class.
     * Each time the "yield return" statement is encountered in the GenerateFibonacciNumbers() method,
     * the control is returned back to the Main method.
     */
    public class YieldKW
    {
        /*
         *  Yield returns the number or a value without exiting the moethod. There isn't any need of creating a temporary collection to hold data.
         *  The number are return one at a time.
         *  Each time the "yield return" statement is encountered in the GenerateFibonacciNumbers() method,
         *  the control is returned back to the Main method.
         */
        public IEnumerable<int> GenerateFibonacciNumbers(int n)
        {
            for (int i = 0, j = 0, k = 1; i < n; i++)
            {
                yield return j;
                int temp = j + k;
                j = k;
                k = temp;
            }

        }

        public IEnumerable<int> ReturnSomeNumber(int n)
        {
            for (int i = 0, j = 0; i < n; i++)
            {
                yield return j;
                j += 2;
            }
        }

        public IEnumerable<int> ReturnListofThing()
        {
            yield return 3;
            Console.WriteLine("After yield return 3. Before Yield Return 4");
            yield return 4;
            Console.WriteLine("After yield return 4. Before Yield Return 1000");
            yield return 1000;
            yield return 300;
        }


        public void TestReturnListofThing()
        {
            foreach (int x in ReturnListofThing())
            {
                Console.WriteLine("Before return some X");
                Console.WriteLine(x);
            }
        }
    }
}
