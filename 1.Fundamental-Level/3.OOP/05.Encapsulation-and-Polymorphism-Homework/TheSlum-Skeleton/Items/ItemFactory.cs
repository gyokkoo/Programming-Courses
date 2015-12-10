using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Items
{
    public static class ItemFactory
    {
        public static Item Create(string itemType, string id)
        {
            switch (itemType.ToLower())
            {
                case "axe":
                    return new Axe(id);
                case "pill":
                    return new Pill(id);
                case "injection":
                    return new Injection(id);
                case "shield":
                    return new Shield(id);
                default:
                    throw new ArgumentException("Invalid item type supplied");
            }
        }
    }
}
