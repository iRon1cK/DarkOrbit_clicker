namespace DatabaseEditor
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
            this.lbDb = new System.Windows.Forms.Label();
            this.txbDbPath = new System.Windows.Forms.TextBox();
            this.btnSelectDb = new System.Windows.Forms.Button();
            this.lbxListTypes = new System.Windows.Forms.ListBox();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlItemDetails = new System.Windows.Forms.Panel();
            this.flpDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.cbxCreateTypeSelection = new System.Windows.Forms.ComboBox();
            this.pnlItems.SuspendLayout();
            this.pnlItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDb
            // 
            this.lbDb.AutoSize = true;
            this.lbDb.Location = new System.Drawing.Point(12, 9);
            this.lbDb.Name = "lbDb";
            this.lbDb.Size = new System.Drawing.Size(56, 13);
            this.lbDb.TabIndex = 0;
            this.lbDb.Text = "Database:";
            // 
            // txbDbPath
            // 
            this.txbDbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbDbPath.BackColor = System.Drawing.Color.White;
            this.txbDbPath.Location = new System.Drawing.Point(74, 6);
            this.txbDbPath.Name = "txbDbPath";
            this.txbDbPath.ReadOnly = true;
            this.txbDbPath.Size = new System.Drawing.Size(836, 20);
            this.txbDbPath.TabIndex = 1;
            // 
            // btnSelectDb
            // 
            this.btnSelectDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDb.Location = new System.Drawing.Point(916, 3);
            this.btnSelectDb.Name = "btnSelectDb";
            this.btnSelectDb.Size = new System.Drawing.Size(98, 23);
            this.btnSelectDb.TabIndex = 2;
            this.btnSelectDb.Text = "Select Database";
            this.btnSelectDb.UseVisualStyleBackColor = true;
            this.btnSelectDb.Click += new System.EventHandler(this.btnSelectDb_Click);
            // 
            // lbxListTypes
            // 
            this.lbxListTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxListTypes.FormattingEnabled = true;
            this.lbxListTypes.Location = new System.Drawing.Point(15, 32);
            this.lbxListTypes.Name = "lbxListTypes";
            this.lbxListTypes.Size = new System.Drawing.Size(164, 498);
            this.lbxListTypes.TabIndex = 3;
            this.lbxListTypes.SelectedIndexChanged += new System.EventHandler(this.lbxListTypes_SelectedIndexChanged);
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.AutoScroll = true;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.flpItems);
            this.pnlItems.Location = new System.Drawing.Point(185, 32);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(688, 552);
            this.pnlItems.TabIndex = 4;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(0, 0);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(686, 550);
            this.flpItems.TabIndex = 5;
            // 
            // pnlItemDetails
            // 
            this.pnlItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItemDetails.AutoScroll = true;
            this.pnlItemDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItemDetails.Controls.Add(this.flpDetails);
            this.pnlItemDetails.Location = new System.Drawing.Point(879, 32);
            this.pnlItemDetails.Name = "pnlItemDetails";
            this.pnlItemDetails.Size = new System.Drawing.Size(216, 552);
            this.pnlItemDetails.TabIndex = 0;
            // 
            // flpDetails
            // 
            this.flpDetails.AutoScroll = true;
            this.flpDetails.BackColor = System.Drawing.SystemColors.Control;
            this.flpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDetails.Location = new System.Drawing.Point(0, 0);
            this.flpDetails.Name = "flpDetails";
            this.flpDetails.Size = new System.Drawing.Size(214, 550);
            this.flpDetails.TabIndex = 6;
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToDB.Location = new System.Drawing.Point(1020, 3);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToDB.TabIndex = 5;
            this.btnSaveToDB.Text = "Save";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateDB.Location = new System.Drawing.Point(16, 536);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(164, 23);
            this.btnCreateDB.TabIndex = 6;
            this.btnCreateDB.Text = "Create new...";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.btnCreateDB_Click);
            // 
            // cbxCreateTypeSelection
            // 
            this.cbxCreateTypeSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxCreateTypeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCreateTypeSelection.FormattingEnabled = true;
            this.cbxCreateTypeSelection.Items.AddRange(new object[] {
            "Game Database",
            "User save file"});
            this.cbxCreateTypeSelection.Location = new System.Drawing.Point(16, 562);
            this.cbxCreateTypeSelection.Name = "cbxCreateTypeSelection";
            this.cbxCreateTypeSelection.Size = new System.Drawing.Size(163, 21);
            this.cbxCreateTypeSelection.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 595);
            this.Controls.Add(this.cbxCreateTypeSelection);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnSaveToDB);
            this.Controls.Add(this.pnlItemDetails);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.lbxListTypes);
            this.Controls.Add(this.btnSelectDb);
            this.Controls.Add(this.txbDbPath);
            this.Controls.Add(this.lbDb);
            this.MinimumSize = new System.Drawing.Size(600, 254);
            this.Name = "MainForm";
            this.Text = "DatabaseEditor";
            this.pnlItems.ResumeLayout(false);
            this.pnlItemDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDb;
        private System.Windows.Forms.TextBox txbDbPath;
        private System.Windows.Forms.Button btnSelectDb;
        private System.Windows.Forms.ListBox lbxListTypes;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemDetails;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.FlowLayoutPanel flpDetails;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.ComboBox cbxCreateTypeSelection;
    }
}

