﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBaseLoggerService : ILoggerService
    {
        void ILoggerService.Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
