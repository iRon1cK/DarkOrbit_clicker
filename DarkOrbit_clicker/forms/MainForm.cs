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
    public partial class MainForm : Form
    {

        public static List<SpaceshipEntity> spaceshipList = new List<SpaceshipEntity>();
        public static List<DroneEntity> droneList = new List<DroneEntity>();
        public static List<BoosterEntity> boosterList = new List<BoosterEntity>();
        public static List<PetEntity> petList = new List<PetEntity>();
        public static List<ProtocolEntity> protocolList = new List<ProtocolEntity>();
        public static List<AmmoEntity> ammoList = new List<AmmoEntity>();
        public static List<DesignEntity> designList = new List<DesignEntity>();
        public static List<LaserEntity> laserList = new List<LaserEntity>();
        public static List<ShieldEntity> shieldList = new List<ShieldEntity>();

        public MainForm()
        {
            LoadData();
            if (!Constants.LOGIN_SKIP)
            {
                RegistrationForm registration = new RegistrationForm();
                registration.ShowDialog();
                
                if (!RegistrationForm.success)
                {
                    Application.Exit();
                    return;
                }
            }
            else
            {
                AuthService.currentUser = AuthService.userList.First();
            }

            // CorpSelect corpSelect = new CorpSelect();

            //corpSelect.ShowDialog();

            
            InitializeComponent();
            

           // TopMost = true;
           // FormBorderStyle = FormBorderStyle.None;
           // WindowState = FormWindowState.Maximized;

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
                        foreach (object o in (IEnumerable<object>)obj)
                        {
                            if (o is SpaceshipEntity)
                            {
                                spaceshipList.Add((SpaceshipEntity)o);
                            }
                            else if (o is DroneEntity)
                            {
                                droneList.Add((DroneEntity)o);
                            }
                            else if (o is BoosterEntity)
                            {
                                boosterList.Add((BoosterEntity)o);
                            }
                            else if (o is PetEntity)
                            {
                                petList.Add((PetEntity)o);
                            }
                            else if (o is ProtocolEntity)
                            {
                                protocolList.Add((ProtocolEntity)o);
                            }
                            else if (o is AmmoEntity)
                            {
                                ammoList.Add((AmmoEntity)o);
                            }
                            else if (o is DesignEntity)
                            {
                                designList.Add((DesignEntity)o);
                            }
                            else if (o is LaserEntity)
                            {
                                laserList.Add((LaserEntity)o);
                            }
                            else if (o is ShieldEntity)
                            {
                                shieldList.Add((ShieldEntity)o);
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
            Form hangar = new HangarForm();
            hangar.TopLevel = false;
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(hangar);
            hangar.Show();

        }

        // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
        // Панель заполняет форма магазина и отрисовывается.
        private void btn_shop_MouseClick(object sender, MouseEventArgs e) 
        {
            InsertFormIntoControl(pnlContent, new ShopForm(this));
        }

        // В метод отправляется объект вызывающий данное событие и аргументы с которыми был вызов.
        // Панель заполняет форма галактических врат и отрисовывается.
        private void btn_galaxyGates_MouseClick(object sender, MouseEventArgs e) 
        {
            InsertFormIntoControl(pnlContent, new GalaxyGatesForm());
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
        private void EnterFullscreenMode(bool fullscreen)
    {
        if (fullscreen)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            btn_exit.Visible = true;
            btn_fscr.Visible = true;
        }
        else
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            btn_exit.Visible = false;
            btn_fscr.Visible = false;
            }
    }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                EnterFullscreenMode(true);
            }
        }

        private void btn_fscr_Click(object sender, EventArgs e)
        {
            EnterFullscreenMode(false);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            InsertFormIntoControl(pnlContent, new MapSelectionForm());
        }
    }
}
