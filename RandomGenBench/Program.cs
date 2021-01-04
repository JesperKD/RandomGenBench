using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenBench
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tilfældig tal generering:");
            Console.WriteLine();
            Randomer.RNGRandom();
            Randomer.SysRandom();

            Console.ReadKey();
        }
    }
}
