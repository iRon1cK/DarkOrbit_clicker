namespace DarkOrbit_clicker
{
    partial class Hangar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangar));
            this.pnl_shipImage = new System.Windows.Forms.Panel();
            this.pbx_shipImage = new System.Windows.Forms.PictureBox();
            this.lbl_shipStats = new System.Windows.Forms.Label();
            this.pnl_equipment = new System.Windows.Forms.Panel();
            this.lbl_generatoSlots = new System.Windows.Forms.Label();
            this.lbl_laserSlots = new System.Windows.Forms.Label();
            this.lbl_equipment = new System.Windows.Forms.Label();
            this.pnl_ammunition = new System.Windows.Forms.Panel();
            this.lbl_shipAmmunition = new System.Windows.Forms.Label();
            this.pnl_shipImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shipImage)).BeginInit();
            this.pnl_equipment.SuspendLayout();
            this.pnl_ammunition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_shipImage
            // 
            this.pnl_shipImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_shipImage.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.pnl_shipImage.Controls.Add(this.pbx_shipImage);
            this.pnl_shipImage.Controls.Add(this.lbl_shipStats);
            this.pnl_shipImage.Location = new System.Drawing.Point(12, 12);
            this.pnl_shipImage.Name = "pnl_shipImage";
            this.pnl_shipImage.Size = new System.Drawing.Size(195, 576);
            this.pnl_shipImage.TabIndex = 1;
            // 
            // pbx_shipImage
            // 
            this.pbx_shipImage.BackColor = System.Drawing.Color.Transparent;
            this.pbx_shipImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_shipImage.Location = new System.Drawing.Point(23, 56);
            this.pbx_shipImage.Name = "pbx_shipImage";
            this.pbx_shipImage.Size = new System.Drawing.Size(150, 150);
            this.pbx_shipImage.TabIndex = 4;
            this.pbx_shipImage.TabStop = false;
            // 
            // lbl_shipStats
            // 
            this.lbl_shipStats.AutoSize = true;
            this.lbl_shipStats.Location = new System.Drawing.Point(52, 245);
            this.lbl_shipStats.Name = "lbl_shipStats";
            this.lbl_shipStats.Size = new System.Drawing.Size(73, 13);
            this.lbl_shipStats.TabIndex = 3;
            this.lbl_shipStats.Text = "SHIP_STATS";
            // 
            // pnl_equipment
            // 
            this.pnl_equipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_equipment.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.pnl_equipment.Controls.Add(this.lbl_generatoSlots);
            this.pnl_equipment.Controls.Add(this.lbl_laserSlots);
            this.pnl_equipment.Controls.Add(this.lbl_equipment);
            this.pnl_equipment.Controls.Add(this.pnl_ammunition);
            this.pnl_equipment.Location = new System.Drawing.Point(230, 12);
            this.pnl_equipment.Name = "pnl_equipment";
            this.pnl_equipment.Size = new System.Drawing.Size(858, 576);
            this.pnl_equipment.TabIndex = 2;
            // 
            // lbl_generatoSlots
            // 
            this.lbl_generatoSlots.AutoSize = true;
            this.lbl_generatoSlots.Location = new System.Drawing.Point(29, 271);
            this.lbl_generatoSlots.Name = "lbl_generatoSlots";
            this.lbl_generatoSlots.Size = new System.Drawing.Size(116, 13);
            this.lbl_generatoSlots.TabIndex = 4;
            this.lbl_generatoSlots.Text = "GENERATOR_SLOTS";
            // 
            // lbl_laserSlots
            // 
            this.lbl_laserSlots.AutoSize = true;
            this.lbl_laserSlots.Location = new System.Drawing.Point(38, 56);
            this.lbl_laserSlots.Name = "lbl_laserSlots";
            this.lbl_laserSlots.Size = new System.Drawing.Size(83, 13);
            this.lbl_laserSlots.TabIndex = 3;
            this.lbl_laserSlots.Text = "LASER_SLOTS";
            // 
            // lbl_equipment
            // 
            this.lbl_equipment.AutoSize = true;
            this.lbl_equipment.Location = new System.Drawing.Point(280, 15);
            this.lbl_equipment.Name = "lbl_equipment";
            this.lbl_equipment.Size = new System.Drawing.Size(71, 13);
            this.lbl_equipment.TabIndex = 2;
            this.lbl_equipment.Text = "EQUIPMENT";
            // 
            // pnl_ammunition
            // 
            this.pnl_ammunition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_ammunition.Controls.Add(this.lbl_shipAmmunition);
            this.pnl_ammunition.Location = new System.Drawing.Point(618, 15);
            this.pnl_ammunition.Name = "pnl_ammunition";
            this.pnl_ammunition.Size = new System.Drawing.Size(223, 537);
            this.pnl_ammunition.TabIndex = 1;
            // 
            // lbl_shipAmmunition
            // 
            this.lbl_shipAmmunition.AutoSize = true;
            this.lbl_shipAmmunition.Location = new System.Drawing.Point(51, 41);
            this.lbl_shipAmmunition.Name = "lbl_shipAmmunition";
            this.lbl_shipAmmunition.Size = new System.Drawing.Size(108, 13);
            this.lbl_shipAmmunition.TabIndex = 0;
            this.lbl_shipAmmunition.Text = "SHIP_AMMUNITION";
            // 
            // Hangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnl_equipment);
            this.Controls.Add(this.pnl_shipImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hangar";
            this.Text = "Hangar";
            this.Load += new System.EventHandler(this.Hangar_Load);
            this.pnl_shipImage.ResumeLayout(false);
            this.pnl_shipImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shipImage)).EndInit();
            this.pnl_equipment.ResumeLayout(false);
            this.pnl_equipment.PerformLayout();
            this.pnl_ammunition.ResumeLayout(false);
            this.pnl_ammunition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_shipImage;
        private System.Windows.Forms.Label lbl_shipStats;
        private System.Windows.Forms.Panel pnl_equipment;
        private System.Windows.Forms.Label lbl_generatoSlots;
        private System.Windows.Forms.Label lbl_laserSlots;
        private System.Windows.Forms.Label lbl_equipment;
        private System.Windows.Forms.Panel pnl_ammunition;
        private System.Windows.Forms.Label lbl_shipAmmunition;
        private System.Windows.Forms.PictureBox pbx_shipImage;
    }
}