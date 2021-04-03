using System;

namespace _09_AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Copo", 20.00, 80);

            p.Nome = "Garrafa";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
