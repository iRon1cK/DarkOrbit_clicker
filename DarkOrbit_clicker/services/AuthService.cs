﻿using System;
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
        public static UserEntity currentUser;
        public static List<UserEntity> userList = new List<UserEntity>();

        //-проверка, есть ли в списке юзеров юзер с такими логином и паролем
        //-если есть, присваивать его переменной currentUser
        //-если нет, возвращать false
        public static bool LogIn(string login, string password)
        {
            string hash = CalculateHash(login, password);
            //обычный вариант
            //foreach (User user in userList)
            //{
            //    if (user.name == login && user.password == hash)
            //    {
            //        currentUser = user;
            //        return true;
            //    }
            //}

            //лямбда
            UserEntity foundUser = userList.Find(user => (user.name == login && user.password == hash));
            if (foundUser != null)
            {
                currentUser = foundUser;
                return true;
            }
            MessageBox.Show("Login or password is incorrect", "Error");
            return false;
        }

        public static bool Register(string login, string password)
        {
            if (userList.Find(user => user.name == login) == null)
            {
                CalculateHash(login, password);
                UserEntity user = new UserEntity(login, CalculateHash(login, password));
                userList.Add(user);
                currentUser = user;
                SaveGame();
                return true;
            }
            {
                MessageBox.Show("User with this name already exists", "Error");
            }
            return false;
        }

        private static string CalculateHash (string login, string password)
        {
            return HasherService.hashSha256( login + password);
        }

        public static void SaveGame()
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fsout = new FileStream(Constants.SAVEFILE_PATH, FileMode.Create, FileAccess.Write, FileShare.None);
                using (fsout)
                {
                    bf.Serialize(fsout, new List<object>() { userList });
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
                        foreach (object o in (IEnumerable<object>)obj)
                        {
                            if (o is UserEntity)
                            {
                                userList.Add((UserEntity)o);
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
