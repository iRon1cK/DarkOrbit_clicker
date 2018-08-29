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
        public long kredits = 1000;
        public long uridium = 0;
        public long expirience = 0;
        public long honor = 0;
        public int level = 1;
        public string password;
        public Corp corporation;
        public Spaceship currentSpaceship;
        public List<Spaceship> spaceships = new List<Spaceship>();

        public enum Corp
        {
            Earth,
            Venus,
            Mars,
        }

        public User()
        {
          
        }
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;

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
