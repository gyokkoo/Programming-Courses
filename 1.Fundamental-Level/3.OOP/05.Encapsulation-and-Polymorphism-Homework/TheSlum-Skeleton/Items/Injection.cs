using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int HealthEffectDefault = 200;
        private const int DefenceEffectDefault = 0;
        private const int AttackEffectDefault = 0;
        private const int TimeoutTurns = 3;

        public Injection(string id) 
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
            this.Timeout = TimeoutTurns;
            this.Countdown = TimeoutTurns;
        }
    }
}
