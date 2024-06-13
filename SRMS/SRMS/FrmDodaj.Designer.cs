namespace SRMS
{
    partial class FrmDodaj
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.lblJelo = new System.Windows.Forms.Label();
            this.lblSastojak = new System.Windows.Forms.Label();
            this.txtJelo = new System.Windows.Forms.TextBox();
            this.txtSastojak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(394, 185);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(68, 30);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // lblJelo
            // 
            this.lblJelo.AutoSize = true;
            this.lblJelo.Location = new System.Drawing.Point(80, 70);
            this.lblJelo.Name = "lblJelo";
            this.lblJelo.Size = new System.Drawing.Size(81, 16);
            this.lblJelo.TabIndex = 1;
            this.lblJelo.Text = "Unesite jelo:";
            // 
            // lblSastojak
            // 
            this.lblSastojak.AutoSize = true;
            this.lblSastojak.Location = new System.Drawing.Point(80, 107);
            this.lblSastojak.Name = "lblSastojak";
            this.lblSastojak.Size = new System.Drawing.Size(110, 16);
            this.lblSastojak.TabIndex = 2;
            this.lblSastojak.Text = "Unesite sastojak:";
            // 
            // txtJelo
            // 
            this.txtJelo.Location = new System.Drawing.Point(201, 66);
            this.txtJelo.Name = "txtJelo";
            this.txtJelo.Size = new System.Drawing.Size(199, 22);
            this.txtJelo.TabIndex = 3;
            // 
            // txtSastojak
            // 
            this.txtSastojak.Location = new System.Drawing.Point(201, 104);
            this.txtSastojak.Name = "txtSastojak";
            this.txtSastojak.Size = new System.Drawing.Size(199, 22);
            this.txtSastojak.TabIndex = 4;
            // 
            // FrmDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 220);
            this.Controls.Add(this.txtSastojak);
            this.Controls.Add(this.txtJelo);
            this.Controls.Add(this.lblSastojak);
            this.Controls.Add(this.lblJelo);
            this.Controls.Add(this.btnSpremi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDodaj";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label lblJelo;
        private System.Windows.Forms.Label lblSastojak;
        private System.Windows.Forms.TextBox txtJelo;
        private System.Windows.Forms.TextBox txtSastojak;
    }
}