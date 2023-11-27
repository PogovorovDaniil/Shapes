using System;

namespace Shapes
{
    /// <summary>
    /// Представляет класс, описывающий круг.
    /// </summary>
    public class Circle : IShape
    {
        private readonly double radius;

        /// <summary>
        /// Инициализирует новый экземпляр класса Circle с указанным радиусом.
        /// </summary>
        /// <param name="radius">Радиус круга. Должен быть больше нуля.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если радиус меньше или равен нулю.</exception>
        public Circle(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля.", nameof(radius));
            }
            this.radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double GetSquare() => Math.PI * radius * radius;
    }
}
