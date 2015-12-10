using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Healer : AdvancedCharacter, IHeal
    {
        private const int HealingPointsDefault = 60;
        private const int DefensePointsDefault = 50;
        private const int HealthPointsDefault = 75;
        private const int RangeDefault = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealthPointsDefault, DefensePointsDefault, team, RangeDefault)
        {
            this.HealingPoints = HealingPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList
                .Where(c => c.Id != this.Id)
                .Where(c => c.Team == this.Team)
                .Where(c => c.IsAlive)
                .OrderBy(c => c.HealthPoints)
                .FirstOrDefault();
        }

        public int HealingPoints { get; set; }


        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
