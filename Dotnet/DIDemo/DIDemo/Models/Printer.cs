using DIDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Models
{
    public class Printer : IPrinter
    {
        public string WriteMessage(string message) 
        {
            return ($"Printer.WriteMessage Message: {message}");
        }
    }
}
