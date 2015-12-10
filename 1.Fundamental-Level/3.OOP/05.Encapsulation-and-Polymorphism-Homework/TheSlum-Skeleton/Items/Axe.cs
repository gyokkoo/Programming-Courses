using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Axe : Item
    {
        private const int HealthEffectDefault = 0;
        private const int DefenceEffectDefault = 0;
        private const int AttackEffectDefault = 75;

        public Axe(string id) 
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
        }
    }
}
