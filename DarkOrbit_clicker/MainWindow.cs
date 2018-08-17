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
        public static User currentUser = new User("Zhora");

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
            InitializeComponent();
            LoadData();

            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            currentUser.kredits += 5000;
            currentUser.spaceships.Add(new Spaceship());
            currentUser.currentSpaceship = currentUser.spaceships.First();
            RefreshInfo();
        }

        public void LoadData() // Метод загрузки  иконок предметов в магазине , вызывается при переходе в магазин.
        {
            Random rnd = new Random();
            for (int sp = 0; sp < 10; sp++)  // Для кораблей.
            {
                Spaceship spaceship = new Spaceship();
                spaceship.name = "Index: " + sp;
                spaceship.price = rnd.Next(100, 10000);
                spaceshipList.Add(spaceship);
            }

            for (int sp = 0; sp < 10; sp++) // Для дизайнов кораблей.
            {
                Design design = new Design();
                design.name = "Index: " + sp;
                design.price = rnd.Next(10000, 100000);
                designList.Add(design);
            }
        }

        public void InsertFormIntoControl(Control control, Form frm) // Метод для Control в любой элемент.
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

        private void btn_hangar_MouseClick(object sender, MouseEventArgs e) // Метод для отрисовки формы ангара.
        {
            Form hangar = new Hangar();
            hangar.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hangar);
            hangar.Show();

        }

        private void btn_shop_MouseClick(object sender, MouseEventArgs e) // Метод для отрисовки формы магазина.
        {
            InsertFormIntoControl(pnlContent, new Shop(this));
        }

        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e) // Метод для отрисовки формы космических врат.
        {
            InsertFormIntoControl(pnlContent, new GalaxyGates());
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            TopMost = false;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            TopMost = WindowState == FormWindowState.Maximized;
        }

        private void btn_exit_Click(object sender, EventArgs e) // Метод для выхода из игры.
        {
            Application.Exit();
        }
    }
}