namespace DarkOrbit_clicker
{
    partial class GalaxyGates
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
            this.btn_useGG = new System.Windows.Forms.Button();
            this.btn_alpha = new System.Windows.Forms.Button();
            this.btn_betta = new System.Windows.Forms.Button();
            this.btn_gamma = new System.Windows.Forms.Button();
            this.pnl_back_barGG = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_useGG
            // 
            this.btn_useGG.Location = new System.Drawing.Point(749, 163);
            this.btn_useGG.Name = "btn_useGG";
            this.btn_useGG.Size = new System.Drawing.Size(75, 23);
            this.btn_useGG.TabIndex = 2;
            this.btn_useGG.Text = "USE GG";
            this.btn_useGG.UseVisualStyleBackColor = true;
            // 
            // btn_alpha
            // 
            this.btn_alpha.Location = new System.Drawing.Point(33, 12);
            this.btn_alpha.Name = "btn_alpha";
            this.btn_alpha.Size = new System.Drawing.Size(75, 23);
            this.btn_alpha.TabIndex = 3;
            this.btn_alpha.Text = "ALPHA";
            this.btn_alpha.UseVisualStyleBackColor = true;
            // 
            // btn_betta
            // 
            this.btn_betta.Location = new System.Drawing.Point(33, 45);
            this.btn_betta.Name = "btn_betta";
            this.btn_betta.Size = new System.Drawing.Size(75, 23);
            this.btn_betta.TabIndex = 3;
            this.btn_betta.Text = "BETTA";
            this.btn_betta.UseVisualStyleBackColor = true;
            // 
            // btn_gamma
            // 
            this.btn_gamma.Location = new System.Drawing.Point(33, 74);
            this.btn_gamma.Name = "btn_gamma";
            this.btn_gamma.Size = new System.Drawing.Size(75, 23);
            this.btn_gamma.TabIndex = 3;
            this.btn_gamma.Text = "GAMMA";
            this.btn_gamma.UseVisualStyleBackColor = true;
            // 
            // pnl_back_barGG
            // 
            this.pnl_back_barGG.Location = new System.Drawing.Point(237, 12);
            this.pnl_back_barGG.Name = "pnl_back_barGG";
            this.pnl_back_barGG.Size = new System.Drawing.Size(450, 390);
            this.pnl_back_barGG.TabIndex = 4;
            // 
            // GalaxyGates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DarkOrbit_clicker.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(895, 425);
            this.Controls.Add(this.pnl_back_barGG);
            this.Controls.Add(this.btn_gamma);
            this.Controls.Add(this.btn_betta);
            this.Controls.Add(this.btn_alpha);
            this.Controls.Add(this.btn_useGG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GalaxyGates";
            this.Text = "GalaxyGates";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_useGG;
        private System.Windows.Forms.Button btn_alpha;
        private System.Windows.Forms.Button btn_betta;
        private System.Windows.Forms.Button btn_gamma;
        private System.Windows.Forms.Panel pnl_back_barGG;
    }
}