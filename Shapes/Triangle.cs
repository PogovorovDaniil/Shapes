using System;

namespace Shapes
{
    /// <summary>
    /// Представляет класс, описывающий треугольник.
    /// </summary>
    public class Triangle : IShape
    {
        private readonly double a, b, c;

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle с указанными сторонами.
        /// </summary>
        /// <param name="a">Длина первой стороны треугольника.</param>
        /// <param name="b">Длина второй стороны треугольника.</param>
        /// <param name="c">Длина третьей стороны треугольника.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если указанные стороны не могут образовать треугольник.</exception>
        public Triangle(double a, double b, double c)
        {
            if (a >= b + c || b >= c + a || c >= a + b)
            {
                throw new ArgumentException("Указанные стороны не могут образовать треугольник.");
            }
            (this.a, this.b, this.c) = (a, b, c);
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns>True, если треугольник прямоугольный, иначе - False.</returns>
        public bool IsRectangular()
        {
            (double sa, double sb, double sc) = (a * a, b * b, c * c);
            return sa == sb + sc || sb == sc + sa || sc == sa + sb;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double GetSquare()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
