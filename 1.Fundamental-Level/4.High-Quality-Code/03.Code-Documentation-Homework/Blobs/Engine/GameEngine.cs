namespace Blobs.Engine
{
    using System;
    using System.Linq;
    using Interfaces;
    using IO.Interfaces;
    using Models.Enums;
    using Models.Interfaces;

    public class GameEngine : IRunnable
    {
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private readonly IGameData data;
        private readonly IBlobFactory blobFactory;

        public GameEngine(
            IInputReader reader,
            IOutputWriter writer,
            IGameData data,
            IBlobFactory blobFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.data = data;
            this.blobFactory = blobFactory;
        }

        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split(' ');

                string result = this.ExecuteCommand(input);

                if (result == "drop")
                {
                    break;
                }
            }
        }

        protected virtual string ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.ExecuteCreateCommand(inputParams);
                    break;
                case "attack":
                    this.ExecuteAttackCommand(inputParams);
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "pass":
                    this.ExecutePassCommand();
                    break;
                case "drop":
                    return "drop";
                default:
                    throw new ArgumentException("Unknown command.");
            }

            return null;
        }

        private void ExecutePassCommand()
        {
            foreach (var blob in this.data.Blobs)
            {
                blob.RespondToChanges();
            }
        }

        private void ExecuteAttackCommand(string[] inputParams)
        {
            string attackerName = inputParams[1];
            string deffenderName = inputParams[2];

            IBlob attacker = this.GetBlobByName(attackerName);
            IBlob deffender = this.GetBlobByName(deffenderName);

            if (attacker == null)
            {
                throw new ArgumentException("The attacker blob does not exist.");
            }

            if (deffender == null)
            {
                throw new ArgumentException("The defender blob does not exist.");
            }

            if (deffender.Health > 0 && attacker.Health > 0 && attackerName != deffenderName)
            {
                attacker.Attack(deffender);
            }
        }

        private IBlob GetBlobByName(string blobName)
        {
            IBlob blob = this.data.Blobs.FirstOrDefault(b => b.Name == blobName);

            return blob;
        }

        private void ExecuteStatusCommand()
        {
            foreach (var blob in this.data.Blobs)
            {
                this.writer.Print(blob.ToString());
                blob.RespondToChanges();
            }
        }

        private void ExecuteCreateCommand(string[] inputParams)
        {
            string blobName = inputParams[1];
            int bloblHealth = int.Parse(inputParams[2]);
            int blobDamage = int.Parse(inputParams[3]);
            BehaviourType behaviourType = (BehaviourType)Enum.Parse(typeof(BehaviourType), inputParams[4]);
            AttackType attackType = (AttackType)Enum.Parse(typeof(AttackType), inputParams[5]);

            var blob = this.blobFactory.CreateBlob(
                blobName,
                bloblHealth,
                blobDamage,
                behaviourType,
                attackType);

            this.data.CreateBlob(blob);
        }
    }
}
