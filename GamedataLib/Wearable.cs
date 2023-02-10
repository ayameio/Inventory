using System;

namespace InventoryLib
{
    [Serializable]
    public class Wearable : Item
    {
        public String Name { get; set; }
        public String Id { get; set; }
        public Stat[] Stats { get; set; }

        public Wearable(string id, string name, int amount, Stat[] stats) : base(id, name)
        {
            Name = name;
            Id = id;
            Stats = stats;
        }

        public bool Upgrade(int howMuch)
        {
            // TODO:
            // implement this on your own
            // upgrade if player has enough consumables (gold,gem,...)
            // otherwise return false
            foreach (var stat in Stats)
            {
                stat.Increase(howMuch);
            }
            return true;
        }
    }
}