using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenBench
{
    class Randomer
    {
        public static void RNGRandom()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] data = new byte[4];

                for (int i = 0; i < 100; i++)
                {
                    rng.GetBytes(data);

                    int value = BitConverter.ToInt32(data, 0);
                    Console.Write(value + " ");
                }
                stopwatch.Stop();
                Console.WriteLine();
                Console.WriteLine("Time Spent:" + stopwatch.ElapsedMilliseconds);
                Console.WriteLine();
            }


        }

        public static void SysRandom()
        {
            Stopwatch stopwatch = new Stopwatch();
            Random random = new Random();
            stopwatch.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(random.Next(100000) + " ");
            }
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Time Spent:" + stopwatch.ElapsedMilliseconds);
            Console.WriteLine();
        }
    }
}
