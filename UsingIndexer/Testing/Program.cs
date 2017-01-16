using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingIndexer;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            SolarSystem ss = new SolarSystem("SolarSystem", 9);
           
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"The {i + 1}st planet of SolarSystem is {ss.planetsName[i]}");
            }
            Console.Read();
        }
    }
}
