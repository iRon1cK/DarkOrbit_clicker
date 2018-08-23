using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class User // Основные параметры пользователя.
    {
        public string name;
        public long kredits;
        public long uridium;
        public long expirience;
        public long honor;
        public int level;
        public int password;
        public Corp corporation;
        public Spaceship currentSpaceship;
        public List<Spaceship> spaceships = new List<Spaceship>();

        public enum Corp
        {
            Venus,
            Mars,
            Earth
        }

        public User()
        {

        }

        public User(string name)
        {
            this.name = name;
            //switch (corp)
            //{
            //    case Corp.Earth:
            //        break;

            //    case Corp.Mars:
            //        break;

            //    case Corp.Venus:
            //        break;
            //}
        }
    }
}
