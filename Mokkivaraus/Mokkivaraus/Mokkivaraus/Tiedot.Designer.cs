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
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnMokki = new System.Windows.Forms.Button();
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
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(12, 312);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(102, 23);
            this.btnAsiakkaat.TabIndex = 1;
            this.btnAsiakkaat.Text = "Lisää asiakas";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnMokki
            // 
            this.btnMokki.Location = new System.Drawing.Point(120, 312);
            this.btnMokki.Name = "btnMokki";
            this.btnMokki.Size = new System.Drawing.Size(102, 23);
            this.btnMokki.TabIndex = 2;
            this.btnMokki.Text = "Mökkivalintaan";
            this.btnMokki.UseVisualStyleBackColor = true;
            this.btnMokki.Click += new System.EventHandler(this.btnMokki_Click);
            // 
            // frmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 347);
            this.Controls.Add(this.btnMokki);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.dgwAsiakas);
            this.Name = "frmTiedot";
            this.Text = "Tiedot";
            this.Load += new System.EventHandler(this.frmTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsiakas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAsiakas;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnMokki;
    }
}