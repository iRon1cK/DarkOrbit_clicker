using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            List<object> result = new List<object>();
            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsin = new FileStream("data.dodb", FileMode.Open, FileAccess.Read, FileShare.None);
            try
            {
                using (fsin)
                {
                    result = (List<object>)bf.Deserialize(fsin);
                }
                foreach (object o in result)
                {
                    if (o is User)
                        currentUser = (User)o;
                    else if (o is Spaceship)
                        spaceshipList.Add((Spaceship)o);
                    else if (o is Drone)
                        droneList.Add((Drone)o);
                    else if (o is Booster)
                        boosterList.Add((Booster)o);
                    else if (o is Pet)
                        petList.Add((Pet)o);
                    else if (o is Protocol)
                        protocolList.Add((Protocol)o);
                    else if (o is Ammo)
                        ammoList.Add((Ammo)o);
                    else if (o is Design)
                        designList.Add((Design)o);
                    else if (o is Laser)
                        laserList.Add((Laser)o);
                    else if (o is Shield)
                        shieldList.Add((Shield)o);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured" + e.Message);
            }
            MessageBox.Show("Done!");
        }

        public void SaveData()
        {
            List<object> toSave = new List<object>();
            toSave.AddRange(spaceshipList);
            toSave.AddRange(droneList);
            toSave.AddRange(boosterList);
            toSave.AddRange(petList);
            toSave.AddRange(protocolList);
            toSave.AddRange(ammoList);
            toSave.AddRange(designList);
            toSave.AddRange(laserList);
            toSave.AddRange(shieldList);
            toSave.Add(currentUser);

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream("data.dodb", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {
                using (fsout)
                {
                    bf.Serialize(fsout, toSave);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has occured: " + e.Message);
            }
            MessageBox.Show("Done!");
        }
    }
}
