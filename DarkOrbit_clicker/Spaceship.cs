using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class Spaceship
    {
        public string name;
        public int hp;
        public List<Laser> lasers = new List<Laser>();
        public List<Shield> shields = new List<Shield>();
        public int shieldsMax;
        public int lasersMax;
        public int price;
        public Shop.Currency currency;
        public Image image;
    }
}