using System;
using System.Collections.Generic;
using System.Text;

namespace _46_Delegates.Services
{
    class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Square(double x) //Não vai funcionar pq recebe só 1 parâmetro
        {
            return x * x;
        }
    }
}
