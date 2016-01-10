namespace Blobs.Models.Interfaces
{
    public interface IGameObject : IAttack, IHealth
    {
        /// <summary>
        /// Holds name property
        /// </summary>
        string Name { get; set; }
    }
}