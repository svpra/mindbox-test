/* Так как комментарии улучшают читаемость кода, а также это good practice, 
всё в коде будет тчательно закомментировано :) */

using System;
using System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    // Создаём класс Triangle
    public class Triangle : Type
    {
        // Инициализируем стороны
        public double ab { get; set; }
        public double bc { get; set; }
        public double ac { get; set; }

        // Создаём треугольник (и проверяем: является ли треугольником то, что пытается создать пользователь)
        public Triangle(string FigureName, double ab, double bc, double ac) : base(FigureName)
        {
            if (ab < 0 or bc < 0 or ac < 0) throw new ArgumentException("Ошибка: значение стороны не может быть отрицательным");
            else if (ab > (bc + ac) or bc > (ab + ac) or ac > (ab + bc)) throw new ArgumentException("Ошибка: Ваша сторона больше суммы двух других");
            else
            {
                this.ab = ab;
                this.bc = bc;
                this.ac = ac;
            }
        }

        // Создаём метод CalcSquare, который будет считать площадь
        public override double CalcSquare()
        {
            // Считаем площадь по формуле сумма сторон 
            double p = (ab + bc + ac) / 2;
            double result = Math.Round(Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac)), 1);
            return result;
        }

        // Проверяем: является ли треугольник прямоугольным
        public bool IsRectangular()
        {
            bool check = (ab == Math.Sqrt(Math.Pow(bc, 2) + Math.Pow(ac, 2))
                         or bc == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(ac, 2))
                         or ac == Math.Sqrt(Math.Pow(ab, 2) + Math.Pow(bc, 2)));
            return check;
        }
    }

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
