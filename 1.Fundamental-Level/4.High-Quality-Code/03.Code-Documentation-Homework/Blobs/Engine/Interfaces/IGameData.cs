namespace Blobs.Engine.Interfaces
{
    using System.Collections.Generic;
    using Models.Interfaces;

    /// <summary>
    /// Interface for the game data. 
    /// </summary>
    public interface IGameData
    {
        /// <summary>
        /// Collection for holding all blobs in current game.
        /// </summary>
        IEnumerable<IBlob> Blobs { get; }

        /// <summary>
        /// Adds a created blob to IEnumerable collection
        /// </summary>
        /// <param name="blob">Blob object</param>
        void CreateBlob(IBlob blob);
    }
}
