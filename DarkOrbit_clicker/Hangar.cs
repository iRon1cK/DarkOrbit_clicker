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
    public partial class Hangar : Form
    {
        public Hangar()
        {
            InitializeComponent();
            ShowSpaceship(AuthService.currentUser.currentSpaceship);
        }

        private void ShowSpaceship(Spaceship spaceship) // Метод принимает Spaceship, ничего не возвращает. 
                                                       // Используется для того, чтобы вывести информацию о отправленном в него корабле.
                                                      // Вызываться должен только из этой формы - при первом её открытии и при изменении корабля.
        {
            pbx_shipImage.BackgroundImage = spaceship.image;
            lbl_shipStats.Text =
                 spaceship.name + "\n" +
                "Lasers: " + spaceship.lasersMax + "\n" +
                "Shields: " + spaceship.shieldsMax;

        }

        private void Hangar_Load(object sender, EventArgs e)
        {

        }
    }
}
