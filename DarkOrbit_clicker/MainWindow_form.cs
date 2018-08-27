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
    public partial class MainWindow_form : Form
    {

        public static List<Spaceship> spaceshipList = new List<Spaceship>();
        public static List<Drone> droneList = new List<Drone>();
        public static List<Booster> boosterList = new List<Booster>();
        public static List<Pet> petList = new List<Pet>();
        public static List<Protocol> protocolList = new List<Protocol>();
        public static List<Ammo> ammoList = new List<Ammo>();
        public static List<Design> designList = new List<Design>();
        public static List<Laser> laserList = new List<Laser>();
        public static List<Shield> shieldList = new List<Shield>();

        public MainWindow_form()
        {
            LoadData();
            Registration_form registration = new Registration_form();
            registration.ShowDialog();

            if (!Registration_form.success)
            {
                Application.Exit();
                return;
            }

            // CorpSelect corpSelect = new CorpSelect();

            //corpSelect.ShowDialog();

            
            InitializeComponent();
            

            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            RefreshInfo();
        }

        //Загружает базу данных
        public void LoadData() 
        {
            List<object> result = new List<object>();
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(Constants.DATABASE_PATH))
            {
                FileStream fsin = new FileStream(Constants.DATABASE_PATH, FileMode.Open, FileAccess.Read, FileShare.None);
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
                    MessageBox.Show("An error has occured while loading game database: " + e.Message, "Error");
                }
            }
            AuthService.LoadSaves();
        }

        // Метод принимает Control и возвращает Form.
        // Используется для того , чтобы поместить отправленную форму в отправленный элемент.
        // Благодаря DockStyle.Fill помещенная в панель форма полностью  её заполняет.
        public void InsertFormIntoControl(Control control, Form frm) 
        {
            frm.TopLevel = false;
            control.Controls.Clear();
            control.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Метод для обновления пользовтельской информации.
        public void RefreshInfo()
        {
            lbl_level.Text = "Level: " + AuthService.currentUser.level;
            lbl_exp.Text = "Exp: " + AuthService.currentUser.expirience;
            lbl_hon.Text = "Honor: " + AuthService.currentUser.honor;
            lbl_uridium.Text = "Uridium: " + AuthService.currentUser.uridium;
            lbl_kredits.Text = "Kredits: " + AuthService.currentUser.kredits;
        }

        // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
        // Панель заполняет форма ангара и отрисовывается.
        private void btn_hangar_MouseClick(object sender, MouseEventArgs e)
        {
            Form hangar = new Hangar_form();
            hangar.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hangar);
            hangar.Show();

        }

        // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
        // Панель заполняет форма магазина и отрисовывается.
        private void btn_shop_MouseClick(object sender, MouseEventArgs e) 
        {
            InsertFormIntoControl(pnlContent, new Shop_form(this));
        }

        // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
        // Панель заполняет форма галактических врат и отрисовывается.
        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e) 
        {
            InsertFormIntoControl(pnlContent, new GalaxyGates_form());
        }

        // Форма не поверх всех элементов.
        private void MainWindow_Deactivate(object sender, EventArgs e) 
        {
            TopMost = false;
        }

        // Метод для присваивания TopMost результата сравнения WindowState с FormWindowState.Maximized .
        private void MainWindow_Activated(object sender, EventArgs e) 
        {
            TopMost = WindowState == FormWindowState.Maximized;
        }

        // Метод для выхода из игры.
        private void btn_exit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }
    }
}