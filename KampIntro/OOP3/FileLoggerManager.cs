﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class FileLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
}
