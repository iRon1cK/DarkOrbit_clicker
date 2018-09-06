namespace DarkOrbit_clicker
{
    partial class RegistrationForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_logIn.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.button_login;
            this.btn_logIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logIn.Enabled = false;
            this.btn_logIn.FlatAppearance.BorderSize = 0;
            this.btn_logIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_logIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_logIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logIn.Location = new System.Drawing.Point(434, 284);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(127, 34);
            this.btn_logIn.TabIndex = 6;
            this.btn_logIn.Text = "LOG IN";
            this.btn_logIn.UseVisualStyleBackColor = false;
            this.btn_logIn.Click += new System.EventHandler(this.btn_logIn_Click);
            // 
            // rdb_iHaveAccount
            // 
            this.rdb_iHaveAccount.AutoSize = true;
            this.rdb_iHaveAccount.Checked = true;
            this.rdb_iHaveAccount.Location = new System.Drawing.Point(434, 239);
            this.rdb_iHaveAccount.Name = "rdb_iHaveAccount";
            this.rdb_iHaveAccount.Size = new System.Drawing.Size(97, 17);
            this.rdb_iHaveAccount.TabIndex = 1;
            this.rdb_iHaveAccount.TabStop = true;
            this.rdb_iHaveAccount.Text = "I have account";
            this.rdb_iHaveAccount.UseVisualStyleBackColor = true;
            this.rdb_iHaveAccount.CheckedChanged += new System.EventHandler(this.haveOrDontHaveAccount_CheckedChanged);
            // 
            // txtBox_passEnter
            // 
            this.txtBox_passEnter.Location = new System.Drawing.Point(497, 349);
            this.txtBox_passEnter.Name = "txtBox_passEnter";
            this.txtBox_passEnter.PasswordChar = '•';
            this.txtBox_passEnter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passEnter.TabIndex = 4;
            this.txtBox_passEnter.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // rdb_iDontHaveAccount
            // 
            this.rdb_iDontHaveAccount.AutoSize = true;
            this.rdb_iDontHaveAccount.Location = new System.Drawing.Point(434, 262);
            this.rdb_iDontHaveAccount.Name = "rdb_iDontHaveAccount";
            this.rdb_iDontHaveAccount.Size = new System.Drawing.Size(120, 17);
            this.rdb_iDontHaveAccount.TabIndex = 2;
            this.rdb_iDontHaveAccount.TabStop = true;
            this.rdb_iDontHaveAccount.Text = "I need new account";
            this.rdb_iDontHaveAccount.UseVisualStyleBackColor = true;
            this.rdb_iDontHaveAccount.CheckedChanged += new System.EventHandler(this.haveOrDontHaveAccount_CheckedChanged);
            // 
            // txtBox_passRepeat
            // 
            this.txtBox_passRepeat.BackColor = System.Drawing.Color.White;
            this.txtBox_passRepeat.Location = new System.Drawing.Point(497, 375);
            this.txtBox_passRepeat.Name = "txtBox_passRepeat";
            this.txtBox_passRepeat.PasswordChar = '•';
            this.txtBox_passRepeat.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passRepeat.TabIndex = 5;
            this.txtBox_passRepeat.Visible = false;
            this.txtBox_passRepeat.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lbl_enterName
            // 
            this.lbl_enterName.AutoSize = true;
            this.lbl_enterName.Location = new System.Drawing.Point(386, 327);
            this.lbl_enterName.Name = "lbl_enterName";
            this.lbl_enterName.Size = new System.Drawing.Size(87, 13);
            this.lbl_enterName.TabIndex = 12;
            this.lbl_enterName.Text = "Enter your name:";
            // 
            // txtBox_nameEnter
            // 
            this.txtBox_nameEnter.BackColor = System.Drawing.SystemColors.Window;
            this.txtBox_nameEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBox_nameEnter.Location = new System.Drawing.Point(497, 324);
            this.txtBox_nameEnter.Name = "txtBox_nameEnter";
            this.txtBox_nameEnter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_nameEnter.TabIndex = 3;
            this.txtBox_nameEnter.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // lbl_enterPass
            // 
            this.lbl_enterPass.AutoSize = true;
            this.lbl_enterPass.Location = new System.Drawing.Point(367, 352);
            this.lbl_enterPass.Name = "lbl_enterPass";
            this.lbl_enterPass.Size = new System.Drawing.Size(106, 13);
            this.lbl_enterPass.TabIndex = 13;
            this.lbl_enterPass.Text = "Enter your password:";
            // 
            // lbl_repeatPass
            // 
            this.lbl_repeatPass.AutoSize = true;
            this.lbl_repeatPass.Location = new System.Drawing.Point(357, 378);
            this.lbl_repeatPass.Name = "lbl_repeatPass";
            this.lbl_repeatPass.Size = new System.Drawing.Size(116, 13);
            this.lbl_repeatPass.TabIndex = 14;
            this.lbl_repeatPass.Text = "Repeat your password:";
            this.lbl_repeatPass.Visible = false;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(386, 414);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_register1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(-13, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1002, 185);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_register0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 505);
            this.Controls.Add(this.pictureBox1);
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
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(993, 530);
            this.Name = "RegistrationForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeftLayout = true;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}