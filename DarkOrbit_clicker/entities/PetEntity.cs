using DarkOrbit_clicker.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class PetEntity : ShopItem
    {
        public string petName;
        public int petBonus;
        public int petSkill;
        public int petHealth = 1000;
        public int petLaserSlots = 1;
        public int petShieldSlots = 1;
        public int petProtocolSlots = 1;
        public int petLevel = 1;
        public int petFuel = 100;
        public long petExp = 0;
    }
}
