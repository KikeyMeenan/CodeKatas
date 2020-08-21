using System;
using System.Collections.Generic;

namespace _02_KarateChop_NetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result is: " + new BasicChop().Chop(1, new int[] { 1, 2, 3 }));
        }
    }
}
