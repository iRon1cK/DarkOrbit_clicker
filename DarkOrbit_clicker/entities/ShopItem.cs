using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker.entities
{
    [Serializable]
    public class ShopItem
    {
        public string name;
        public long price;
        public Currency currency;

        public enum Currency
        {
            Uridium,
            Kredits
        }
    }
}
