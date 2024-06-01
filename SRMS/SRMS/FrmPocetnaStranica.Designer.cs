namespace SRMS
{
    partial class FrmPocetnaStranica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPocetnaStranica));
            this.btnRucak = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnVecera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRucak
            // 
            this.btnRucak.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRucak.Location = new System.Drawing.Point(215, 215);
            this.btnRucak.Name = "btnRucak";
            this.btnRucak.Size = new System.Drawing.Size(223, 174);
            this.btnRucak.TabIndex = 0;
            this.btnRucak.Text = "Ručak";
            this.btnRucak.UseVisualStyleBackColor = false;
            this.btnRucak.Click += new System.EventHandler(this.btnRucak_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNarudzbe.Location = new System.Drawing.Point(558, 215);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(223, 174);
            this.btnNarudzbe.TabIndex = 1;
            this.btnNarudzbe.Text = "Narudžbe";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            // 
            // btnVecera
            // 
            this.btnVecera.BackColor = System.Drawing.Color.PaleGreen;
            this.btnVecera.Location = new System.Drawing.Point(918, 215);
            this.btnVecera.Name = "btnVecera";
            this.btnVecera.Size = new System.Drawing.Size(221, 174);
            this.btnVecera.TabIndex = 2;
            this.btnVecera.Text = "Večera";
            this.btnVecera.UseVisualStyleBackColor = false;
            // 
            // FrmPocetnaStranica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1283, 716);
            this.Controls.Add(this.btnVecera);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.btnRucak);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPocetnaStranica";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobro došli u SRMS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRucak;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnVecera;
    }
}