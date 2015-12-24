namespace Blobs.Models.Interfaces
{
    using Enums;

    public interface IBlob : IGameObject
    {
        BehaviourType BehaviourType { get; }

        AttackType AttackType { get; }

        void RespondToChanges();

        void Attack(IBlob blob);

        void Update();
    }
}
