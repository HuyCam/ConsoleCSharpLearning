using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleCSharpLearning.Experiment
{
    public class LinqLearn
    {
        public void Test()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            int count = 
                (from score in scores
                where score > 80
                select score).Count();

            foreach (int i in scoreQuery)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine(count);
        }
    }
}
