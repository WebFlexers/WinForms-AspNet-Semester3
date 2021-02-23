using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Serializer
    {
        public static void SerializePlayers(List<Player> players)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("players.mem", FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, players);

            stream.Close();
        }

        public static List<Player> DeserializePlayers()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("players.mem", FileMode.OpenOrCreate, FileAccess.Read);

            List<Player> players;
            if (stream.Length != 0)
            {
                players = (List<Player>)formatter.Deserialize(stream);
            }
            else
            {
                players = new List<Player>();
            }

            stream.Close();
            return players;

        }
    }
}
