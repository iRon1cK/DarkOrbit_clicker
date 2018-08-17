using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class Shield
    {
        public string name;
        public int capacity;
        public int price;
        public Shop.Currency currency;
    }
}
