namespace Mokkivaraus
{
    partial class frmTiedot
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
            this.dgwAsiakas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsiakas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAsiakas
            // 
            this.dgwAsiakas.AllowUserToAddRows = false;
            this.dgwAsiakas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAsiakas.Location = new System.Drawing.Point(12, 12);
            this.dgwAsiakas.Name = "dgwAsiakas";
            this.dgwAsiakas.Size = new System.Drawing.Size(996, 255);
            this.dgwAsiakas.TabIndex = 0;
            // 
            // frmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 466);
            this.Controls.Add(this.dgwAsiakas);
            this.Name = "frmTiedot";
            this.Text = "Tiedot";
            this.Load += new System.EventHandler(this.frmTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsiakas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAsiakas;
    }
}