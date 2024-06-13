namespace SRMS
{
    partial class FrmPotvrda
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
            this.btnNazadPotvrda = new System.Windows.Forms.Button();
            this.lblUspjesnoPlaceno = new System.Windows.Forms.Label();
            this.lblPriprema = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNazadPotvrda
            // 
            this.btnNazadPotvrda.Location = new System.Drawing.Point(12, 12);
            this.btnNazadPotvrda.Name = "btnNazadPotvrda";
            this.btnNazadPotvrda.Size = new System.Drawing.Size(75, 23);
            this.btnNazadPotvrda.TabIndex = 0;
            this.btnNazadPotvrda.Text = "Nazad";
            this.btnNazadPotvrda.UseVisualStyleBackColor = true;
            this.btnNazadPotvrda.Click += new System.EventHandler(this.btnNazadPotvrda_Click);
            // 
            // lblUspjesnoPlaceno
            // 
            this.lblUspjesnoPlaceno.AutoSize = true;
            this.lblUspjesnoPlaceno.Location = new System.Drawing.Point(118, 58);
            this.lblUspjesnoPlaceno.Name = "lblUspjesnoPlaceno";
            this.lblUspjesnoPlaceno.Size = new System.Drawing.Size(146, 16);
            this.lblUspjesnoPlaceno.TabIndex = 1;
            this.lblUspjesnoPlaceno.Text = "USPJEŠNO PLAĆENO";
            // 
            // lblPriprema
            // 
            this.lblPriprema.AutoSize = true;
            this.lblPriprema.Location = new System.Drawing.Point(133, 91);
            this.lblPriprema.Name = "lblPriprema";
            this.lblPriprema.Size = new System.Drawing.Size(131, 16);
            this.lblPriprema.TabIndex = 2;
            this.lblPriprema.Text = "Narudžba u pripremi!";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(144, 129);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(85, 16);
            this.lblCijena.TabIndex = 3;
            this.lblCijena.Text = "Cijena:  086.€";
            // 
            // FrmPotvrda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 184);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblPriprema);
            this.Controls.Add(this.lblUspjesnoPlaceno);
            this.Controls.Add(this.btnNazadPotvrda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPotvrda";
            this.ShowIcon = false;
            this.Text = "Potvrda narudžbe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazadPotvrda;
        private System.Windows.Forms.Label lblUspjesnoPlaceno;
        private System.Windows.Forms.Label lblPriprema;
        private System.Windows.Forms.Label lblCijena;
    }
}