using _46_Delegates.Services;
using System;

namespace _46_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);

            //O delegate op é uma referência pra função soma
            // double result = op(a, b); Fazendo o op de a e b, o resultado é 22

            double result = op.Invoke(a, b);
            Console.WriteLine(result);
        }
    }
}
