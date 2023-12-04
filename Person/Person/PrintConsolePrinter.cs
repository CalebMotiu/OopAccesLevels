using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class PrintConsolePrinter
    {
        static void ConsolePrinter(Person p)
        {
            Console.WriteLine(p.LastName, p.FirstName, p.DateOfBirth, p.age);
        }
    }
}
