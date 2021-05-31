using _35_MetodoAbstrato.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _35_MetodoAbstrato
{    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
