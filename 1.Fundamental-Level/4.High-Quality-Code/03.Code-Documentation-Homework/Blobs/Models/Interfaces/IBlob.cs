namespace Blobs.Models.Interfaces
{
    using Enums;

    /// <summary>
    /// Properties and methods that the blob has.
    /// </summary>
    public interface IBlob : IGameObject
    {
        /// <summary>
        ///  Holds enum behaviour type property
        /// </summary>
        BehaviourType BehaviourType { get; }

        /// <summary>
        /// Holds enum attack type property
        /// </summary>
        AttackType AttackType { get; }

        /// <summary>
        /// A blob respond to health or damage changes
        /// Should activated behaviour e.g.
        /// </summary>
        void RespondToChanges();

        /// <summary>
        /// A blob attacks another given blob 
        /// </summary>
        /// <param name="blob">Defender blob</param>
        void Attack(IBlob blob);

        /// <summary>
        /// A blob updates his health or damage if the behaviour is activated
        /// </summary>
        void Update();
    }
}
