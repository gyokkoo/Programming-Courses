namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Holds a method for drawing.
    /// </summary>
    public interface IDrawer
    {
        /// <summary>
        /// Draws a points on x and y coordinates with given symbol
        /// </summary>
        /// <param name="x">The x coordinate</param>
        /// <param name="y">The y coordinate</param>
        /// <param name="symbol">The symbol to draw</param>
        void DrawPoint(int x, int y, char symbol);
    }
}