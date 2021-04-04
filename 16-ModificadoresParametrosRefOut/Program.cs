using System;

namespace _16_ModificadoresParametrosRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            //out
            int b = 10;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
