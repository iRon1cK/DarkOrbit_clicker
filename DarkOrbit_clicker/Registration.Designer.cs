namespace DarkOrbit_clicker
{
    partial class Registration
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
            this.iHaveAccount = new System.Windows.Forms.RadioButton();
            this.txtBox_passEnter = new System.Windows.Forms.TextBox();
            this.iDontHaveAccount = new System.Windows.Forms.RadioButton();
            this.txtBox_passRepeat = new System.Windows.Forms.TextBox();
            this.lbl_enterName = new System.Windows.Forms.Label();
            this.txtBox_nameEnter = new System.Windows.Forms.TextBox();
            this.lbl_enterPass = new System.Windows.Forms.Label();
            this.lbl_repeatPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_logIn
            // 
            this.btn_logIn.Location = new System.Drawing.Point(249, 76);
            this.btn_logIn.Name = "btn_logIn";
            this.btn_logIn.Size = new System.Drawing.Size(115, 23);
            this.btn_logIn.TabIndex = 18;
            this.btn_logIn.Text = "LOG IN/REGISTER";
            this.btn_logIn.UseVisualStyleBackColor = true;
            // 
            // iHaveAccount
            // 
            this.iHaveAccount.AutoSize = true;
            this.iHaveAccount.Checked = true;
            this.iHaveAccount.Location = new System.Drawing.Point(13, 10);
            this.iHaveAccount.Name = "iHaveAccount";
            this.iHaveAccount.Size = new System.Drawing.Size(97, 17);
            this.iHaveAccount.TabIndex = 10;
            this.iHaveAccount.TabStop = true;
            this.iHaveAccount.Text = "I have account";
            this.iHaveAccount.UseVisualStyleBackColor = true;
            // 
            // txtBox_passEnter
            // 
            this.txtBox_passEnter.Location = new System.Drawing.Point(264, 34);
            this.txtBox_passEnter.Name = "txtBox_passEnter";
            this.txtBox_passEnter.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passEnter.TabIndex = 17;
            // 
            // iDontHaveAccount
            // 
            this.iDontHaveAccount.AutoSize = true;
            this.iDontHaveAccount.Location = new System.Drawing.Point(13, 34);
            this.iDontHaveAccount.Name = "iDontHaveAccount";
            this.iDontHaveAccount.Size = new System.Drawing.Size(120, 17);
            this.iDontHaveAccount.TabIndex = 11;
            this.iDontHaveAccount.TabStop = true;
            this.iDontHaveAccount.Text = "I need new account";
            this.iDontHaveAccount.UseVisualStyleBackColor = true;
            // 
            // txtBox_passRepeat
            // 
            this.txtBox_passRepeat.Location = new System.Drawing.Point(123, 78);
            this.txtBox_passRepeat.Name = "txtBox_passRepeat";
            this.txtBox_passRepeat.Size = new System.Drawing.Size(100, 20);
            this.txtBox_passRepeat.TabIndex = 16;
            this.txtBox_passRepeat.Visible = false;
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
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 143);
            this.Controls.Add(this.btn_logIn);
            this.Controls.Add(this.iHaveAccount);
            this.Controls.Add(this.txtBox_passEnter);
            this.Controls.Add(this.iDontHaveAccount);
            this.Controls.Add(this.txtBox_passRepeat);
            this.Controls.Add(this.lbl_enterName);
            this.Controls.Add(this.txtBox_nameEnter);
            this.Controls.Add(this.lbl_enterPass);
            this.Controls.Add(this.lbl_repeatPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logIn;
        private System.Windows.Forms.RadioButton iHaveAccount;
        private System.Windows.Forms.TextBox txtBox_passEnter;
        private System.Windows.Forms.RadioButton iDontHaveAccount;
        private System.Windows.Forms.TextBox txtBox_passRepeat;
        private System.Windows.Forms.Label lbl_enterName;
        private System.Windows.Forms.TextBox txtBox_nameEnter;
        private System.Windows.Forms.Label lbl_enterPass;
        private System.Windows.Forms.Label lbl_repeatPass;
    }
}