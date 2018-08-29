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
        public int bonus;
        public int skill;
        public int petLaserSlots;
        public int petProtocolSlots;
    }
}
