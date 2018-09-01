﻿using DarkOrbit_clicker.entities;
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
        private ShopItem selectedItem;
        private Button selectedButton = null;
        private Panel selectedItemPanel = null;
        private MainForm mainWindow;

        private int animationStep = 0;

        public ShopForm(MainForm main)
        {
            mainWindow = main;
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 1000 / Constants.ANIMATION_IMAGES_PER_SECOND;
            timer.Tick += Timer_Tick;
            timer.Start();

            //TODELETE
            foreach (SpaceshipEntity spaceship in MainForm.spaceshipList)
            {
                spaceship.previewAnimationImages = new List<Image>();
                spaceship.previewAnimationImages.Add(Properties.Resources._1);
                spaceship.previewAnimationImages.Add(Properties.Resources._2);
                spaceship.previewAnimationImages.Add(Properties.Resources._3);
                spaceship.previewAnimationImages.Add(Properties.Resources._4);
                spaceship.previewAnimationImages.Add(Properties.Resources._5);
                spaceship.previewAnimationImages.Add(Properties.Resources._6);
                spaceship.previewAnimationImages.Add(Properties.Resources._7);
                spaceship.previewAnimationImages.Add(Properties.Resources._8);
                spaceship.previewAnimationImages.Add(Properties.Resources._9);
                spaceship.previewAnimationImages.Add(Properties.Resources._10);
                spaceship.previewAnimationImages.Add(Properties.Resources._11);
                spaceship.previewAnimationImages.Add(Properties.Resources._12);
                spaceship.previewAnimationImages.Add(Properties.Resources._13);
                spaceship.previewAnimationImages.Add(Properties.Resources._14);
                spaceship.previewAnimationImages.Add(Properties.Resources._15);
                spaceship.previewAnimationImages.Add(Properties.Resources._16);
                spaceship.previewAnimationImages.Add(Properties.Resources._17);
                spaceship.previewAnimationImages.Add(Properties.Resources._18);
                spaceship.previewAnimationImages.Add(Properties.Resources._19);
                spaceship.previewAnimationImages.Add(Properties.Resources._20);
                spaceship.previewAnimationImages.Add(Properties.Resources._21);
                spaceship.previewAnimationImages.Add(Properties.Resources._22);
                spaceship.previewAnimationImages.Add(Properties.Resources._23);
                spaceship.previewAnimationImages.Add(Properties.Resources._24);
                spaceship.previewAnimationImages.Add(Properties.Resources._25);
                spaceship.previewAnimationImages.Add(Properties.Resources._26);
                spaceship.previewAnimationImages.Add(Properties.Resources._27);
                spaceship.previewAnimationImages.Add(Properties.Resources._28);
                spaceship.previewAnimationImages.Add(Properties.Resources._29);
                spaceship.previewAnimationImages.Add(Properties.Resources._30);
                spaceship.previewAnimationImages.Add(Properties.Resources._31);
                spaceship.previewAnimationImages.Add(Properties.Resources._32);
            }

            btn_ships.Tag = MainForm.spaceshipList;
            btn_designs.Tag = MainForm.designList;
            btn_drones.Tag = MainForm.droneList;
            btn_weapoons.Tag = MainForm.laserList;
            btn_generators.Tag = MainForm.shieldList;
            btn_boosters.Tag = MainForm.boosterList;
            btn_pet.Tag = MainForm.petList;
            btn_petProtocols.Tag = MainForm.protocolList;
            btn_ammo.Tag = MainForm.ammoList;

            SelectButton(btn_ships);
        }

        private void shopButton_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;
            if (clickedBtn != selectedButton)
                SelectButton(clickedBtn);
        }

        private void shopButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = btn == selectedButton ? Properties.Resources.spr_shop_clicked : Properties.Resources.spr_shop_a;
        }

        private void shopButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = btn == selectedButton ? Properties.Resources.spr_shop_clicked : Properties.Resources.spr_shop_p;
        }

        //when category changed
        public void SelectButton(Button buttonToSelect)
        {
            if (selectedButton != null)
            {
                selectedButton.BackgroundImage = Properties.Resources.spr_shop_p;
            }
            selectedButton = buttonToSelect;
            LoadShopItems();
            buttonToSelect.BackgroundImage = Properties.Resources.spr_shop_clicked;
        }

        //Метод используется для автоматического отображения ячеек и предметов в магазине.
        //Предметы он берёт из списков, которые в MainWindow
        public void LoadShopItems()
        {
            flp_backShopItems.SuspendLayout();
            flp_backShopItems.Controls.Clear();
            IEnumerable<ShopItem> itemList = (IEnumerable<ShopItem>)selectedButton.Tag;
            foreach (ShopItem item in itemList) 
            {
                Panel pnl = new Panel();
                pnl.BackgroundImage = Properties.Resources.passive_icon;
                pnl.BackgroundImageLayout = ImageLayout.Zoom;
                
                pnl.Width = pnl.Height = 155;
                pnl.Margin = new Padding(10);
                

                Label labName = new Label();
                labName.Text = item.name;
                labName.TextAlign = ContentAlignment.MiddleCenter;
                labName.AutoSize = false;
                labName.Width = pnl.Width-10;
                labName.Height = 20;
                labName.Location = new Point(5, 4);
                labName.BackColor = Color.FromArgb(175, Color.Black);
                labName.ForeColor = Color.White;
                pnl.Controls.Add(labName);

                Label labPrice = new Label();
                labPrice.Text = item.price + " " + item.currency;
                labPrice.TextAlign = ContentAlignment.MiddleCenter;
                labPrice.AutoSize = false;
                labPrice.Width = pnl.Width - 10;
                labPrice.Height = 20;
                labPrice.Location = new Point(5, pnl.Height-labPrice.Height-4);
                labPrice.BackColor = Color.FromArgb(175, Color.Black);
                labPrice.ForeColor = Color.White;
                pnl.Controls.Add(labPrice);

                Panel pnlImage = new Panel();
                pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
                pnlImage.BackgroundImage = item.image;
                pnlImage.BackColor = Color.Transparent;
                pnlImage.Size = pnl.Size;
                pnlImage.Location = new Point(0, 0);
                pnl.Controls.Add(pnlImage);

                foreach (Control c in pnl.Controls)
                {
                    c.Click += pnlShopItem_Click;
                    c.MouseEnter += pnlShopItem_MouseEnter;
                    c.MouseLeave += pnlShopItem_MouseLeave;
                    c.Tag = item;
                }

                flp_backShopItems.Controls.Add(pnl);
            }
            if (itemList.Count() > 0)
            {
                selectedItem = itemList.First();
            }
            updateSelecedItemInfo();
            flp_backShopItems.ResumeLayout();
        }


        private void pnlShopItem_MouseEnter(object sender, EventArgs e)
        {
            Panel pnl = (Panel)((Control)sender).Parent;
            pnl.BackgroundImage = pnl == selectedItemPanel ? Properties.Resources.clicked_icon : Properties.Resources.active_icon;

        }

        private void pnlShopItem_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl = (Panel)((Control)sender).Parent;
            pnl.BackgroundImage = pnl == selectedItemPanel ? Properties.Resources.clicked_icon : Properties.Resources.passive_icon;
        }

        

        //TODO
        //Метод для отображения информации о выбраном ShopItem.
        private void updateSelecedItemInfo() 
        {
            if (selectedItem != null)
            {
                shop_item_image_selected.BackgroundImage = selectedItem.image;
                lbl_itemName.Text = selectedItem.name;
                lbl_itemDescription.Text = selectedItem.description;
                lbl_itemPrice.Text = selectedItem.price + " " + selectedItem.currency;
                btn_buyItem.Enabled = enoughMoney();
                animationStep = 0;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (selectedItem != null)
            {
                animationStep = animationStep + 1 >= selectedItem.previewAnimationImages.Count() ? 0 : animationStep + 1;
                shop_item_image_selected.BackgroundImage = selectedItem.previewAnimationImages.ElementAt(animationStep);
            }
        }

        private bool enoughMoney() // Проверка дополнительных условий для покупки предмета.
        {
            if (selectedItem.currency == ShopItem.Currency.Kredits && (AuthService.currentUser.kredits >= selectedItem.price))
                return true;
            else if (selectedItem.currency == ShopItem.Currency.Uridium && (AuthService.currentUser.uridium >= selectedItem.price))
                return true;
            return false;
        }

        private void pnlShopItem_Click(object sender, EventArgs e)
        {
            //sender - Panel
            if (selectedItemPanel != null)
                selectedItemPanel.BackgroundImage = Properties.Resources.passive_icon;
            selectedItemPanel = (Panel)((Control)sender).Parent;
            selectedItemPanel.BackgroundImage = Properties.Resources.clicked_icon;
            selectedItem = (ShopItem)((Control)sender).Tag;
            updateSelecedItemInfo();
        }
       
        
        private void btn_buyItem_Click(object sender, EventArgs e)  // Метод и условия для покупки корабля по нажатию на кнопку.
        {
            //UserEntity currentUser = AuthService.currentUser;
            //if (selectedShip.currency == ShopItem.Currency.Kredits && (currentUser.kredits >= selectedShip.price) && (currentUser.currentSpaceship != selectedShip))
            //{
            //    currentUser.kredits -= selectedShip.price;
            //    currentUser.spaceships.Add(selectedShip);
            //    MessageBox.Show("Spaceship " + selectedShip.name + " successfully bought!", "Success");
            //}
            //else if (selectedShip.currency == ShopItem.Currency.Uridium && (currentUser.uridium >= selectedShip.price)) 
            //{
            //    currentUser.uridium -= selectedShip.price;
            //    currentUser.spaceships.Add(selectedShip);
            //    MessageBox.Show("Spaceship " + selectedShip.name + " successfully bought!", "Success");
            //}
            //else
            //{
            //    MessageBox.Show("You have not enough money!", "Error");
            //}
        }

        private void btn_buyItem_MouseEnter(object sender, EventArgs e)
        {
           ((Button)sender).BackgroundImage = Properties.Resources.buy_active;
        }
         
        private void btn_buyItem_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.buy_passive;
        }
    }
}
