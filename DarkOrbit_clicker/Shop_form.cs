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
    public partial class Shop_form : Form
    {
        public enum Category
        {
            Ships,
            Designs,
            Drones,
            Weapoons,
            Generators,
            Boosters,
            PET,
            PETprotocols,
            Ammo
        }

        public enum Currency
        {
            Uridium,
            Kredits
        }

        public Category category = Category.Ships;
        public Spaceship selectedShip;
      

        private MainWindow_form mainWindow;

        public Shop_form(MainWindow_form main)
        {
            mainWindow = main;
            InitializeComponent();
            LoadShips();
        }

        public void LoadShips() // Метод используется для автоматического отображения ячеек и предметов в магазине. 
                               //Предметы он берёт из списков, которые в MainWindow
        {
            int i = 0;
            foreach (Spaceship spaceship in MainWindow_form.spaceshipList) 
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
            if (MainWindow_form.spaceshipList.Count > 0)
            {
                selectedShip = MainWindow_form.spaceshipList.First();
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
            if (selectedShip.currency == Currency.Kredits && (AuthService.currentUser.kredits >= selectedShip.price))
                return true;
            else if (selectedShip.currency == Currency.Uridium && (AuthService.currentUser.uridium >= selectedShip.price))
                return true;
            return false;
        }

        private void pnlSpaceShip_Click(object sender, EventArgs e)
        {
            selectedShip = (Spaceship)((Control)sender).Tag;
            updateSpaceshipInfo();
        }
       
        

        private void btn_buyItem_Click(object sender, EventArgs e)  // Метод и условия для покупки корабля по нажатию на кнопку.
        {
            User currentUser = AuthService.currentUser;
            if (selectedShip.currency == Currency.Kredits && (currentUser.kredits >= selectedShip.price) && (currentUser.currentSpaceship != selectedShip))
            {
                currentUser.kredits -= selectedShip.price;
                currentUser.spaceships.Add(selectedShip);
                MessageBox.Show("Spaceship " + selectedShip.name + " successfully bought!", "Success");
            }
            else if (selectedShip.currency == Currency.Uridium && (currentUser.uridium >= selectedShip.price)) 
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
