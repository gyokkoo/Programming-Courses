using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public class Shield : Item
    {
        private const int HealthEffectDefault = 0;
        private const int DefenceEffectDefault = 50;
        private const int AttackEffectDefault = 0;

        public Shield(string id) 
            : base(id, HealthEffectDefault, DefenceEffectDefault, AttackEffectDefault)
        {
        }
    }
}
