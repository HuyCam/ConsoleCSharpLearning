using System;
using System.Collections.Generic;
using System.Text;
using ConsoleCSharpLearning.Interfaces;
using Moq;

namespace ConsoleCSharpLearning.Experiment
{
    public class MoqLearn
    {
        public void MoqTest()
        {
            var coffeMachine = new Mock<ICoffeeMachine>();
            coffeMachine.Setup(m => m.MakeCoffee()).Returns(2);
            var coffeMachineObject = coffeMachine.Object;

            Console.WriteLine(coffeMachineObject.MakeCoffee());
        }
    }
}
