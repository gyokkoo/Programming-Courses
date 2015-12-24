namespace Blobs.Models.Interfaces
{
    public interface IGameObject : IAttack, IHealth
    {
        string Name { get; set; }
    }
}
