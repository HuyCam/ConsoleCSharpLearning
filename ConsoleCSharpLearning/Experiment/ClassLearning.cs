using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpLearning.Experiment
{
    public class ClassLearning
    {
        private static Action<string> printName;

        public void GeneratePrintNameStaticMethod()
        {
            printName = name => Console.WriteLine(name);
        }

        public void callPrintName(string[] names)
        {
            foreach (var name in names)
                printName(name);
        }
    }
}
