using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class Laser
    {
        public string name;
        public int damage;
        public int price;
        public int reloadTime;
        public Shop_form.Currency currency;
    }
}
