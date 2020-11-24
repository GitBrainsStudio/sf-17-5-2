using System;
using System.Collections.Generic;
using System.Text;

namespace sf_17_5_2
{
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : {1} : {2}", "Error", DateTime.Now, message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} : {1} : {2}", "Event", DateTime.Now,  message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
