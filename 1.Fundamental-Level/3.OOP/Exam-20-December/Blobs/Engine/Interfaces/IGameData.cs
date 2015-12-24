namespace Blobs.Engine.Interfaces
{
    using System.Collections.Generic;
    using Models.Interfaces;

    public interface IGameData
    {
        IEnumerable<IBlob> Blobs { get; }

        void CreateBlob(IBlob blob);
    }
}
