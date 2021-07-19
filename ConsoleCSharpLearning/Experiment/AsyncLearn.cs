using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Linq;

namespace ConsoleCSharpLearning.Experiment
{
    public class AsyncLearn
    {
        private int CountCharacters()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\camhu\\source\\repos\\ConsoleCSharpLearning\\ConsoleCSharpLearning\\Resources\\FlatFile.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;

                // Simulate busy
                Task.Delay(5000).Wait();
            }
            Console.WriteLine("Counted Characters " + count);
            return count;
        }

        private void TakeACupofCaffe()
        {
            Console.WriteLine("Taking a cup of caffe in NON ASYNC task");
            Console.WriteLine("Let take a sip of coffee while the program is working, it'll come soon");
        }


        private async Task<int> SomeAsyncCode()
        {
            Console.WriteLine("Starting Async task");
            await Task.Delay(3000);
            
            Console.WriteLine("Result from async Task is" + 3000);
            return 3000;
        }

        // define async mean we can call this method asynchronously
        public async void Test()
        {
            // delegate a method to a Task
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            
            Console.WriteLine("Processing files ...");
            TakeACupofCaffe();
            task.Wait();
            
            

            Console.ReadKey();
        }

        public void Test2()
        {
            /*
             * In Console application, when you have a asyn method and it return Tas<something>
             * You should Create a Task t = runmethod();
             * Proceeed with other algorithms
             * Make sure you have t.wait() at somewhere to wait for that task.
             */
            Console.WriteLine("Getting some Result");
            Task<int> t = SomeAsyncCode();
            TakeACupofCaffe();
            
            t.Wait();
            int r = t.Result;
            Console.WriteLine("result got back, it is " + r);
        }

        /*
         * Test 3, making coffe , wait for coffe and get back.
         */
        public async Task<int> Test3()
        {
            /*
             * In Console application, when you have a asyn method and it return Task<something>
             * You should Create a Task t = runmethod();
             * Proceeed with other algorithms
             * Make sure you have t.wait() at somewhere to wait for that task.
             */
            Console.WriteLine("Walking to get Coffee");
            Task<int> t = SomeAsyncCode();
            TakeACupofCaffe();

            int r = await t;
            Console.WriteLine("result got back, it is " + r);
            return 0;
        }

        public async Task<string> ChainTasks()
        {
            string[] taskNames= new string[] { "Task1", "Task2", "Task3" };
            var tasks = from taskName in taskNames
                       select this.ConfigurationTaskName(taskName)
                       .ContinueWith(configTaskNameTask => AddConfiguration(configTaskNameTask.Result));
            var backgroundProcesses = await Task.WhenAll(tasks);
            
            foreach (var result in backgroundProcesses)
            {
                var something = result;
                Console.WriteLine("something: " + something);
            }
            return "Finished chain task";
        }

        public async Task<string> ConfigurationTaskName(string name)
        {
            await Task.Delay(500);
            string result = "Working on Configuration Task Name for " + name;
            Console.WriteLine("Working on Configuration Task Name for " + name);

            return result;
        }

        public string AddConfiguration(string config)
        {
            string result = config;
            result += ". Added more configuration here.";
            return result;
        }

    }

    class Configuration
    {
        string _finalconfiguration;
        public Configuration(string result)
        {
            _finalconfiguration = result;
        }
    }
}
