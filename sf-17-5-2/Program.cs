using System;

namespace sf_17_5_2
{
    class Program
    {
        static ILogger Logger { get; set; }
        static ICalculator Calculator { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Calculator = new Calculator(Logger);

            while (true)
            {
                try
                {
                    Console.Write("Введите первое число: ");
                    int numberOne = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Выполняем операцию сложения...");
                    Console.WriteLine("{0} + {1} = {2}", numberOne, numberTwo, Calculator.Addition(numberOne, numberTwo));
                }

                catch (System.FormatException ex)
                {
                    Logger.Error(ex.Message);
                    Console.WriteLine("Введите корректное число!");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Произошла непредвиденная ошибка в приложении. Текст ошибки: {0}", ex.Message);
                }
            }
        }
    }
}
