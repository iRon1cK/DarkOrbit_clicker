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
        String dbPath = "data.dodb";

        Dictionary<string, object> listMap = new Dictionary<string, object>();

        List<DarkOrbit_clicker.Spaceship> spaceshipList = new List<DarkOrbit_clicker.Spaceship>();
        List<DarkOrbit_clicker.Drone> droneList = new List<DarkOrbit_clicker.Drone>();
        List<DarkOrbit_clicker.Booster> boosterList = new List<DarkOrbit_clicker.Booster>();
        List<DarkOrbit_clicker.Pet> petList = new List<DarkOrbit_clicker.Pet>();
        List<DarkOrbit_clicker.Protocol> protocolList = new List<DarkOrbit_clicker.Protocol>();
        List<DarkOrbit_clicker.Ammo> ammoList = new List<DarkOrbit_clicker.Ammo>();
        List<DarkOrbit_clicker.Design> designList = new List<DarkOrbit_clicker.Design>();
        List<DarkOrbit_clicker.Laser> laserList = new List<DarkOrbit_clicker.Laser>();
        List<DarkOrbit_clicker.Shield> shieldList = new List<DarkOrbit_clicker.Shield>();

        public MainForm()
        {
            listMap.Add("Spaceships", spaceshipList);
            listMap.Add("Drones", droneList);
            listMap.Add("Boosters", boosterList);
            listMap.Add("Pets", petList);
            listMap.Add("Protocols", protocolList);
            listMap.Add("Ammos", ammoList);
            listMap.Add("Designs", designList);
            listMap.Add("Lasers", laserList);
            listMap.Add("Shields", shieldList);

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (KeyValuePair<String, object> pair in listMap)
            {

            }
            List<object> result = new List<object>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(dbPath))
            {
                FileStream fsin = new FileStream(dbPath, FileMode.Open, FileAccess.Read, FileShare.None);
                try
                {
                    using (fsin)
                    {
                        result = (List<object>)bf.Deserialize(fsin);
                    }
                    foreach (object o in result)
                    {
                        if (o is DarkOrbit_clicker.Spaceship)
                            spaceshipList.Add((DarkOrbit_clicker.Spaceship)o);
                        else if (o is DarkOrbit_clicker.Drone)
                            droneList.Add((DarkOrbit_clicker.Drone)o);
                        else if (o is DarkOrbit_clicker.Booster)
                            boosterList.Add((DarkOrbit_clicker.Booster)o);
                        else if (o is DarkOrbit_clicker.Pet)
                            petList.Add((DarkOrbit_clicker.Pet)o);
                        else if (o is DarkOrbit_clicker.Protocol)
                            protocolList.Add((DarkOrbit_clicker.Protocol)o);
                        else if (o is DarkOrbit_clicker.Ammo)
                            ammoList.Add((DarkOrbit_clicker.Ammo)o);
                        else if (o is DarkOrbit_clicker.Design)
                            designList.Add((DarkOrbit_clicker.Design)o);
                        else if (o is DarkOrbit_clicker.Laser)
                            laserList.Add((DarkOrbit_clicker.Laser)o);
                        else if (o is DarkOrbit_clicker.Shield)
                            shieldList.Add((DarkOrbit_clicker.Shield)o);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured" + e.Message);
                }
            }
            foreach (KeyValuePair<String, object> pair in listMap)
            {

            }
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

            BinaryFormatter bf = new BinaryFormatter();

            FileStream fsout = new FileStream(dbPath, FileMode.Create, FileAccess.Write, FileShare.None);
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
        }

        private void btnSelectDb_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select DB file";
            fileDialog.Filter = "DarkOrbit Database (*.dodb)|*.dodb";
            fileDialog.CheckPathExists = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dbPath = fileDialog.FileName;
                txbDbPath.Text = dbPath;
                LoadData();
            }
        }
    }
}
