using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkOrbit_clicker
{
    class Constants
    {
        //=============PATHS=============
        public const string DATABASE_PATH = "data.dodb";
        public const string SAVEFILE_PATH = "users.dosv";

        //=============Registration Form restrictions=============
        public const int MAX_LOGIN_LENGTH = 10;
        public const int MIN_LOGIN_LENGTH = 3;
        public const int MAX_PASSWORD_LENGTH = 32;
        public const int MIN_PASSWORD_LENGTH = 6;
    }
}
