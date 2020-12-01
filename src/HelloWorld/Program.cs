using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitRequested = false;
            while (!exitRequested)
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine("Press ESC for exit...");
                exitRequested = Console.ReadKey(true).Key == ConsoleKey.Escape;
            }
        }
    }
}
