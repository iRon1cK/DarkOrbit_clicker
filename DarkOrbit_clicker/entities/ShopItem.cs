using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Image image;
        public List<Image> previewAnimationImages = new List<Image>();
        public string description;

        public enum Currency
        {
            Uridium,
            Kredits
        }

        public override string ToString()
        {
            return name;
        }
    }
}
