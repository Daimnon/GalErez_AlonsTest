using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alons_CloverByte_Test
{
    public static class StaticClassExample
    {
        public static int Num = 5;
        public static string String = $"Num is {Num}";

        public static void YouCanReadMe()
        {
            Console.WriteLine("You're reading me from StaticClassExample class");
        }
    }
}
