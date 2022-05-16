using System;

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
