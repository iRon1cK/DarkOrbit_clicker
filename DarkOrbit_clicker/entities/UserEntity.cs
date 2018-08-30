﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    [Serializable]
    public class UserEntity // Основные параметры пользователя.
    {
        public string name;
        public long kredits = 1000;
        public long uridium = 0;
        public long expirience = 0;
        public long honor = 0;
        public int level = 1;
        public string password;
        public Corp corporation = Corp.NotSelected;
        public SpaceshipEntity currentSpaceship;
        public List<SpaceshipEntity> spaceships = new List<SpaceshipEntity>();
        
        public enum Corp
        {
            NotSelected,
            Venus,
            Mars,
            Earth
        }

        public UserEntity()
        {
          
        }

        public UserEntity(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
