namespace Blobs.Engine.Interfaces
{
    using Models.Enums;
    using Models.Interfaces;

    public interface IBlobFactory
    {
        IBlob CreateBlob(string name, int health, int damage, BehaviourType behaviourType, AttackType attackType);
    }
}
