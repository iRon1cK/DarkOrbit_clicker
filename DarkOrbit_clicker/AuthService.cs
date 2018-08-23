using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkOrbit_clicker
{
    class AuthService
    {
        public static User currentUser; 
        private static List<User> userList = new List<User>();

        public static bool LogIn(string login, int password)
        {
            //
            return false;
        }

        public static bool Register(string login, int password)
        {
            //
            return false;
        }
        
        public static void SaveGame()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsout = new FileStream(Constants.SAVEFILE_PATH, FileMode.Create, FileAccess.Write, FileShare.None);
                using (fsout)
                {
                    bf.Serialize(fsout, userList);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured while saving game: " + e.Message, "Error");
            }
        }

        public static void LoadSaves()
        {
            BinaryFormatter bf = new BinaryFormatter();
            List<object> result = new List<object>();
            if (File.Exists(Constants.SAVEFILE_PATH))
            {
                FileStream fsin = new FileStream(Constants.SAVEFILE_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsin)
                    {
                        result = (List<object>)bf.Deserialize(fsin);
                    }
                    foreach (object obj in result)
                    {
                        foreach (object o in (List<object>)obj)
                        {
                            if (o is User)
                            {
                                userList.Add((User)o);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured while loading game saves: " + e.Message, "Error");
                }
            }
        }
    }
}
