using System;
using System.Collections.Generic;
using System.Text;

namespace sf_17_5_2
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
