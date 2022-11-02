/* Так как комментарии улучшают читаемость кода, а также это good practice, 
всё в коде будет тщательно закомментировано :) */

using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindBoxLibrary
{
    // создаём абстрактный класс, который будет определять тип фигуры
    public abstract class Type
    {
        public string FigureName { get; set; }

        public Type(string FigureName)

        // CalcSquare - абстрактный метод, который мы переопределим позже, 
        // так как для классов Circle и Triangle будут разные реализации этого метода
        public abstract double CalcSquare();
    }

    // Основной класс
    public static class Prototype
    {
        public static double CalcSquare(Type type) => type.CalcSquare();    
    } 
}
