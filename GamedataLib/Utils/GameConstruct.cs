using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace InventoryLib.Utils
{
    public class GameConstruct
    {
        public PlayerData PlayerData { get; set; }

        public PlayerData LoadPlayerData()
        {
            Stream s = File.Open("PlayerData.obj", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();

            PlayerData data = (PlayerData)b.Deserialize(s);
            s.Close();

            return data;
        }

        public void SavePlayerData(PlayerData playerData)
        {
            Stream s = File.Open("PlayerData.obj", FileMode.Create);
            BinaryFormatter f = new BinaryFormatter();

            f.Serialize(s, playerData);
            s.Close();
        }
    }
}