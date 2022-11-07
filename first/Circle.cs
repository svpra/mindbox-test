using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MindBoxLibrary;

namespace MindBoxLibrary
{
    public class Circle : Type
    {
        public double Radius { get; set; }

        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            if (Radius < 0) 
            {
                throw new ArgumentException("Ошибка: значение стороны не может быть отрицательным");
            }
            else 
            {
                this.Radius = Radius;
            }
        }

        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }  
}
