namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Signature of a method.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// The object can be drawn by a given IDrawer.
        /// </summary>
        /// <param name="drawer"></param>
        void Draw(IDrawer drawer);
    }
}