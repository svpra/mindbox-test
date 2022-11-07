using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindBoxLibrary
{
    public abstract class Type
    {
        public string FigureName { get; set; }

        public Type(string FigureName)

        public abstract double CalcSquare();
    }

    public static class Prototype
    {
        public static double CalcSquare(Type type) => type.CalcSquare();    
    } 
}
