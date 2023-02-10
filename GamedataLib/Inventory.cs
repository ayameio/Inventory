using System;
using System.Collections.Generic;

namespace InventoryLib
{
    [Serializable]
    public class Inventory
    {
        public List<Wearable> Wearables;
        public List<Consumable> Consumables;

        public Inventory()
        {
            Wearables = new List<Wearable>();
            Consumables = new List<Consumable>();
        }
    }
}