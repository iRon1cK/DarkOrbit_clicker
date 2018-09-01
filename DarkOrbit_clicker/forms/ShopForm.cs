using DarkOrbit_clicker.entities;
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
    public partial class ShopForm : Form
    {
        public SpaceshipEntity selectedShip;
        private Button selectedButton = null;
        private MainForm mainWindow;

        public ShopForm(MainForm main)
        {
            mainWindow = main;
            InitializeComponent();
            LoadShopItems();

            btn_ships.Tag = MainWindowForm.spaceshipList;
            btn_designs.Tag = MainWindowForm.designList;
            btn_drones.Tag = MainWindowForm.droneList;
            btn_weapoons.Tag = MainWindowForm.laserList;
            btn_generators.Tag = MainWindowForm.shieldList;
            btn_boosters.Tag = MainWindowForm.boosterList;
            btn_pet.Tag = MainWindowForm.petList;
            btn_petProtocols.Tag = MainWindowForm.protocolList;
            btn_ammo.Tag = MainWindowForm.ammoList;
            SelectButton(btn_ships);
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            SelectButton((Button)sender);
        }

        private void shopButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = btn == selectedButton ? Color.Orange : Color.Gray;
        }

        private void shopButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = btn == selectedButton ? Color.Yellow : Color.White;
        }

        public void SelectButton(Button buttonToSelect)
        {
            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.White;
            }
            selectedButton = buttonToSelect;
            LoadShopItems();
            buttonToSelect.BackColor = Color.Yellow;
            //when category changed
        }

        //Метод используется для автоматического отображения ячеек и предметов в магазине.
        //Предметы он берёт из списков, которые в MainWindow
        public void LoadShopItems()
        {
            //TODO work with selectedButton Tag
            int i = 0;
            foreach (SpaceshipEntity spaceship in MainForm.spaceshipList) 
            {
                Panel pnl = new Panel();
                pnl.BackgroundImage = Properties.Resources.bg_real_100x100;
                
                pnl.Width = pnl.Height = 155;
                pnl.Margin = new Padding(10);
                

                Label labName = new Label();
                labName.Text = spaceship.name;
                labName.TextAlign = ContentAlignment.MiddleCenter;
                labName.AutoSize = false;
                labName.Width = pnl.Width-2;
                labName.Height = 20;
                labName.Location = new Point(1, 1);
                labName.BackColor = Color.FromArgb(175, Color.Black);
                labName.ForeColor = Color.White;
                pnl.Controls.Add(labName);

                Label labPrice = new Label();
                labPrice.Text = spaceship.price.ToString();
                labPrice.TextAlign = ContentAlignment.MiddleCenter;
                labPrice.AutoSize = false;
                labPrice.Width = pnl.Width - 2;
                labPrice.Height = 20;
                labPrice.Location = new Point(1, pnl.Height-labPrice.Height-1);
                labPrice.BackColor = Color.FromArgb(175, Color.Black);
                labPrice.ForeColor = Color.White;
                pnl.Controls.Add(labPrice);

                Panel pnlImage = new Panel();
                pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
                pnlImage.BackgroundImage = spaceship.image;
                pnlImage.BackColor = Color.Transparent;
                pnlImage.Size = pnl.Size;
                pnlImage.Location = new Point(0, 0);
                pnl.Controls.Add(pnlImage);

                foreach (Control c in pnl.Controls)
                {
                    c.Click += pnlSpaceShip_Click;
                    c.Tag = spaceship;
                }

                flp_backShopItems.Controls.Add(pnl);
                i++;
            }
            if (MainForm.spaceshipList.Count > 0)
            {
                selectedShip = MainForm.spaceshipList.First();
            }
            updateSpaceshipInfo();
        }

        //TODO
        private void updateSpaceshipInfo() // Метод для отображения информации о выбраном корабле.
        {
            //Тут selectedShip - корабль, по которому нажали
            if (selectedShip != null)
            {
                pctr_image_item_selected.BackgroundImage = selectedShip.image;
                lbl_itemName.Text = selectedShip.name;
                //lbl_itemPrice.Text = selectedShip.price;
                btn_buyItem.Enabled = enoughMoney();
            }
        }

        private bool enoughMoney() // Проверка дополнительных условий для покупки предмета.
        {
            if (selectedShip.currency == ShopItem.Currency.Kredits && (AuthService.currentUser.kredits >= selectedShip.price))
                return true;
            else if (selectedShip.currency == ShopItem.Currency.Uridium && (AuthService.currentUser.uridium >= selectedShip.price))
                return true;
            return false;
        }

        private void pnlSpaceShip_Click(object sender, EventArgs e)
        {
            selectedShip = (SpaceshipEntity)((Control)sender).Tag;
            updateSpaceshipInfo();
        }
       
        

        private void btn_buyItem_Click(object sender, EventArgs e)  // Метод и условия для покупки корабля по нажатию на кнопку.
        {
            UserEntity currentUser = AuthService.currentUser;
            if (selectedShip.currency == ShopItem.Currency.Kredits && (currentUser.kredits >= selectedShip.price) && (currentUser.currentSpaceship != selectedShip))
            {
                currentUser.kredits -= selectedShip.price;
                currentUser.spaceships.Add(selectedShip);
                MessageBox.Show("Spaceship " + selectedShip.name + " successfully bought!", "Success");
            }
            else if (selectedShip.currency == ShopItem.Currency.Uridium && (currentUser.uridium >= selectedShip.price)) 
            {
                currentUser.uridium -= selectedShip.price;
                currentUser.spaceships.Add(selectedShip);
                MessageBox.Show("Spaceship " + selectedShip.name + " successfully bought!", "Success");
            }
            else
            {
                MessageBox.Show("You have not enough money!", "Error");
            }
        }
    }
}
