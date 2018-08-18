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
        public static User currentUser;

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

            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            currentUser.kredits += 5000;
            currentUser.spaceships.Add(new Spaceship());
            currentUser.currentSpaceship = currentUser.spaceships.First();
            RefreshInfo();
        }

        public void LoadData() // Метод заполняет тестовыми элементами базы данных категорий магазина . 
        {
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