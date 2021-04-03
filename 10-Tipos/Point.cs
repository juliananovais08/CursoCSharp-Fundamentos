using System;
using System.Collections.Generic;
using System.Text;

namespace _10_Tipos
{
    struct Point
    {
        public double X, Y;
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
