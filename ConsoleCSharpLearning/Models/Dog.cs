using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace ConsoleCSharpLearning.Models
{
    class Dog
    {
        [JsonProperty("My_Name")]
        public string _name { get; set; }
        [JsonProperty("My_Sound")]
        public string _sound { get; set; }
        [JsonProperty("My_Age")]
        public int _age { get; set; }

        public Dog()
        {

        }

        public Dog(string name, string sound, int age)
        {
            _name = name;
            _sound = sound;
            _age = age;
        }

        public void Moo()
        {
            Console.WriteLine("I am " + _name + " and I am " + _sound + " years old." + ". I like to " + _age);
        }
    }
}
