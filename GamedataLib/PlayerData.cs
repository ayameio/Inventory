using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace InventoryLib
{
    [Serializable]
    public class PlayerData : ISerializable
    {
        public Inventory Inventory { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            Inventory = (Inventory)info.GetValue("Inventory", typeof(Inventory));
        }
    }
}