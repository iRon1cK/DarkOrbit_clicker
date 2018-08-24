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
    public partial class CorpSelect_form : Form
    {
        public CorpSelect_form()
        {
            InitializeComponent();
        }

        private void btn_acceptMMO_Click(object sender, EventArgs e)
        {
            AuthService.currentUser.corporation = User.Corp.Mars;
        }

        private void btn_acceptVRU_Click(object sender, EventArgs e)
        {
            AuthService.currentUser.corporation = User.Corp.Venus;
        }

        private void btn_acceptEIC_Click(object sender, EventArgs e)
        {
            AuthService.currentUser.corporation = User.Corp.Earth;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Mars.You have permanent bonus 10% for your all damage.";
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Venus.You have permanent bonus 15% for your health.";
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            lbl_companyDescription.Text = "This is Earth.You have permanent bonus 15% for your shield.";
        }

        private void CorpSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
