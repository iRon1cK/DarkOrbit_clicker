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
    public partial class Hangar : Form
    {
        public Hangar()
        {
            InitializeComponent();
            ShowSpaceship(MainWindow.currentUser.currentSpaceship);
        }

        private void ShowSpaceship(Spaceship spaceship)
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
