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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void haveOrDontHaveAccount_CheckedChanged(object sender, EventArgs e) // Метод вызывается , когда меняются rdb.
        {
            btn_logIn.Text = rdb_iHaveAccount.Checked ? "Log in" : "Register";  // Меняется кнопка , в зависимости от выбора rdb.
            lbl_repeatPass.Visible = txtBox_passRepeat.Visible = rdb_iDontHaveAccount.Checked; // Показывает или не показывает поле для ввода подтверждения пароля.
        }

        private void txtBox_TextChanged(object sender, EventArgs e) // Метод вызывается , когда начинается ввод текста в поле для ввода.
        {
            txtBox_passRepeat.BackColor = txtBox_passEnter.Text != "" && txtBox_passEnter.Text != txtBox_passRepeat.Text && //Если при регистрации ввели не одинаковые пароли подсветка
            rdb_iDontHaveAccount.Checked ? Color.FromArgb(255, 255, 200, 200) : Color.White;  // поля для ввода подтверждения пароля становится красной.


            btn_logIn.Enabled = txtBox_nameEnter.Text != "" && txtBox_passEnter.Text != "" && // Активация кнопки входа  или регистрации, если
            (rdb_iHaveAccount.Checked || txtBox_passEnter.Text == txtBox_passRepeat.Text);   //все данные введены верно.

        }

        private void btn_logIn_Click(object sender, EventArgs e)
        { 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hashedPass = Hasher.hashSha256(txtBox_passRepeat.Text);
            MessageBox.Show(hashedPass);
        }
    }
}
