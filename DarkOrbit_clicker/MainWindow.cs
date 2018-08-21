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

namespace DarkOrbit_clicker
{    
    public partial class MainWindow : Form
    {
        public const string DATABASE_PATH = "data.dodb";
        public const string SAVEFILE_PATH = "users.dosv";


        public static User currentUser;

        public static List<User> userList = new List<User>();

        public static List<Spaceship> spaceshipList = new List<Spaceship>();
        public static List<Drone> droneList = new List<Drone>();
        public static List<Booster> boosterList = new List<Booster>();
        public static List<Pet> petList = new List<Pet>();
        public static List<Protocol> protocolList = new List<Protocol>();
        public static List<Ammo> ammoList = new List<Ammo>();
        public static List<Design> designList = new List<Design>();
        public static List<Laser> laserList = new List<Laser>();
        public static List<Shield> shieldList = new List<Shield>();

        public MainWindow()

        {
           // CorpSelect corpSelect = new CorpSelect()
            //if (currentUser != null)
           // {
           //corpSelect.ShowDialog());
           // }


            InitializeComponent();
            LoadData();

            currentUser = userList.First();

            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            //currentUser.kredits += 5000;
            //currentUser.spaceships.Add(new Spaceship());
            //currentUser.currentSpaceship = currentUser.spaceships.First();
            RefreshInfo();
        }


        public void LoadData() //Загружает базу данных
        {
            List<object> result = new List<object>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(DATABASE_PATH))
            {
                FileStream fsin = new FileStream(DATABASE_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
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
                            if (o is Spaceship)
                            {
                                spaceshipList.Add((Spaceship)o);
                            }
                            else if (o is Drone)
                            {
                                droneList.Add((Drone)o);
                            }
                            else if (o is Booster)
                            {
                                boosterList.Add((Booster)o);
                            }
                            else if (o is Pet)
                            {
                                petList.Add((Pet)o);
                            }
                            else if (o is Protocol)
                            {
                                protocolList.Add((Protocol)o);
                            }
                            else if (o is Ammo)
                            {
                                ammoList.Add((Ammo)o);
                            }
                            else if (o is Design)
                            {
                                designList.Add((Design)o);
                            }
                            else if (o is Laser)
                            {
                                laserList.Add((Laser)o);
                            }
                            else if (o is Shield)
                            {
                                shieldList.Add((Shield)o);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has occured: " + e.Message, "Error");
                }
            }
            if (File.Exists(SAVEFILE_PATH))
            {
                FileStream fsin = new FileStream(SAVEFILE_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
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
                    MessageBox.Show("An error has occured: " + e.Message, "Error");
                }
            }
        }

        public void InsertFormIntoControl(Control control, Form frm) // Метод принимает Control и возвращает Form.
                                                                    // Используется для того , чтобы поместить отправленную форму в отправленный элемент.
                                                                   // Благодаря DockStyle.Fill помещенная в панель форма полностью  её заполняет.
        {
            frm.TopLevel = false;
            control.Controls.Clear();
            control.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        public void RefreshInfo() // Метод для обновления пользовтельской информации.
        {
            lbl_level.Text = "Level: " + currentUser.level;
            lbl_exp.Text = "Exp: " + currentUser.expirience;
            lbl_hon.Text = "Honor: " + currentUser.honor;
            lbl_uridium.Text = "Uridium: " + currentUser.uridium;
            lbl_kredits.Text = "Kredits: " + currentUser.kredits;

        }

        private void btn_hangar_MouseClick(object sender, MouseEventArgs e) // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
                                                                           // Панель заполняет форма ангара и отрисовывается.
        {
            Form hangar = new Hangar();
            hangar.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hangar);
            hangar.Show();

        }

        private void btn_shop_MouseClick(object sender, MouseEventArgs e) // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
                                                                         // Панель заполняет форма магазина и отрисовывается.
        {
            InsertFormIntoControl(pnlContent, new Shop(this));
        }

        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e) // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
                                                                                // Панель заполняет форма галактических врат и отрисовывается.
        {
            InsertFormIntoControl(pnlContent, new GalaxyGates());
        }

        private void MainWindow_Deactivate(object sender, EventArgs e) // Форма не поверх всех элементов.
        {
            TopMost = false;
        }

        private void MainWindow_Activated(object sender, EventArgs e) // Метод для присваивания TopMost результата сравнения WindowState с FormWindowState.Maximized .
        {
            TopMost = WindowState == FormWindowState.Maximized;
        }

        private void btn_exit_Click(object sender, EventArgs e) // Метод для выхода из игры.
        {
            Application.Exit();
        }
    }
}