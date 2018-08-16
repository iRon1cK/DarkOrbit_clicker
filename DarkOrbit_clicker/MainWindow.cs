﻿using System;
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
        public static List<Drone> droneList = new List<Drone>();
        public static List<Booster> boosterList = new List<Booster>();
        public static List<Pet> petList = new List<Pet>();
        public static List<Protocol> protocolList = new List<Protocol>();
        public static List<Ammo> ammolList = new List<Ammo>();
        public static List<Design> designList = new List<Design>();
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
            
            for (int sp = 0; sp < 10; sp++)
            {
                Design design = new Design();
                design.name = "Index: " + sp;
                design.price = rnd.Next(10000, 100000);
                designList.Add(design);
            }
        }

        public void InsertFormIntoControl(Control control, Form frm)
        {
            frm.TopLevel = false;
            control.Controls.Clear();
            control.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
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
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hangar);
            hangar.Show();

        }

        private void btn_shop_MouseClick(object sender, MouseEventArgs e)
        {
            InsertFormIntoControl(pnlContent, new Shop(this));
        }

        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e)
        {
            InsertFormIntoControl(pnlContent, new GalaxyGates());
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Maximized)
            //{
            //    TopMost = true;
            //    FormBorderStyle = FormBorderStyle.None;
            //}
            //else
            //{
            //    TopMost = false;
            //    FormBorderStyle = FormBorderStyle.Sizable;
            //}
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            //TopMost = false;
        }

        private void MainWindow_Activated(object sender, EventArgs e)
        {
            //TopMost = WindowState == FormWindowState.Maximized;
        }
    }
}