using System;
using System.Globalization;

namespace _12_Arrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de posições do vetor:");
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Entre com o valor da posição " + i);
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
