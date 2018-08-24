namespace DarkOrbit_clicker
{
    partial class Registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_logIn = new System.Windows.Forms.Button();
            this.rdb_iHaveAccount = new System.Windows.Forms.RadioButton();
            this.txtBox_passEnter = new System.Windows.Forms.TextBox();
            this.rdb_iDontHaveAccount = new System.Windows.Forms.RadioButton();
            this.txtBox_passRepeat = new System.Windows.Forms.TextBox();
            this.lbl_enterName = new System.Windows.Forms.Label();
            this.txtBox_nameEnter = new System.Windows.Forms.TextBox();
            this.lbl_enterPass = new System.Windows.Forms.Label();
            this.lbl_repeatPass = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.Enabled = false;
            this.btn_logIn.Location = new System.Drawing.Point(249, 76);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(115, 23);
            this.btn_logIn.TabIndex = 18;
            this.btn_logIn.Text = "LOG IN";
            this.btn_logIn.UseVisualStyleBackColor = true;
            this.btn_logIn.ClientSizeChanged += new System.EventHandler(this.btn_logIn_Click);
            // 
            // rdb_iHaveAccount
            // 
            this.rdb_iHaveAccount.AutoSize = true;
            this.rdb_iHaveAccount.Checked = true;
            this.rdb_iHaveAccount.Location = new System.Drawing.Point(13, 10);
            this.rdb_iHaveAccount.Name = "rdb_iHaveAccount";
            this.rdb_iHaveAccount.Size = new System.Drawing.Size(97, 17);
            this.rdb_iHaveAccount.TabIndex = 10;
            this.rdb_iHaveAccount.TabStop = true;
            this.rdb_iHaveAccount.Text = "I have account";
            this.rdb_iHaveAccount.UseVisualStyleBackColor = true;
            this.rdb_iHaveAccount.CheckedChanged += new System.EventHandler(this.haveOrDontHaveAccount_CheckedChanged);
            // 
            // txtBox_passEnter
            // 
            this.txtBox_passEnter.Location = new System.Drawing.Point(264, 34);
            this.txtBox_passEnter.Name = "txtBox_passEnter";
            this.txtBox_passEnter.PasswordChar = '•';
            this.txtBox_passEnter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passEnter.TabIndex = 17;
            this.txtBox_passEnter.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // rdb_iDontHaveAccount
            // 
            this.rdb_iDontHaveAccount.AutoSize = true;
            this.rdb_iDontHaveAccount.Location = new System.Drawing.Point(13, 34);
            this.rdb_iDontHaveAccount.Name = "rdb_iDontHaveAccount";
            this.rdb_iDontHaveAccount.Size = new System.Drawing.Size(120, 17);
            this.rdb_iDontHaveAccount.TabIndex = 11;
            this.rdb_iDontHaveAccount.TabStop = true;
            this.rdb_iDontHaveAccount.Text = "I need new account";
            this.rdb_iDontHaveAccount.UseVisualStyleBackColor = true;
            this.rdb_iDontHaveAccount.CheckedChanged += new System.EventHandler(this.haveOrDontHaveAccount_CheckedChanged);
            // 
            // txtBox_passRepeat
            // 
            this.txtBox_passRepeat.BackColor = System.Drawing.Color.White;
            this.txtBox_passRepeat.Location = new System.Drawing.Point(123, 78);
            this.txtBox_passRepeat.Name = "txtBox_passRepeat";
            this.txtBox_passRepeat.PasswordChar = '•';
            this.txtBox_passRepeat.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passRepeat.TabIndex = 16;
            this.txtBox_passRepeat.Visible = false;
            this.txtBox_passRepeat.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lbl_enterName
            // 
            this.lbl_enterName.AutoSize = true;
            this.lbl_enterName.Location = new System.Drawing.Point(152, 14);
            this.lbl_enterName.Name = "lbl_enterName";
            this.lbl_enterName.Size = new System.Drawing.Size(87, 13);
            this.lbl_enterName.TabIndex = 12;
            this.lbl_enterName.Text = "Enter your name:";
            // 
            // txtBox_nameEnter
            // 
            this.txtBox_nameEnter.Location = new System.Drawing.Point(264, 9);
            this.txtBox_nameEnter.Name = "txtBox_nameEnter";
            this.txtBox_nameEnter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nameEnter.TabIndex = 15;
            this.txtBox_nameEnter.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lbl_enterPass
            // 
            this.lbl_enterPass.AutoSize = true;
            this.lbl_enterPass.Location = new System.Drawing.Point(152, 38);
            this.lbl_enterPass.Name = "lbl_enterPass";
            this.lbl_enterPass.Size = new System.Drawing.Size(106, 13);
            this.lbl_enterPass.TabIndex = 13;
            this.lbl_enterPass.Text = "Enter your password:";
            // 
            // lbl_repeatPass
            // 
            this.lbl_repeatPass.AutoSize = true;
            this.lbl_repeatPass.Location = new System.Drawing.Point(10, 81);
            this.lbl_repeatPass.Name = "lbl_repeatPass";
            this.lbl_repeatPass.Size = new System.Drawing.Size(116, 13);
            this.lbl_repeatPass.TabIndex = 14;
            this.lbl_repeatPass.Text = "Repeat your password:";
            this.lbl_repeatPass.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(10, 105);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 20;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(433, 158);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.rdb_iHaveAccount);
            this.Controls.Add(this.txtBox_passEnter);
            this.Controls.Add(this.rdb_iDontHaveAccount);
            this.Controls.Add(this.txtBox_passRepeat);
            this.Controls.Add(this.lbl_enterName);
            this.Controls.Add(this.txtBox_nameEnter);
            this.Controls.Add(this.lbl_enterPass);
            this.Controls.Add(this.lbl_repeatPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.RadioButton rdb_iHaveAccount;
        private System.Windows.Forms.TextBox txtBox_passEnter;
        private System.Windows.Forms.RadioButton rdb_iDontHaveAccount;
        private System.Windows.Forms.TextBox txtBox_passRepeat;
        private System.Windows.Forms.Label lbl_enterName;
        private System.Windows.Forms.TextBox txtBox_nameEnter;
        private System.Windows.Forms.Label lbl_enterPass;
        private System.Windows.Forms.Label lbl_repeatPass;
        private System.Windows.Forms.Label lbl_error;
    }
}