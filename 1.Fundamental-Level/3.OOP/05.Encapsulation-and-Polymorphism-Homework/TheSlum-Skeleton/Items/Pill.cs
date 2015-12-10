using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int HealthEffectDefault = 0;
        private const int DefenceEffectDefault = 0;
        private const int AttackEffectDefault = 100;
        private const int TimeoutTurns = 1;

        public Pill(string id) 
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeoutTurns;
            this.Countdown = TimeoutTurns;
        }
    }
}
