using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpLearning.Experiment
{
    public class InheritenceLearn
    {
        public static void TestCar()
        {
            Car c = new Car(2020, "Mercedes", "Gasoline");
            Console.WriteLine(c.ToString());
        }
    }

    abstract class Vehicle
    {
        public int Year { get; set; }
        public string Brand { get; set; }
        public abstract void honk();
    }

    class Car : Vehicle
    {
        public string EnergyType { get; set; }

        public Car(int year, string brand, string engergyType)
        {
            Year = year;
            Brand = brand;
            EnergyType = engergyType;
        }
        public override void honk()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string output = "Year: " + Year + ". Brand: " + Brand + ". EnergyType: " + EnergyType;
            return output;
        }
    }
}
