using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DarkOrbit_clicker.services
{
    class RegistryService
    {
        public enum Keys
        {
            isFullScreen
        }

        public String Read(Keys key)
        {
            string value;
            try
            {
                RegistryKey readKey = Registry.CurrentUser.OpenSubKey(Constants.SUBKEY);
                value = (string)readKey.GetValue(key.ToString());
                readKey.Close();
               
            }
            catch {
                Console.WriteLine("Current key doesn't exist");
                value = null;
            }
            return value;
        }

        public void Write(Keys key, String keyParameter)
        {
           
                RegistryKey saveKey = Registry.CurrentUser.CreateSubKey(Constants.SUBKEY);
                saveKey.SetValue(key.ToString(), keyParameter);
                saveKey.Close();
          
            
        }

        public void RemoveKey(Keys key)
        {
            RegistryKey removeKey = Registry.CurrentUser.OpenSubKey(Constants.SUBKEY);
            try
            {
                removeKey.DeleteSubKey(key.ToString());
            }
            catch
            {
                Console.WriteLine("Current key doesn't exist");
            }
        }

        public void RemoveValue(Keys key)
        {
            RegistryKey removeValue = Registry.CurrentUser.OpenSubKey(Constants.SUBKEY);
            try
            {
                removeValue.DeleteSubKey(key.ToString());
            }
            catch
            {
                Console.WriteLine("Current key doesn't exist");
            }

        }
    }
}
