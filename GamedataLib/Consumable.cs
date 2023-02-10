using System;

namespace InventoryLib
{
    [Serializable]
    public class Consumable : Item
    {
        public int Amount { get; set; }
        public String Name { get; set; }
        public String Id { get; set; }

        public Consumable(string id, string name, int amount) : base(id, name)
        {
            Amount = amount;
            Name = name;
            Id = id;
        }

        public void Consume()
        {
            Amount--;
        }

        public void AddAmount()
        {
            Amount++;
        }
    }
}