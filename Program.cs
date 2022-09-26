using System;
namespace ZmienneStaleTypyDanych
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAŁKOWITE
            var z1 = 1;
            var z2 = "Hello";
            int z3 = int.MaxValue;
            byte z4 = byte.MaxValue;
            short z5 = short.MaxValue;
            ushort z9 = ushort.MaxValue;
            long z6 = long.MaxValue;
            sbyte z7 = sbyte.MaxValue;
            sbyte z8 = sbyte.MinValue;
            Console.WriteLine("___________________________________");
            Console.WriteLine("CAŁKOWITE");
            Console.WriteLine();
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine(z3 + " - int MaxValue");
            Console.WriteLine(z4 + " - byte MaxValue");
            Console.WriteLine(z5 + " - short MaxValue");
            Console.WriteLine(z9 + " - ushort MaxValue");
            Console.WriteLine(z6 + " - long MaxValue");
            Console.WriteLine(z7 + " - sbyte MaxValue");
            Console.WriteLine(z8 + " - sbyte MinValue");
            //ZMIENNOPRZECINKOWE
            float z10 = 1.151515f;
            double z11 = 1.432343;
            decimal z12 = 3.23412m;
            Console.WriteLine("___________________________________");
            Console.WriteLine("ZMIENNOPRZECINKOWE");
            Console.WriteLine();
            Console.WriteLine(z10 + " - float");
            Console.WriteLine(z11 + " - double");
            Console.WriteLine(z12 + " - decimal");
            Console.WriteLine("___________________________________");
            Console.WriteLine("TEKSTOWE");
            Console.WriteLine();
            string z13 = "Hello World";
            char z14 = 'f';
            bool z15 = 5<2;
            bool z16 = 5 > 2 && 5 < 3;
            Console.WriteLine(z2 + " - var");
            Console.WriteLine(z13 + " - string");
            Console.WriteLine(z14 + " - char");
            Console.WriteLine(z15 + " - 5<2? bool");
            Console.WriteLine(z16 + " - 5>2 && 5<3 bool");
            Console.ReadKey();
        }
    }
}
