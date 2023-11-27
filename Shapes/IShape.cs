namespace Shapes
{
    /// <summary>
    /// Интерфейс, представляющий фигуру.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Получает площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        double GetSquare();
    }
}