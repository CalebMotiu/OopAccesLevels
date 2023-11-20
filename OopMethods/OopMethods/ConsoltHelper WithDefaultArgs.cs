using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopMethods
{
    internal static class ConsoltHelper_WithDefaultArgs
    {

        public static void Print(string label, string message = "", int count = 1)
        {
            if (!string.IsNullOrEmpty(label))
            {
                Console.WriteLine($"{label}:  ");
            }



            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
