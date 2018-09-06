namespace DarkOrbit_clicker
{
    partial class CorpSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorpSelectForm));
            this.pnl_VRU = new System.Windows.Forms.Panel();
            this.btn_acceptVRU = new System.Windows.Forms.Button();
            this.pnl_EIC = new System.Windows.Forms.Panel();
            this.btn_acceptEIC = new System.Windows.Forms.Button();
            this.pnl_companyDescription = new System.Windows.Forms.Panel();
            this.lbl_companyDescription = new System.Windows.Forms.Label();
            this.pnl_MMO = new System.Windows.Forms.Panel();
            this.btn_acceptMMO = new System.Windows.Forms.Button();
            this.pnl_VRU.SuspendLayout();
            this.pnl_EIC.SuspendLayout();
            this.pnl_companyDescription.SuspendLayout();
            this.pnl_MMO.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_VRU
            // 
            this.pnl_VRU.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_character_vru;
            this.pnl_VRU.Controls.Add(this.btn_acceptVRU);
            this.pnl_VRU.Location = new System.Drawing.Point(504, 12);
            this.pnl_VRU.Name = "pnl_VRU";
            this.pnl_VRU.Size = new System.Drawing.Size(278, 438);
            this.pnl_VRU.TabIndex = 1;
            this.pnl_VRU.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            // 
            // btn_acceptVRU
            // 
            this.btn_acceptVRU.BackColor = System.Drawing.Color.Transparent;
            this.btn_acceptVRU.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.corp_select_P;
            this.btn_acceptVRU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acceptVRU.FlatAppearance.BorderSize = 0;
            this.btn_acceptVRU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptVRU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptVRU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceptVRU.ForeColor = System.Drawing.Color.Red;
            this.btn_acceptVRU.Location = new System.Drawing.Point(46, 370);
            this.btn_acceptVRU.Name = "btn_acceptVRU";
            this.btn_acceptVRU.Size = new System.Drawing.Size(185, 65);
            this.btn_acceptVRU.TabIndex = 1;
            this.btn_acceptVRU.Text = "ACCEPT";
            this.btn_acceptVRU.UseVisualStyleBackColor = false;
            this.btn_acceptVRU.Click += new System.EventHandler(this.btn_acceptCorp_Click);
            // 
            // pnl_EIC
            // 
            this.pnl_EIC.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.Земля;
            this.pnl_EIC.Controls.Add(this.btn_acceptEIC);
            this.pnl_EIC.Location = new System.Drawing.Point(893, 12);
            this.pnl_EIC.Name = "pnl_EIC";
            this.pnl_EIC.Size = new System.Drawing.Size(278, 438);
            this.pnl_EIC.TabIndex = 1;
            this.pnl_EIC.MouseEnter += new System.EventHandler(this.panel3_MouseEnter);
            // 
            // btn_acceptEIC
            // 
            this.btn_acceptEIC.BackColor = System.Drawing.Color.Transparent;
            this.btn_acceptEIC.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.corp_select_P;
            this.btn_acceptEIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acceptEIC.FlatAppearance.BorderSize = 0;
            this.btn_acceptEIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptEIC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptEIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceptEIC.ForeColor = System.Drawing.Color.Red;
            this.btn_acceptEIC.Location = new System.Drawing.Point(48, 370);
            this.btn_acceptEIC.Name = "btn_acceptEIC";
            this.btn_acceptEIC.Size = new System.Drawing.Size(185, 65);
            this.btn_acceptEIC.TabIndex = 2;
            this.btn_acceptEIC.Text = "ACCEPT";
            this.btn_acceptEIC.UseVisualStyleBackColor = false;
            this.btn_acceptEIC.Click += new System.EventHandler(this.btn_acceptCorp_Click);
            // 
            // pnl_companyDescription
            // 
            this.pnl_companyDescription.Controls.Add(this.lbl_companyDescription);
            this.pnl_companyDescription.Location = new System.Drawing.Point(259, 474);
            this.pnl_companyDescription.Name = "pnl_companyDescription";
            this.pnl_companyDescription.Size = new System.Drawing.Size(778, 131);
            this.pnl_companyDescription.TabIndex = 2;
            // 
            // lbl_companyDescription
            // 
            this.lbl_companyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_companyDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_companyDescription.ForeColor = System.Drawing.Color.Red;
            this.lbl_companyDescription.Image = ((System.Drawing.Image)(resources.GetObject("lbl_companyDescription.Image")));
            this.lbl_companyDescription.Location = new System.Drawing.Point(0, 0);
            this.lbl_companyDescription.Name = "lbl_companyDescription";
            this.lbl_companyDescription.Size = new System.Drawing.Size(778, 131);
            this.lbl_companyDescription.TabIndex = 0;
            this.lbl_companyDescription.Text = "COMPANY DESCRIPTION";
            this.lbl_companyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_MMO
            // 
            this.pnl_MMO.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_character_mmo;
            this.pnl_MMO.Controls.Add(this.btn_acceptMMO);
            this.pnl_MMO.Location = new System.Drawing.Point(113, 12);
            this.pnl_MMO.Name = "pnl_MMO";
            this.pnl_MMO.Size = new System.Drawing.Size(278, 438);
            this.pnl_MMO.TabIndex = 0;
            this.pnl_MMO.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // btn_acceptMMO
            // 
            this.btn_acceptMMO.BackColor = System.Drawing.Color.Transparent;
            this.btn_acceptMMO.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.corp_select_P;
            this.btn_acceptMMO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acceptMMO.FlatAppearance.BorderSize = 0;
            this.btn_acceptMMO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptMMO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_acceptMMO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceptMMO.ForeColor = System.Drawing.Color.Red;
            this.btn_acceptMMO.Location = new System.Drawing.Point(46, 370);
            this.btn_acceptMMO.Name = "btn_acceptMMO";
            this.btn_acceptMMO.Size = new System.Drawing.Size(185, 65);
            this.btn_acceptMMO.TabIndex = 0;
            this.btn_acceptMMO.Text = "ACCEPT";
            this.btn_acceptMMO.UseVisualStyleBackColor = false;
            this.btn_acceptMMO.Click += new System.EventHandler(this.btn_acceptCorp_Click);
            // 
            // CorpSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.Выбор_компании_фон;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.pnl_companyDescription);
            this.Controls.Add(this.pnl_EIC);
            this.Controls.Add(this.pnl_VRU);
            this.Controls.Add(this.pnl_MMO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CorpSelectForm";
            this.RightToLeftLayout = true;
            this.Text = "CorpSelection";
            this.pnl_VRU.ResumeLayout(false);
            this.pnl_EIC.ResumeLayout(false);
            this.pnl_companyDescription.ResumeLayout(false);
            this.pnl_MMO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_MMO;
        private System.Windows.Forms.Button btn_acceptMMO;
        private System.Windows.Forms.Panel pnl_VRU;
        private System.Windows.Forms.Panel pnl_EIC;
        private System.Windows.Forms.Button btn_acceptVRU;
        private System.Windows.Forms.Button btn_acceptEIC;
        private System.Windows.Forms.Panel pnl_companyDescription;
        private System.Windows.Forms.Label lbl_companyDescription;
    }
}