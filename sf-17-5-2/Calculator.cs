using System;
using System.Collections.Generic;
using System.Text;

namespace sf_17_5_2
{
    public class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        public int Addition(int a, int b)
        {
            Logger.Event("Калькулятор производит сложение двух чисел " + a + " и " + b);
            return a + b;
        }
    }
}
