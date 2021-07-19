using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleCSharpLearning.Experiment
{
    class ForEachKW
    {
        public void ForEachExperiment() 
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(200);
            numbers.Add(15);
            numbers.Add(38);
            numbers.Add(50);
            numbers.Add(60);


            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
        }

        public void ForEachWithIndex()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(200);
            numbers.Add(15);
            numbers.Add(38);
            numbers.Add(50);
            numbers.Add(60);

            foreach (var (value, index) in numbers.Select((v,i) =>(v,i)))
            {
                Console.WriteLine(value + ". Index: " + index);
            }
        }
    }
}
