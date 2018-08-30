using DarkOrbit_clicker.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class DroneEntity : ShopItem
    {
        public int type; // Iris or Flax. Stas: MUST BE ENUM
        public int droneBonus;
        public int droneLevel = 1;
        public int droneSlots;
        public long droneExp = 0;


    }
    public enum DroneType
    {
        Iris,
        Flax,
    }
}
