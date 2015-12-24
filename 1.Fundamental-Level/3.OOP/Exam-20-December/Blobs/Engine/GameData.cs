namespace Blobs.Engine
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    using Models.Interfaces;

    public class GameData : IGameData
    {
        private readonly ICollection<IBlob> blobs;

        public GameData()
        {
            this.blobs = new List<IBlob>();
        }

        public IEnumerable<IBlob> Blobs => this.blobs;

        public void CreateBlob(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }

            this.blobs.Add(blob);
        }
    }
}
