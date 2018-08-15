using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    public class Spaceship
    {
        public string name = "Phoenix";
        public int hp = 100;
        public List<Laser> lasers = new List<Laser>() { new Laser() };
        public List<Shield> shields = new List<Shield>() { new Shield() };
        public int shieldsMax = 100;
        public int lasersMax = 100;
        public int price = 100;
        public Shop.Currency currency = Shop.Currency.Kredits;
        public Image image = Properties.Resources.phoenix_100x100;
    }
}
