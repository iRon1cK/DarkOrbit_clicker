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
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
        }

        // Метод вызывается , когда меняются rdb.
        private void haveOrDontHaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            // Меняется кнопка , в зависимости от выбора rdb.
            btn_logIn.Text = rdb_iHaveAccount.Checked ? "Log in" : "Register";
            // Показывает или не показывает поле для ввода подтверждения пароля.
            lbl_repeatPass.Visible = txtBox_passRepeat.Visible = rdb_iDontHaveAccount.Checked; 

            ValidateFields();
        }

        // Метод вызывается , когда начинается ввод текста в поле для ввода.
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            if (rdb_iHaveAccount.Checked) 
            {
                AuthService.LogIn(txtBox_nameEnter.Text, txtBox_passEnter.Text);
            }
            else 
            {
                AuthService.Register(txtBox_nameEnter.Text, txtBox_passEnter.Text);
            }
 
        }

        //Проверка полей на корректность введённых данных
        private void ValidateFields()
        {
            
            string error = "";
            error += txtBox_nameEnter.Text == "" ? "Login field is empty!\n" : "";
            error += txtBox_nameEnter.TextLength > Constants.MAX_LOGIN_LENGTH ? 
                "Login can't be more than " + Constants.MAX_LOGIN_LENGTH + " characters!\n" : "";
            error += txtBox_nameEnter.TextLength < Constants.MIN_LOGIN_LENGTH ? 
                "Login can't be less than " + Constants.MIN_LOGIN_LENGTH + " characters!\n" : "";

            error += 
                txtBox_passEnter.Text != "" && txtBox_passEnter.Text != txtBox_passRepeat.Text && rdb_iDontHaveAccount.Checked ? 
                "Passwords are not matching!\n" : "";
            error += txtBox_passEnter.TextLength > Constants.MAX_PASSWORD_LENGTH ? 
                "Password can't be more than " + Constants.MAX_PASSWORD_LENGTH + " characters!\n" : "";
            error += txtBox_passEnter.TextLength < Constants.MIN_PASSWORD_LENGTH ? 
                "Password can't be less than " + Constants.MIN_PASSWORD_LENGTH + " characters!\n" : "";

            if (error != lbl_error.Text)
            {
                lbl_error.Text = error;
            }
            btn_logIn.Enabled = (error == "");
        }

        private void Registration_form_Load(object sender, EventArgs e)
        {

        }
    }
}
