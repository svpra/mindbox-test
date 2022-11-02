using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MindBoxLibrary;

namespace MindBoxLibrary
{
    // создаём класс Circlе
    public class Circle : Type
    {
        public double Radius { get; set; }

        // Создаём круг
        public Circle(string FigureName, double Radius) : base(FigureName)
        {
            this.Radius = Radius;
        }

        // Считаем площадь
        public override double CalcSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
        }
    }  
}
