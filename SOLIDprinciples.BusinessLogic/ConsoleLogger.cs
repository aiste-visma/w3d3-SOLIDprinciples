using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDprinciples.Contracts;

namespace SOLIDprinciples.BusinessLogic
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) 
        { 
            Console.WriteLine(message);
        }
    }
}
