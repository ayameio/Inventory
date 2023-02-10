using System;

namespace InventoryLib
{
    [Serializable]
    public struct Stat
    {
        public String Name;
        public int Number;

        public void Increase(int howMuch)
        {
            Number += howMuch;
        }
    }
}