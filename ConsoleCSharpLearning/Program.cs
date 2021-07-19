using ConsoleCSharpLearning.Experiment;
using System;
using System.Collections.Generic;
using System.Reflection;
using ConsoleCSharpLearning.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleCSharpLearning
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //AsyncLearn a = new AsyncLearn();
            //_ = await a.Test3();
            //InheritenceLearn.TestCar();

            HTTPRequestLearn b = new HTTPRequestLearn();
            _ = await b.PostTodoWithoutModelClass();

            //AsyncLearn a = new AsyncLearn();
            //_ = await a.ChainTasks();



            //MoqLearn m = new MoqLearn();

            //m.MoqTest();




        }

        public static void JsonPractice()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog("dobbie", "hello", 11));
            dogs.Add(new Dog("Dibbie", "woot woot", 14));

            string output = JsonConvert.SerializeObject(dogs);

            Console.WriteLine(output);
        }
    }



    public class TestClass
    {
        public String Name;
        private Object[] values = new Object[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public Object this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                values[index] = value;
            }
        }

        public Object Value
        {
            get
            {
                return "the value";
            }
        }

        public TestClass() : this("initialName") { }
        public TestClass(string initName)
        {
            Name = initName;
        }

        int methodCalled = 0;

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void AddUp()
        {
            methodCalled++;
            Console.WriteLine("AddUp Called {0} times", methodCalled);
        }

        public static double ComputeSum(double d1, double d2)
        {
            return d1 + d2;
        }

        public static void PrintName(String firstName, String lastName)
        {
            Console.WriteLine("{0},{1}", lastName, firstName);
        }

        public void PrintTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        public void Swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
    }

    [DefaultMemberAttribute("PrintTime")]
    public class TestClass2
    {
        public void PrintTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }

    public class Base
    {
        static int BaseOnlyPrivate = 0;
        protected static int BaseOnly = 0;
    }
    public class Derived : Base
    {
        public static int DerivedOnly = 0;
    }
    public class MostDerived : Derived { }
}
