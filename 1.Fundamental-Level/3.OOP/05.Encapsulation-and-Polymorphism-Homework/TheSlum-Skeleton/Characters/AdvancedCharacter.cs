using System;
using System.Collections.Generic;
namespace TheSlum.Characters
{
    public abstract class AdvancedCharacter : Character
    {
        protected AdvancedCharacter(string id, int x, int y, int healthPoints, int defensePoints, Team team, int range) 
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
        }

        public override void AddToInventory(Item item)
        {
            this.ApplyItemEffects(item);
            this.Inventory.Add(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.RemoveItemEffects(item);
            this.Inventory.Remove(item);
        }
    }
}
