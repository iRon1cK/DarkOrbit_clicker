using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkOrbit_clicker
{
    public partial class MainWindow : Form
    {
        public static User currentUser = new User("Zhora");

        public static List<Spaceship> spaceshipList = new List<Spaceship>();
        public static List<Laser> laserList = new List<Laser>();
        public static List<Shield> shipList = new List<Shield>();

        public MainWindow()
        {
            InitializeComponent();
            LoadData();

            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;


            currentUser.kredits += 5000;
            currentUser.spaceships.Add(new Spaceship());
            currentUser.currentSpaceship = currentUser.spaceships.First();
            RefreshInfo();
            

            /* Form select = new Shop();
             select.Show();*/
            // <Spaceship> spaceshipList = new List<Spaceship>();

            //Random rnd = new Random();

            //for (int i = 0; i < 100; i++)
            //{
            //    Spaceship korabel = new Spaceship();
            //    korabel.name = rnd.Next(0, 100) + "";
            //    korabel.hp = rnd.Next(0, 100);

            //    spaceshipList.Add(korabel);
            //}

            //int j = 0;
            //foreach (Spaceship k in spaceshipList)
            //{
            //    Panel p = new Panel();
            //    p.Height = p.Width = 100;
            //    p.Left = 20 + (j % 2 == 1 ? 0 : 120);
            //    p.Top = (j % 2 == 1 ? j : j-120);
            //    p.BackColor = Color.Green;
            //    Label a = new Label();
            //    a.AutoSize = true;
            //    a.Text = "Name: " + k.name + "\nHp: " + k.hp;
            //    p.Controls.Add(a);
            //    this.Controls.Add(p);
            //    j += 120;
            //}
        }

        public void LoadData()
        {
            Random rnd = new Random();
            for (int sp = 0; sp < 10; sp++)
            {
                Spaceship spaceship = new Spaceship();
                spaceship.name = "Index: " + sp;
                spaceship.price = rnd.Next(100, 10000);
                spaceshipList.Add(spaceship);
            }
        }

        public void InsertFormIntoPanel(Panel pnl, Form frm)
        {
            frm.TopLevel = false;
            pnl.Controls.Clear();
            pnl.Controls.Add(frm);
            frm.Show();
        }

        public void RefreshInfo()
        {
            lbl_level.Text = "Level: " + MainWindow.currentUser.level;
            lbl_exp.Text = "Exp: " + MainWindow.currentUser.expirience;
            lbl_hon.Text = "Honor: " + MainWindow.currentUser.honor;
            lbl_uridium.Text = "Uridium: " + MainWindow.currentUser.uridium;
            lbl_kredits.Text = "Kredits: " + MainWindow.currentUser.kredits;

        }

        private void btn_hangar_MouseClick(object sender, MouseEventArgs e)
        {
            Form hangar = new Hangar();
            hangar.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(hangar);
            hangar.Show();

        }

        private void btn_shop_MouseClick(object sender, MouseEventArgs e)
        {
            InsertFormIntoPanel(panel1, new Shop());
        }

        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e)
        {
            InsertFormIntoPanel(panel1, new GalaxyGates());
        }
    }
}