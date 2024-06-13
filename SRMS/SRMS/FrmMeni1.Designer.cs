namespace SRMS
{
    partial class FrmMeni1
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
            this.btnNazadMeni1 = new System.Windows.Forms.Button();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNazadMeni1
            // 
            this.btnNazadMeni1.Location = new System.Drawing.Point(12, 12);
            this.btnNazadMeni1.Name = "btnNazadMeni1";
            this.btnNazadMeni1.Size = new System.Drawing.Size(75, 23);
            this.btnNazadMeni1.TabIndex = 0;
            this.btnNazadMeni1.Text = "Nazad";
            this.btnNazadMeni1.UseVisualStyleBackColor = true;
            this.btnNazadMeni1.Click += new System.EventHandler(this.btnNazadMeni1_Click);
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(12, 59);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.RowHeadersWidth = 51;
            this.dgvRecepti.RowTemplate.Height = 24;
            this.dgvRecepti.Size = new System.Drawing.Size(644, 426);
            this.dgvRecepti.TabIndex = 1;
            // 
            // FrmMeni1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.btnNazadMeni1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMeni1";
            this.ShowIcon = false;
            this.Text = "Meni 1";
            this.Load += new System.EventHandler(this.FrmMeni1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNazadMeni1;
        private System.Windows.Forms.DataGridView dgvRecepti;
    }
}