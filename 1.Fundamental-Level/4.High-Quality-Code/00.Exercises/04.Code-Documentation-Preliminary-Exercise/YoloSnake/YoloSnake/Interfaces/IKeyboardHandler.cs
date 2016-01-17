namespace YoloSnake.Interfaces
{
    using System;

    /// <summary>
    /// Holds properties for handling on the keyboard
    /// </summary>
    public interface IKeyboardHandler
    {
        /// <summary>
        /// Holds an pressed key data
        /// </summary>
        ConsoleKey PressedKey { get; }

        /// <summary>
        /// Checks if a key is avaliable
        /// </summary>
        bool IsKeyAvailable { get; }
    }
}