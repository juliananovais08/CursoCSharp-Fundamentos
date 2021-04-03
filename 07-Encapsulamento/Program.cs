using System;

namespace _07_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Copo", 20.00, 80);

            Console.WriteLine(p.GetNome());

            p.SetNome("Garrafa");


        }
    }
}
