namespace DarkOrbit_clicker
{
    partial class MainForm
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
            this.pnlContent = new System.Windows.Forms.Panel();
            this.p_backBarStats = new System.Windows.Forms.Panel();
            this.btn_fscr = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.p_backBarStats.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(90, 0);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1100, 445);
            this.pnlContent.TabIndex = 3;
            // 
            // p_backBarStats
            // 
            this.p_backBarStats.AutoSize = true;
            this.p_backBarStats.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.header_background_02;
            this.p_backBarStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_backBarStats.Controls.Add(this.btn_fscr);
            this.p_backBarStats.Controls.Add(this.btn_exit);
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
            this.p_backBarStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_backBarStats.Location = new System.Drawing.Point(210, 0);
            this.p_backBarStats.Margin = new System.Windows.Forms.Padding(0);
            this.p_backBarStats.Name = "p_backBarStats";
            this.p_backBarStats.Size = new System.Drawing.Size(860, 235);
            this.p_backBarStats.TabIndex = 2;
            // 
            // btn_fscr
            // 
            this.btn_fscr.Location = new System.Drawing.Point(54, 52);
            this.btn_fscr.Name = "btn_fscr";
            this.btn_fscr.Size = new System.Drawing.Size(75, 37);
            this.btn_fscr.TabIndex = 13;
            this.btn_fscr.Text = "Exit Fullscreen";
            this.btn_fscr.UseVisualStyleBackColor = true;
            this.btn_fscr.Visible = false;
            this.btn_fscr.Click += new System.EventHandler(this.btn_fscr_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(54, 24);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Visible = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            this.lbl_uridium.ForeColor = System.Drawing.SystemColors.ControlText;
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
            this.btn_galaxyGates.Location = new System.Drawing.Point(205, 129);
            this.btn_galaxyGates.Name = "btn_galaxyGates";
            this.btn_galaxyGates.Size = new System.Drawing.Size(92, 57);
            this.btn_galaxyGates.TabIndex = 5;
            this.btn_galaxyGates.Text = "GALAXY GATES";
            this.btn_galaxyGates.UseVisualStyleBackColor = true;
            this.btn_galaxyGates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_galaxyGates_MouseClick);
            // 
            // btn_skylab
            // 
            this.btn_skylab.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.main_btn_p;
            this.btn_skylab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_skylab.FlatAppearance.BorderSize = 0;
            this.btn_skylab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_skylab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_skylab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_skylab.ForeColor = System.Drawing.Color.Red;
            this.btn_skylab.Location = new System.Drawing.Point(557, 153);
            this.btn_skylab.Name = "btn_skylab";
            this.btn_skylab.Size = new System.Drawing.Size(107, 33);
            this.btn_skylab.TabIndex = 4;
            this.btn_skylab.Text = "SKYLAB";
            this.btn_skylab.UseVisualStyleBackColor = true;
            // 
            // btn_skillTree
            // 
            this.btn_skillTree.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.main_btn_p;
            this.btn_skillTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_skillTree.FlatAppearance.BorderSize = 0;
            this.btn_skillTree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_skillTree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_skillTree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_skillTree.ForeColor = System.Drawing.Color.Red;
            this.btn_skillTree.Location = new System.Drawing.Point(557, 115);
            this.btn_skillTree.Name = "btn_skillTree";
            this.btn_skillTree.Size = new System.Drawing.Size(111, 32);
            this.btn_skillTree.TabIndex = 3;
            this.btn_skillTree.Text = "SKILL TREE";
            this.btn_skillTree.UseVisualStyleBackColor = true;
            // 
            // btn_hangar
            // 
            this.btn_hangar.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.main_btn_p;
            this.btn_hangar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_hangar.FlatAppearance.BorderSize = 0;
            this.btn_hangar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_hangar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_hangar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hangar.ForeColor = System.Drawing.Color.Red;
            this.btn_hangar.Location = new System.Drawing.Point(682, 115);
            this.btn_hangar.Name = "btn_hangar";
            this.btn_hangar.Size = new System.Drawing.Size(107, 33);
            this.btn_hangar.TabIndex = 1;
            this.btn_hangar.Text = "HANGAR";
            this.btn_hangar.UseVisualStyleBackColor = true;
            this.btn_hangar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_hangar_MouseClick);
            // 
            // btn_shop
            // 
            this.btn_shop.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.main_btn_p;
            this.btn_shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_shop.FlatAppearance.BorderSize = 0;
            this.btn_shop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_shop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_shop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shop.ForeColor = System.Drawing.Color.Red;
            this.btn_shop.Location = new System.Drawing.Point(682, 154);
            this.btn_shop.Name = "btn_shop";
            this.btn_shop.Size = new System.Drawing.Size(107, 32);
            this.btn_shop.TabIndex = 2;
            this.btn_shop.Text = "SHOP";
            this.btn_shop.UseVisualStyleBackColor = true;
            this.btn_shop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_shop_MouseClick);
            // 
            // btn_start
            // 
            this.btn_start.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.spr_START_pass;
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Location = new System.Drawing.Point(333, 129);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(190, 48);
            this.btn_start.TabIndex = 0;
            this.btn_start.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 860F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.p_backBarStats, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 235);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pnlContent, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 235);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1280, 445);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1280, 693);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1100, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Название Окна";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.p_backBarStats.ResumeLayout(false);
            this.p_backBarStats.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_fscr;
    }
}

