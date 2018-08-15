﻿namespace DarkOrbit_clicker
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_backBarStats = new System.Windows.Forms.Panel();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_hon = new System.Windows.Forms.Label();
            this.lbl_exp = new System.Windows.Forms.Label();
            this.lbl_kredits = new System.Windows.Forms.Label();
            this.lbl_uridium = new System.Windows.Forms.Label();
            this.btn_upgrades = new System.Windows.Forms.Button();
            this.btn_galaxyGates = new System.Windows.Forms.Button();
            this.btn_skylab = new System.Windows.Forms.Button();
            this.btn_skillTree = new System.Windows.Forms.Button();
            this.btn_hangar = new System.Windows.Forms.Button();
            this.btn_shop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.p_backBarStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(17, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 425);
            this.panel1.TabIndex = 3;
            // 
            // p_backBarStats
            // 
            this.p_backBarStats.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.header_background_02;
            this.p_backBarStats.Controls.Add(this.lbl_level);
            this.p_backBarStats.Controls.Add(this.lbl_hon);
            this.p_backBarStats.Controls.Add(this.lbl_exp);
            this.p_backBarStats.Controls.Add(this.lbl_kredits);
            this.p_backBarStats.Controls.Add(this.lbl_uridium);
            this.p_backBarStats.Controls.Add(this.btn_upgrades);
            this.p_backBarStats.Controls.Add(this.btn_galaxyGates);
            this.p_backBarStats.Controls.Add(this.btn_skylab);
            this.p_backBarStats.Controls.Add(this.btn_skillTree);
            this.p_backBarStats.Controls.Add(this.btn_hangar);
            this.p_backBarStats.Controls.Add(this.btn_shop);
            this.p_backBarStats.Controls.Add(this.btn_start);
            this.p_backBarStats.Location = new System.Drawing.Point(43, 1);
            this.p_backBarStats.Name = "p_backBarStats";
            this.p_backBarStats.Size = new System.Drawing.Size(860, 233);
            this.p_backBarStats.TabIndex = 2;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.Location = new System.Drawing.Point(229, 4);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(26, 13);
            this.lbl_level.TabIndex = 11;
            this.lbl_level.Text = "LVL";
            // 
            // lbl_hon
            // 
            this.lbl_hon.AutoSize = true;
            this.lbl_hon.Location = new System.Drawing.Point(721, 4);
            this.lbl_hon.Name = "lbl_hon";
            this.lbl_hon.Size = new System.Drawing.Size(31, 13);
            this.lbl_hon.TabIndex = 10;
            this.lbl_hon.Text = "HON";
            // 
            // lbl_exp
            // 
            this.lbl_exp.AutoSize = true;
            this.lbl_exp.Location = new System.Drawing.Point(597, 4);
            this.lbl_exp.Name = "lbl_exp";
            this.lbl_exp.Size = new System.Drawing.Size(28, 13);
            this.lbl_exp.TabIndex = 9;
            this.lbl_exp.Text = "EXP";
            // 
            // lbl_kredits
            // 
            this.lbl_kredits.AutoSize = true;
            this.lbl_kredits.Location = new System.Drawing.Point(705, 209);
            this.lbl_kredits.Name = "lbl_kredits";
            this.lbl_kredits.Size = new System.Drawing.Size(22, 13);
            this.lbl_kredits.TabIndex = 8;
            this.lbl_kredits.Text = "KR";
            // 
            // lbl_uridium
            // 
            this.lbl_uridium.AutoSize = true;
            this.lbl_uridium.Location = new System.Drawing.Point(582, 209);
            this.lbl_uridium.Name = "lbl_uridium";
            this.lbl_uridium.Size = new System.Drawing.Size(26, 13);
            this.lbl_uridium.TabIndex = 7;
            this.lbl_uridium.Text = "URI";
            // 
            // btn_upgrades
            // 
            this.btn_upgrades.Location = new System.Drawing.Point(81, 129);
            this.btn_upgrades.Name = "btn_upgrades";
            this.btn_upgrades.Size = new System.Drawing.Size(93, 57);
            this.btn_upgrades.TabIndex = 6;
            this.btn_upgrades.Text = "UPGRADES";
            this.btn_upgrades.UseVisualStyleBackColor = true;
            // 
            // btn_galaxyGates
            // 
            this.btn_galaxyGates.Location = new System.Drawing.Point(563, 129);
            this.btn_galaxyGates.Name = "btn_galaxyGates";
            this.btn_galaxyGates.Size = new System.Drawing.Size(92, 57);
            this.btn_galaxyGates.TabIndex = 5;
            this.btn_galaxyGates.Text = "GALAXY GATES";
            this.btn_galaxyGates.UseVisualStyleBackColor = true;
            this.btn_galaxyGates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_galaxyGates_MouseClick);
            // 
            // btn_skylab
            // 
            this.btn_skylab.Location = new System.Drawing.Point(90, 95);
            this.btn_skylab.Name = "btn_skylab";
            this.btn_skylab.Size = new System.Drawing.Size(75, 23);
            this.btn_skylab.TabIndex = 4;
            this.btn_skylab.Text = "SKYLAB";
            this.btn_skylab.UseVisualStyleBackColor = true;
            // 
            // btn_skillTree
            // 
            this.btn_skillTree.Location = new System.Drawing.Point(204, 163);
            this.btn_skillTree.Name = "btn_skillTree";
            this.btn_skillTree.Size = new System.Drawing.Size(87, 23);
            this.btn_skillTree.TabIndex = 3;
            this.btn_skillTree.Text = "SKILL TREE";
            this.btn_skillTree.UseVisualStyleBackColor = true;
            // 
            // btn_hangar
            // 
            this.btn_hangar.Location = new System.Drawing.Point(695, 109);
            this.btn_hangar.Name = "btn_hangar";
            this.btn_hangar.Size = new System.Drawing.Size(75, 23);
            this.btn_hangar.TabIndex = 1;
            this.btn_hangar.Text = "HANGAR";
            this.btn_hangar.UseVisualStyleBackColor = true;
            this.btn_hangar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_hangar_MouseClick);
            // 
            // btn_shop
            // 
            this.btn_shop.Location = new System.Drawing.Point(695, 154);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(75, 23);
            this.btn_shop.TabIndex = 2;
            this.btn_shop.Text = "SHOP";
            this.btn_shop.UseVisualStyleBackColor = true;
            this.btn_shop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_shop_MouseClick);
            // 
            // btn_start
            // 
            this.btn_start.Image = global::DarkOrbit_clicker.Properties.Resources.spr_START_pass;
            this.btn_start.Location = new System.Drawing.Point(334, 129);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(190, 48);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1166, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_backBarStats);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Название Окна";
            this.p_backBarStats.ResumeLayout(false);
            this.p_backBarStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_backBarStats;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_hon;
        private System.Windows.Forms.Label lbl_exp;
        private System.Windows.Forms.Label lbl_kredits;
        private System.Windows.Forms.Label lbl_uridium;
        private System.Windows.Forms.Button btn_upgrades;
        private System.Windows.Forms.Button btn_galaxyGates;
        private System.Windows.Forms.Button btn_skylab;
        private System.Windows.Forms.Button btn_skillTree;
        private System.Windows.Forms.Button btn_hangar;
        private System.Windows.Forms.Button btn_shop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel panel1;
    }
}

