using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpLearning.Experiment
{
    public class DelegateLearn
    {
        public static void ActionDemonstration()
        {
            Console.WriteLine("--------------------------------Action Demonstration-----------------------------------------");
            Console.WriteLine("Action is a delegate but don't return any thing");
            Action<string, int> printName = (name,age) => Console.WriteLine("Printing out name:" + name + ". age: " +  age);
            string[] names = { "Huy", "David", "Layla", "Ditto" };
            int age = 20;
            foreach (var name in names)
            {
                printName(name, age);
                age++;
            }
                
            
        }

        public static void FuncDemonstration()
        {
            Console.WriteLine("--------------------------------Func Demonstration-----------------------------------------");
            Console.WriteLine("Func is a delegate take in 0 or more parameter and has a return value");
            Func<string, string> printName = name =>
             {
                 return "Printing out name:" + name;
             };

            string[] names = { "Huy", "David", "Layla", "Ditto" };

            foreach (var name in names)
                Console.WriteLine(printName(name)); 
        }
    }
}
