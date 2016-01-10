namespace Blobs.Engine.Factories
{
    using System;
    using Interfaces;
    using Models;
    using Models.Enums;
    using Models.Interfaces;

    public class BlobFactory : IBlobFactory
    {
        public IBlob CreateBlob(
            string name,
            int health,
            int damage,
            BehaviourType behaviourType,
            AttackType attackType)
        {
            if (behaviourType == BehaviourType.Aggressive && attackType == AttackType.PutridFart)
            {
                IBlob blob = new AggressivePutridFart(name, health, damage);

                return blob;
            }
            else if (behaviourType == BehaviourType.Aggressive && attackType == AttackType.Blobplode)
            {
                IBlob blob = new AggressiveBlobplode(name, health, damage);

                return blob;
            }
            else if (behaviourType == BehaviourType.Inflated && attackType == AttackType.PutridFart)
            {
                IBlob blob = new InflatedPutridFart(name, health, damage);

                return blob;
            }
            else if (behaviourType == BehaviourType.Inflated && attackType == AttackType.Blobplode)
            {
                IBlob blob = new InflatedBlobplode(name, health, damage);

                return blob;
            }
            else
            {
                throw new ArgumentException("Unknown blob type");
            }
        }
    }
}
