using kaffe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKaffeApp
{
    class Program
    {
        static void Main()
        {
            FaltWhite FW1 = new FaltWhite();
            Console.WriteLine($"add {FW1.MlMælk()} Ml. Mælk. prisen er {FW1.Pris()}kr. Stykken er {FW1.Styrke()}");
            Console.ReadLine();
        }
    }
}
