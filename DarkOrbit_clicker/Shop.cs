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
    public partial class Shop : Form
    {
        public enum Category
        {
            Ships,
            Designs
                //.... TODO
        }

        public enum Currency
        {
            Uridium,
            Kredits
        }

        public Category category = Category.Ships;
        public Spaceship selectedShip;

        public Shop()
        {
            InitializeComponent();
            LoadShips();
        }

        public void LoadShips()
        {
            int x = 27;
            int y = 8;
            int i = 0;
            foreach (Spaceship spaceship in MainWindow.spaceshipList)
            {
                Panel pnl = new Panel();
                pnl.Tag = spaceship;
                pnl.BackgroundImageLayout = ImageLayout.Zoom;
                pnl.BackgroundImage = spaceship.image;
                pnl.Size = new Size(107, 85);
                
                x = i % 2 == 1 ? (27 + 10 + pnl.Width) : 27;
                if (i % 2 == 0 && i > 0)
                {
                    y += 8 + pnl.Height;
                }
                pnl.Location = new Point(x, y);

                pnl.Click += pnlSpaceShip_Click;

                Label labName = new Label();
                labName.Text = spaceship.name;
                labName.TextAlign = ContentAlignment.MiddleCenter;
                labName.AutoSize = false;
                labName.Top = 1;
                labName.Left = 1;
                labName.Width = pnl.Width-2;
                labName.Height = 20;
                labName.BackColor = Color.FromArgb(175, Color.Black);
                labName.ForeColor = Color.White;
                pnl.Controls.Add(labName);

                Label labPrice = new Label();
                labPrice.Text = spaceship.price.ToString();
                labPrice.TextAlign = ContentAlignment.MiddleCenter;
                labPrice.AutoSize = false;
                labPrice.Width = pnl.Width - 2;
                labPrice.Height = 20;
                labPrice.Top = pnl.Height - labPrice.Height - 1;
                labPrice.Left = 1;
                labPrice.BackColor = Color.FromArgb(175, Color.Black);
                labPrice.ForeColor = Color.White;
                pnl.Controls.Add(labPrice);

                pnl_backShopItems.Controls.Add(pnl);
                i++;
            }
            selectedShip = MainWindow.spaceshipList.First();
            updateSpaceshipInfo();
        }

        //TODO
        private void updateSpaceshipInfo()
        {
            //Тут selectedShip - корабль, по которому нажали
            pctr_image_item_selected.BackgroundImage = selectedShip.image;
            lbl_itemName.Text = selectedShip.name;
            btn_buyItem.Enabled = enoughMoney();
        }

        private bool enoughMoney()
        {
            if (selectedShip.currency == Currency.Kredits && (MainWindow.currentUser.kredits >= selectedShip.price))
                return true;
            else if (selectedShip.currency == Currency.Uridium && (MainWindow.currentUser.uridium >= selectedShip.price))
                return true;
            return false;
        }

        private void pnlSpaceShip_Click(object sender, EventArgs e)
        {
            selectedShip = (Spaceship)((Panel)sender).Tag;
            updateSpaceshipInfo();
        }

        private void btn_buyItem_Click(object sender, EventArgs e)
        {
            User currentUser = MainWindow.currentUser;
            if (selectedShip.currency == Currency.Kredits && (currentUser.kredits >= selectedShip.price))
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
