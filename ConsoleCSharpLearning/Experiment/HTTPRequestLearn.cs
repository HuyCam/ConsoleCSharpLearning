using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ConsoleCSharpLearning.Models;
using Newtonsoft.Json;

namespace ConsoleCSharpLearning.Experiment
{
    public class HTTPRequestLearn
    {
        public async Task<int> GetTodoList()
        {
            // Create a New HttpClient object.
            HttpClient client = new HttpClient();

            // Call asynchronous network methods in a try/catch block to handle exceptions
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/1");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            // Need to call dispose on the HttpClient object
            // when done using it, so the app doesn't leak resources
            client.Dispose();
            return 0;
        }

        public async Task<int> PostTodoWithModelClass()
        {
            var person = new Post(1, "Title", "completed");

            var json = JsonConvert.SerializeObject(person);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://jsonplaceholder.typicode.com/posts";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

            return 0;
        }

        public async Task<int> PostTodoWithoutModelClass()
        {
            var person = new Post(1, "Title", "completed");
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "https://jsonplaceholder.typicode.com/posts";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);

            return 0;
        }
    }
}
