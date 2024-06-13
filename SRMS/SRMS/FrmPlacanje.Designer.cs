namespace SRMS
{
    partial class FrmPlacanje
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
            this.lblImePrez = new System.Windows.Forms.Label();
            this.txtImePrez = new System.Windows.Forms.TextBox();
            this.lblBrojKartice = new System.Windows.Forms.Label();
            this.lblDatumIsteka = new System.Windows.Forms.Label();
            this.lblCVC = new System.Windows.Forms.Label();
            this.txtBrojKartice = new System.Windows.Forms.TextBox();
            this.txtDatumIsteka = new System.Windows.Forms.TextBox();
            this.txtCVC = new System.Windows.Forms.TextBox();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnNazadPlacanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblImePrez
            // 
            this.lblImePrez.AutoSize = true;
            this.lblImePrez.Location = new System.Drawing.Point(147, 57);
            this.lblImePrez.Name = "lblImePrez";
            this.lblImePrez.Size = new System.Drawing.Size(87, 16);
            this.lblImePrez.TabIndex = 0;
            this.lblImePrez.Text = "Ime i Prezime";
            // 
            // txtImePrez
            // 
            this.txtImePrez.Location = new System.Drawing.Point(150, 76);
            this.txtImePrez.Name = "txtImePrez";
            this.txtImePrez.Size = new System.Drawing.Size(252, 22);
            this.txtImePrez.TabIndex = 1;
            // 
            // lblBrojKartice
            // 
            this.lblBrojKartice.AutoSize = true;
            this.lblBrojKartice.Location = new System.Drawing.Point(147, 132);
            this.lblBrojKartice.Name = "lblBrojKartice";
            this.lblBrojKartice.Size = new System.Drawing.Size(75, 16);
            this.lblBrojKartice.TabIndex = 2;
            this.lblBrojKartice.Text = "Broj Kartice";
            // 
            // lblDatumIsteka
            // 
            this.lblDatumIsteka.AutoSize = true;
            this.lblDatumIsteka.Location = new System.Drawing.Point(147, 206);
            this.lblDatumIsteka.Name = "lblDatumIsteka";
            this.lblDatumIsteka.Size = new System.Drawing.Size(128, 16);
            this.lblDatumIsteka.TabIndex = 3;
            this.lblDatumIsteka.Text = "Datum isteka kartice";
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(147, 270);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.Size = new System.Drawing.Size(34, 16);
            this.lblCVC.TabIndex = 4;
            this.lblCVC.Text = "CVC";
            // 
            // txtBrojKartice
            // 
            this.txtBrojKartice.Location = new System.Drawing.Point(150, 151);
            this.txtBrojKartice.Name = "txtBrojKartice";
            this.txtBrojKartice.Size = new System.Drawing.Size(252, 22);
            this.txtBrojKartice.TabIndex = 5;
            // 
            // txtDatumIsteka
            // 
            this.txtDatumIsteka.Location = new System.Drawing.Point(150, 225);
            this.txtDatumIsteka.Name = "txtDatumIsteka";
            this.txtDatumIsteka.Size = new System.Drawing.Size(162, 22);
            this.txtDatumIsteka.TabIndex = 6;
            // 
            // txtCVC
            // 
            this.txtCVC.Location = new System.Drawing.Point(150, 289);
            this.txtCVC.Name = "txtCVC";
            this.txtCVC.Size = new System.Drawing.Size(61, 22);
            this.txtCVC.TabIndex = 7;
            // 
            // btnNastavi
            // 
            this.btnNastavi.Location = new System.Drawing.Point(437, 327);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(75, 23);
            this.btnNastavi.TabIndex = 8;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // btnNazadPlacanje
            // 
            this.btnNazadPlacanje.Location = new System.Drawing.Point(26, 13);
            this.btnNazadPlacanje.Name = "btnNazadPlacanje";
            this.btnNazadPlacanje.Size = new System.Drawing.Size(75, 23);
            this.btnNazadPlacanje.TabIndex = 9;
            this.btnNazadPlacanje.Text = "Nazad";
            this.btnNazadPlacanje.UseVisualStyleBackColor = true;
            this.btnNazadPlacanje.Click += new System.EventHandler(this.btnNazadPlacanje_Click);
            // 
            // FrmPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 383);
            this.Controls.Add(this.btnNazadPlacanje);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.txtCVC);
            this.Controls.Add(this.txtDatumIsteka);
            this.Controls.Add(this.txtBrojKartice);
            this.Controls.Add(this.lblCVC);
            this.Controls.Add(this.lblDatumIsteka);
            this.Controls.Add(this.lblBrojKartice);
            this.Controls.Add(this.txtImePrez);
            this.Controls.Add(this.lblImePrez);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlacanje";
            this.ShowIcon = false;
            this.Text = "Plaćanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePrez;
        private System.Windows.Forms.TextBox txtImePrez;
        private System.Windows.Forms.Label lblBrojKartice;
        private System.Windows.Forms.Label lblDatumIsteka;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.TextBox txtBrojKartice;
        private System.Windows.Forms.TextBox txtDatumIsteka;
        private System.Windows.Forms.TextBox txtCVC;
        private System.Windows.Forms.Button btnNastavi;
        private System.Windows.Forms.Button btnNazadPlacanje;
    }
}