using DarkOrbit_clicker.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class LaserEntity : ShopItem
    {
        public int damage;
        public int reloadTime;
    }
}
