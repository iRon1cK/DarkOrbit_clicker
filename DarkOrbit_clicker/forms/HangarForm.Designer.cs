namespace DarkOrbit_clicker
{
    partial class HangarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangarForm));
            this.pnl_shipImage = new System.Windows.Forms.Panel();
            this.pbx_shipImage = new System.Windows.Forms.PictureBox();
            this.lbl_shipStats = new System.Windows.Forms.Label();
            this.pnl_equipment = new System.Windows.Forms.Panel();
            this.tbcntrl_equipment = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_laserSlots = new System.Windows.Forms.Label();
            this.lbl_generatoSlots = new System.Windows.Forms.Label();
            this.lbl_extrasSlots = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pbx_droneImage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_petLaserSlots = new System.Windows.Forms.Label();
            this.lbl_ship_6 = new System.Windows.Forms.Button();
            this.lbl_ship_5 = new System.Windows.Forms.Button();
            this.lbl_ship_3 = new System.Windows.Forms.Button();
            this.lbl_ship_2 = new System.Windows.Forms.Button();
            this.lbl_ship_4 = new System.Windows.Forms.Button();
            this.lbl_listOfShips = new System.Windows.Forms.Label();
            this.lbl_ship_1 = new System.Windows.Forms.Button();
            this.lbl_equipment = new System.Windows.Forms.Label();
            this.pnl_ammunition = new System.Windows.Forms.Panel();
            this.lbl_shipAmmunition = new System.Windows.Forms.Label();
            this.lbl_droneSlots = new System.Windows.Forms.Label();
            this.lbl_droneStats = new System.Windows.Forms.Label();
            this.lbl_petProtocolSlots = new System.Windows.Forms.Label();
            this.lbl_petSkillSlots = new System.Windows.Forms.Label();
            this.lbl_equipmentCells = new System.Windows.Forms.Label();
            this.pbx_petImage = new System.Windows.Forms.PictureBox();
            this.lbl_petStats = new System.Windows.Forms.Label();
            this.pnl_shipImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shipImage)).BeginInit();
            this.pnl_equipment.SuspendLayout();
            this.tbcntrl_equipment.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_droneImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnl_ammunition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_petImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_shipImage
            // 
            this.pnl_shipImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_shipImage.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.pnl_shipImage.Controls.Add(this.lbl_petStats);
            this.pnl_shipImage.Controls.Add(this.pbx_petImage);
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
            this.pbx_shipImage.Location = new System.Drawing.Point(22, 15);
            this.pbx_shipImage.Name = "pbx_shipImage";
            this.pbx_shipImage.Size = new System.Drawing.Size(150, 150);
            this.pbx_shipImage.TabIndex = 4;
            this.pbx_shipImage.TabStop = false;
            // 
            // lbl_shipStats
            // 
            this.lbl_shipStats.AutoSize = true;
            this.lbl_shipStats.Location = new System.Drawing.Point(59, 178);
            this.lbl_shipStats.Name = "lbl_shipStats";
            this.lbl_shipStats.Size = new System.Drawing.Size(70, 13);
            this.lbl_shipStats.TabIndex = 3;
            this.lbl_shipStats.Text = "SHIP STATS";
            // 
            // pnl_equipment
            // 
            this.pnl_equipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_equipment.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.pnl_equipment.Controls.Add(this.tbcntrl_equipment);
            this.pnl_equipment.Controls.Add(this.lbl_ship_6);
            this.pnl_equipment.Controls.Add(this.lbl_ship_5);
            this.pnl_equipment.Controls.Add(this.lbl_ship_3);
            this.pnl_equipment.Controls.Add(this.lbl_ship_2);
            this.pnl_equipment.Controls.Add(this.lbl_ship_4);
            this.pnl_equipment.Controls.Add(this.lbl_listOfShips);
            this.pnl_equipment.Controls.Add(this.lbl_ship_1);
            this.pnl_equipment.Controls.Add(this.lbl_equipment);
            this.pnl_equipment.Controls.Add(this.pnl_ammunition);
            this.pnl_equipment.Location = new System.Drawing.Point(230, 12);
            this.pnl_equipment.Name = "pnl_equipment";
            this.pnl_equipment.Size = new System.Drawing.Size(858, 576);
            this.pnl_equipment.TabIndex = 2;
            // 
            // tbcntrl_equipment
            // 
            this.tbcntrl_equipment.Controls.Add(this.tabPage1);
            this.tbcntrl_equipment.Controls.Add(this.tabPage2);
            this.tbcntrl_equipment.Controls.Add(this.tabPage3);
            this.tbcntrl_equipment.Location = new System.Drawing.Point(14, 31);
            this.tbcntrl_equipment.Name = "tbcntrl_equipment";
            this.tbcntrl_equipment.SelectedIndex = 0;
            this.tbcntrl_equipment.Size = new System.Drawing.Size(403, 521);
            this.tbcntrl_equipment.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.tabPage1.Controls.Add(this.lbl_laserSlots);
            this.tabPage1.Controls.Add(this.lbl_generatoSlots);
            this.tabPage1.Controls.Add(this.lbl_extrasSlots);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SHIP";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_laserSlots
            // 
            this.lbl_laserSlots.AutoSize = true;
            this.lbl_laserSlots.Location = new System.Drawing.Point(14, 13);
            this.lbl_laserSlots.Name = "lbl_laserSlots";
            this.lbl_laserSlots.Size = new System.Drawing.Size(80, 13);
            this.lbl_laserSlots.TabIndex = 3;
            this.lbl_laserSlots.Text = "LASER SLOTS";
            // 
            // lbl_generatoSlots
            // 
            this.lbl_generatoSlots.AutoSize = true;
            this.lbl_generatoSlots.Location = new System.Drawing.Point(14, 190);
            this.lbl_generatoSlots.Name = "lbl_generatoSlots";
            this.lbl_generatoSlots.Size = new System.Drawing.Size(113, 13);
            this.lbl_generatoSlots.TabIndex = 4;
            this.lbl_generatoSlots.Text = "GENERATOR SLOTS";
            // 
            // lbl_extrasSlots
            // 
            this.lbl_extrasSlots.AutoSize = true;
            this.lbl_extrasSlots.Location = new System.Drawing.Point(14, 332);
            this.lbl_extrasSlots.Name = "lbl_extrasSlots";
            this.lbl_extrasSlots.Size = new System.Drawing.Size(88, 13);
            this.lbl_extrasSlots.TabIndex = 5;
            this.lbl_extrasSlots.Text = "EXTRAS SLOTS";
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.tabPage2.Controls.Add(this.lbl_droneStats);
            this.tabPage2.Controls.Add(this.lbl_droneSlots);
            this.tabPage2.Controls.Add(this.pbx_droneImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(395, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DRONES";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pbx_droneImage
            // 
            this.pbx_droneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_droneImage.Image = global::DarkOrbit_clicker.Properties.Resources.drone_slot;
            this.pbx_droneImage.Location = new System.Drawing.Point(20, 22);
            this.pbx_droneImage.Name = "pbx_droneImage";
            this.pbx_droneImage.Size = new System.Drawing.Size(68, 69);
            this.pbx_droneImage.TabIndex = 0;
            this.pbx_droneImage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.tabPage3.Controls.Add(this.lbl_petSkillSlots);
            this.tabPage3.Controls.Add(this.lbl_petProtocolSlots);
            this.tabPage3.Controls.Add(this.lbl_petLaserSlots);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(395, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "P.E.T";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbl_petLaserSlots
            // 
            this.lbl_petLaserSlots.AutoSize = true;
            this.lbl_petLaserSlots.Location = new System.Drawing.Point(21, 24);
            this.lbl_petLaserSlots.Name = "lbl_petLaserSlots";
            this.lbl_petLaserSlots.Size = new System.Drawing.Size(104, 13);
            this.lbl_petLaserSlots.TabIndex = 4;
            this.lbl_petLaserSlots.Text = "PET LASER SLOTS";
            // 
            // lbl_ship_6
            // 
            this.lbl_ship_6.Location = new System.Drawing.Point(777, 116);
            this.lbl_ship_6.Name = "lbl_ship_6";
            this.lbl_ship_6.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_6.TabIndex = 11;
            this.lbl_ship_6.Text = "SHIP 6";
            this.lbl_ship_6.UseVisualStyleBackColor = true;
            // 
            // lbl_ship_5
            // 
            this.lbl_ship_5.Location = new System.Drawing.Point(721, 116);
            this.lbl_ship_5.Name = "lbl_ship_5";
            this.lbl_ship_5.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_5.TabIndex = 10;
            this.lbl_ship_5.Text = "SHIP 5";
            this.lbl_ship_5.UseVisualStyleBackColor = true;
            // 
            // lbl_ship_3
            // 
            this.lbl_ship_3.Location = new System.Drawing.Point(777, 56);
            this.lbl_ship_3.Name = "lbl_ship_3";
            this.lbl_ship_3.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_3.TabIndex = 9;
            this.lbl_ship_3.Text = "SHIP 3";
            this.lbl_ship_3.UseVisualStyleBackColor = true;
            // 
            // lbl_ship_2
            // 
            this.lbl_ship_2.Location = new System.Drawing.Point(721, 56);
            this.lbl_ship_2.Name = "lbl_ship_2";
            this.lbl_ship_2.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_2.TabIndex = 8;
            this.lbl_ship_2.Text = "SHIP 2";
            this.lbl_ship_2.UseVisualStyleBackColor = true;
            // 
            // lbl_ship_4
            // 
            this.lbl_ship_4.Location = new System.Drawing.Point(665, 116);
            this.lbl_ship_4.Name = "lbl_ship_4";
            this.lbl_ship_4.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_4.TabIndex = 8;
            this.lbl_ship_4.Text = "SHIP 4";
            this.lbl_ship_4.UseVisualStyleBackColor = true;
            // 
            // lbl_listOfShips
            // 
            this.lbl_listOfShips.AutoSize = true;
            this.lbl_listOfShips.Location = new System.Drawing.Point(716, 15);
            this.lbl_listOfShips.Name = "lbl_listOfShips";
            this.lbl_listOfShips.Size = new System.Drawing.Size(82, 13);
            this.lbl_listOfShips.TabIndex = 7;
            this.lbl_listOfShips.Text = "LIST OF SHIPS";
            // 
            // lbl_ship_1
            // 
            this.lbl_ship_1.Location = new System.Drawing.Point(665, 56);
            this.lbl_ship_1.Name = "lbl_ship_1";
            this.lbl_ship_1.Size = new System.Drawing.Size(50, 54);
            this.lbl_ship_1.TabIndex = 6;
            this.lbl_ship_1.Text = "SHIP 1";
            this.lbl_ship_1.UseVisualStyleBackColor = true;
            // 
            // lbl_equipment
            // 
            this.lbl_equipment.AutoSize = true;
            this.lbl_equipment.Location = new System.Drawing.Point(201, 15);
            this.lbl_equipment.Name = "lbl_equipment";
            this.lbl_equipment.Size = new System.Drawing.Size(71, 13);
            this.lbl_equipment.TabIndex = 2;
            this.lbl_equipment.Text = "EQUIPMENT";
            // 
            // pnl_ammunition
            // 
            this.pnl_ammunition.AllowDrop = true;
            this.pnl_ammunition.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pnl_ammunition.AutoScroll = true;
            this.pnl_ammunition.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.bg_shop;
            this.pnl_ammunition.Controls.Add(this.lbl_equipmentCells);
            this.pnl_ammunition.Controls.Add(this.lbl_shipAmmunition);
            this.pnl_ammunition.Location = new System.Drawing.Point(423, 15);
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
            // lbl_droneSlots
            // 
            this.lbl_droneSlots.AutoSize = true;
            this.lbl_droneSlots.Location = new System.Drawing.Point(109, 22);
            this.lbl_droneSlots.Name = "lbl_droneSlots";
            this.lbl_droneSlots.Size = new System.Drawing.Size(84, 13);
            this.lbl_droneSlots.TabIndex = 4;
            this.lbl_droneSlots.Text = "DRONE SLOTS";
            // 
            // lbl_droneStats
            // 
            this.lbl_droneStats.AutoSize = true;
            this.lbl_droneStats.Location = new System.Drawing.Point(213, 22);
            this.lbl_droneStats.Name = "lbl_droneStats";
            this.lbl_droneStats.Size = new System.Drawing.Size(84, 13);
            this.lbl_droneStats.TabIndex = 5;
            this.lbl_droneStats.Text = "DRONE STATS";
            // 
            // lbl_petProtocolSlots
            // 
            this.lbl_petProtocolSlots.AutoSize = true;
            this.lbl_petProtocolSlots.Location = new System.Drawing.Point(21, 179);
            this.lbl_petProtocolSlots.Name = "lbl_petProtocolSlots";
            this.lbl_petProtocolSlots.Size = new System.Drawing.Size(128, 13);
            this.lbl_petProtocolSlots.TabIndex = 5;
            this.lbl_petProtocolSlots.Text = "PET PROTOCOL SLOTS";
            // 
            // lbl_petSkillSlots
            // 
            this.lbl_petSkillSlots.AutoSize = true;
            this.lbl_petSkillSlots.Location = new System.Drawing.Point(21, 331);
            this.lbl_petSkillSlots.Name = "lbl_petSkillSlots";
            this.lbl_petSkillSlots.Size = new System.Drawing.Size(98, 13);
            this.lbl_petSkillSlots.TabIndex = 6;
            this.lbl_petSkillSlots.Text = "PET SKILL SLOTS";
            // 
            // lbl_equipmentCells
            // 
            this.lbl_equipmentCells.AutoSize = true;
            this.lbl_equipmentCells.Location = new System.Drawing.Point(52, 82);
            this.lbl_equipmentCells.Name = "lbl_equipmentCells";
            this.lbl_equipmentCells.Size = new System.Drawing.Size(107, 13);
            this.lbl_equipmentCells.TabIndex = 4;
            this.lbl_equipmentCells.Text = "EQUIPMENT CELLS";
            // 
            // pbx_petImage
            // 
            this.pbx_petImage.BackColor = System.Drawing.Color.Transparent;
            this.pbx_petImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_petImage.Location = new System.Drawing.Point(22, 286);
            this.pbx_petImage.Name = "pbx_petImage";
            this.pbx_petImage.Size = new System.Drawing.Size(150, 150);
            this.pbx_petImage.TabIndex = 5;
            this.pbx_petImage.TabStop = false;
            // 
            // lbl_petStats
            // 
            this.lbl_petStats.AutoSize = true;
            this.lbl_petStats.Location = new System.Drawing.Point(59, 466);
            this.lbl_petStats.Name = "lbl_petStats";
            this.lbl_petStats.Size = new System.Drawing.Size(66, 13);
            this.lbl_petStats.TabIndex = 6;
            this.lbl_petStats.Text = "PET STATS";
            // 
            // HangarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.pnl_equipment);
            this.Controls.Add(this.pnl_shipImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HangarForm";
            this.Text = "Hangar";
            this.Load += new System.EventHandler(this.Hangar_Load);
            this.pnl_shipImage.ResumeLayout(false);
            this.pnl_shipImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_shipImage)).EndInit();
            this.pnl_equipment.ResumeLayout(false);
            this.pnl_equipment.PerformLayout();
            this.tbcntrl_equipment.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_droneImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnl_ammunition.ResumeLayout(false);
            this.pnl_ammunition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_petImage)).EndInit();
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
        private System.Windows.Forms.TabControl tbcntrl_equipment;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_extrasSlots;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbx_droneImage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button lbl_ship_6;
        private System.Windows.Forms.Button lbl_ship_5;
        private System.Windows.Forms.Button lbl_ship_3;
        private System.Windows.Forms.Button lbl_ship_2;
        private System.Windows.Forms.Button lbl_ship_4;
        private System.Windows.Forms.Label lbl_listOfShips;
        private System.Windows.Forms.Button lbl_ship_1;
        private System.Windows.Forms.Label lbl_petLaserSlots;
        private System.Windows.Forms.Label lbl_petStats;
        private System.Windows.Forms.PictureBox pbx_petImage;
        private System.Windows.Forms.Label lbl_droneStats;
        private System.Windows.Forms.Label lbl_droneSlots;
        private System.Windows.Forms.Label lbl_petSkillSlots;
        private System.Windows.Forms.Label lbl_petProtocolSlots;
        private System.Windows.Forms.Label lbl_equipmentCells;
    }
}