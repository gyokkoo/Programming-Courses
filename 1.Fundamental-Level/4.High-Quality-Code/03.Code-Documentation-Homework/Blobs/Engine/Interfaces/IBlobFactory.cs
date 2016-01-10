namespace Blobs.Engine.Interfaces
{
    using Models.Enums;
    using Models.Interfaces;
    
    /// <summary>
    /// Holds a method for blob factory.
    /// </summary>
    public interface IBlobFactory
    {
        /// <summary>
        /// Creates a blob by given arguments.
        /// </summary>
        /// <param name="name">Blob name</param>
        /// <param name="health">Blob health</param>
        /// <param name="damage">Blob damage</param>
        /// <param name="behaviourType">Blob behaviour type</param>
        /// <param name="attackType">Blobl attack type</param>
        /// <returns>IBlob object</returns>
        IBlob CreateBlob(string name, int health, int damage, BehaviourType behaviourType, AttackType attackType);
    }
}