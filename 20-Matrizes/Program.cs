using System;

namespace _20_Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length); //quantidade de elementos
            Console.WriteLine(mat.Rank); //quantidade de linhas
            Console.WriteLine(mat.GetLength(0)); //a primeira dimensão tem tamanho 2
            Console.WriteLine(mat.GetLength(1)); //a segunda dimensão tem tamanho 3
        }
    }
}
