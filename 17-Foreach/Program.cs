using System;

namespace _17_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Maria", "Bob", "Alex" };

            foreach (string item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
