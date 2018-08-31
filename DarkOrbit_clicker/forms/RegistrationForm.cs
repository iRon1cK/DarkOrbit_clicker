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
    public partial class RegistrationForm : Form
    {

        public static bool success = false;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        // Метод вызывается , когда меняются rdb.
        private void haveOrDontHaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            // Меняется кнопка , в зависимости от выбора rdb.
            btn_logIn.Text = rdb_iHaveAccount.Checked ? "LOG IN" : "REGISTER";
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
                if (AuthService.LogIn(txtBox_nameEnter.Text, txtBox_passEnter.Text))
                {
                    if (AuthService.currentUser.corporation != UserEntity.Corp.NotSelected)
                    {
                        Success();

                    }
                    else
                    {
                        ShowCorpSelect();
                    }
                }
            }
            else
            {
                if (AuthService.Register(txtBox_nameEnter.Text, txtBox_passEnter.Text))
                {
                    ShowCorpSelect();
                }
            }
        }

        private void ShowCorpSelect()
        {
            HideForm();
            CorpSelectForm corpselect = new CorpSelectForm(this);
            corpselect.ShowDialog();
            HideForm();
        }

        private void HideForm()
        {
            if (this.Enabled)
            {
                this.Enabled = false;
                this.Opacity = 0;
            }
            else
            {
                this.Enabled = true;
                this.Opacity = 1;
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

        public void Success()
        {
            success = true;
            this.Close();

       }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (success == false)
            {
                Application.Exit();
            }
        }    
    }

}
