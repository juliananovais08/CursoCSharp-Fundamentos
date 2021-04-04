using System;
using System.Globalization;

namespace _13_Arrays02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de posições do vetor:");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome posição " + i);
                string name = Console.ReadLine();

                Console.WriteLine("Preço posição " + i);
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };
                Console.WriteLine("Nome: " + name + " " + "Preço: " + price);
                Console.WriteLine();

            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
