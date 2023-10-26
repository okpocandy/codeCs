using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeS.Cs_200.Day1
{
    internal class _11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:#.##}", 1234.5678);
            Console.WriteLine("{0:#.###}", 1234.5678);
            Console.WriteLine("{0:##.##}", 1234.5678);
            Console.WriteLine("{0:0.00}", 1234.5678);
            Console.WriteLine("{0:000.000}", 1234.5678);
            Console.WriteLine("{0:#,#.##}", 1234.5678);
            Console.WriteLine("{0:0,#.##}", 1234.5678);
            Console.WriteLine("{0:0,0.#00}", 1234.5678);
            Console.WriteLine("{0:#,0.00}", 1234.5678);
            
        }
    }
}
