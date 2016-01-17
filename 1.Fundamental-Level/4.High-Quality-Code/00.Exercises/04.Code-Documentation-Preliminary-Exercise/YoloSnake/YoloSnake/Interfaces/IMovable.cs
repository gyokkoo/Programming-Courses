namespace YoloSnake.Interfaces
{
    using Enums;

    public interface IMovable
    {
        Direction Direction { get; }

        void Move();

        void ChangeDirection(Direction newDirection);
    }
}