using DarkOrbit_clicker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class MainForm : Form
    {
        String dbPath = "data.dodb";

        List<ListMap> listMap = new List<ListMap>();

        List<object> spaceshipList = new List<object>();
        List<object> droneList = new List<object>();
        List<object> boosterList = new List<object>();
        List<object> petList = new List<object>();
        List<object> protocolList = new List<object>();
        List<object> ammoList = new List<object>();
        List<object> designList = new List<object>();
        List<object> laserList = new List<object>();
        List<object> shieldList = new List<object>();

        public MainForm()
        {
            listMap.Add(new ListMap("Spaceships", spaceshipList, new DarkOrbit_clicker.Spaceship()));
            listMap.Add(new ListMap("Drones", droneList, new DarkOrbit_clicker.Drone()));
            listMap.Add(new ListMap("Boosters", boosterList, new DarkOrbit_clicker.Booster()));
            listMap.Add(new ListMap("Pets", petList, new DarkOrbit_clicker.Pet()));
            listMap.Add(new ListMap("Protocols", protocolList, new DarkOrbit_clicker.Protocol()));
            listMap.Add(new ListMap("Ammos", ammoList, new DarkOrbit_clicker.Ammo()));
            listMap.Add(new ListMap("Designs", designList, new DarkOrbit_clicker.Design()));
            listMap.Add(new ListMap("Lasers", laserList, new DarkOrbit_clicker.Laser()));
            listMap.Add(new ListMap("Shields", shieldList, new DarkOrbit_clicker.Shield()));

            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            foreach (ListMap lmap in listMap)
            {
                lmap.list.Clear();
            }
            shieldList.Add(new DarkOrbit_clicker.Shield());
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
                        if (o is Spaceship)
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
            }
            Random rnd = new Random();
            for (int sp = 0; sp < 10; sp++)  // Заполнение базы данных для кораблей тестовыми элементами.
            {
                Spaceship spaceship = new Spaceship();
                spaceship.name = "Index: " + sp;
                spaceship.price = rnd.Next(100, 10000);
                spaceshipList.Add(spaceship);
            }

            for (int sp = 0; sp < 10; sp++) // Заполнение базы данных для дизайнов корабля тестовыми элементами.
            {
                Design design = new Design();
                design.name = "Index: " + sp;
                design.price = rnd.Next(10000, 100000);
                designList.Add(design);
            }
            lbxListTypes.DataSource = listMap;
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

        private void lbxListTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            ListMap mappedList = ((ListMap)lbxListTypes.SelectedItem);
            foreach (object obj in mappedList.list)
            {
                Panel pnl = new Panel();
                pnl.Width = pnl.Height = 160;
                pnl.Tag = new object[]{ obj, mappedList };
                foreach (var field in mappedList.fields)
                {
                    switch (field.FieldType.Name)
                    {
                        case "String":
                            if (field.Name == "name")
                            {
                                Label labName = new Label();
                                labName.Text = field.GetValue(obj).ToString();
                                labName.AutoSize = false;
                                labName.Width = pnl.Width - 2;
                                labName.Left = 1;
                                labName.Top = 1;
                                labName.TextAlign = ContentAlignment.MiddleCenter;
                                labName.BackColor = Color.FromArgb(175, Color.Black);
                                labName.ForeColor = Color.White;
                                pnl.Controls.Add(labName);
                            }
                            break;
                        case "Int32":
                            Console.WriteLine(field.FieldType.Name);
                            break;
                        case "Currency":
                            Console.WriteLine(field.FieldType.Name);
                            break;
                        case "Image":
                            pnl.BackgroundImage = (Image) field.GetValue(obj);
                            pnl.BackgroundImageLayout = ImageLayout.Zoom;
                            Console.WriteLine(field.FieldType.Name);
                            break;
                        default:
                            Console.WriteLine(field.FieldType.Name + " type is not supported!");
                            break;
                    }
                }
                foreach (Control c in pnl.Controls)
                {
                    c.Tag = new object[] { obj, mappedList }; ;
                    c.Click += Item_Click;
                }
                pnl.Click += Item_Click;
                flpItems.Controls.Add(pnl);
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            object[] tag = (object[])((Control)sender).Tag;
            object obj = tag[0];
            ListMap mappedList = (ListMap)tag[1];
            flpDetails.Controls.Clear();
            foreach (var field in mappedList.fields)
            {
                Panel pnl = new Panel();
                pnl.Size = new Size(flpDetails.Width - 25, 100);
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.AutoScroll = true;
                Label labName = new Label();
                labName.Text = field.Name;
                labName.AutoSize = false;
                labName.Width = pnl.Width - 6;
                labName.Left = 3;
                labName.Top = 1;
                labName.TextAlign = ContentAlignment.MiddleCenter;
                pnl.Controls.Add(labName);
                switch (field.FieldType.Name)
                {
                    case "String":
                        TextBox labText = new TextBox();
                        labText.Text = field.GetValue(obj).ToString();
                        labText.AutoSize = false;
                        labText.Width = pnl.Width - 6;
                        labText.Left = 3;
                        labText.Top = labName.Bottom + 5;
                        labText.TextAlign = HorizontalAlignment.Center;
                        pnl.Controls.Add(labText);
                        flpDetails.Controls.Add(pnl);
                        break;
                    case "Int32":
                        NumericUpDown nudInt = new NumericUpDown();
                        nudInt.Maximum = Int32.MaxValue;
                        nudInt.Minimum = Int32.MinValue;
                        nudInt.Value = (int)field.GetValue(obj);
                        nudInt.AutoSize = false;
                        nudInt.Width = pnl.Width - 6;
                        nudInt.Left = 3;
                        nudInt.Top = labName.Bottom + 5;
                        nudInt.TextAlign = HorizontalAlignment.Center;
                        pnl.Controls.Add(nudInt);
                        flpDetails.Controls.Add(pnl);
                        break;
                    case "Currency":
                        Console.WriteLine(field.FieldType.Name);
                        flpDetails.Controls.Add(pnl);
                        break;
                    case "Image":
                        //pnl.BackgroundImage = (Image)field.GetValue(obj);
                        //pnl.BackgroundImageLayout = ImageLayout.Zoom;
                        //Console.WriteLine(field.FieldType.Name);
                        //flpDetails.Controls.Add(pnl);
                        break;
                    default:
                        Console.WriteLine(field.FieldType.Name + " type is not supported!");
                        break;
                }
            }
        }
    }
}
