using DarkOrbit_clicker.entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class SpaceshipEntity : ShopItem
    {
        public int hp;
        public List<LaserEntity> lasers = new List<LaserEntity>();
        public List<ShieldEntity> shields = new List<ShieldEntity>();
        public int shieldsMax;
        public int lasersMax;
    }
}