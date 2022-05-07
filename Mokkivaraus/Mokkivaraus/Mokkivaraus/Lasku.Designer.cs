namespace Mokkivaraus
{
    partial class frmVaraus
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
            this.dgvVaraus = new System.Windows.Forms.DataGridView();
            this.lblVaraus = new System.Windows.Forms.Label();
            this.cbPaperilasku = new System.Windows.Forms.CheckBox();
            this.cbSpostilasku = new System.Windows.Forms.CheckBox();
            this.btnVahvista = new System.Windows.Forms.Button();
            this.btnPalaa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.AllowUserToAddRows = false;
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(19, 53);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.Size = new System.Drawing.Size(715, 141);
            this.dgvVaraus.TabIndex = 1;
            // 
            // lblVaraus
            // 
            this.lblVaraus.AutoSize = true;
            this.lblVaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblVaraus.Location = new System.Drawing.Point(12, 11);
            this.lblVaraus.Name = "lblVaraus";
            this.lblVaraus.Size = new System.Drawing.Size(208, 39);
            this.lblVaraus.TabIndex = 2;
            this.lblVaraus.Text = "Varaustiedot";
            // 
            // cbPaperilasku
            // 
            this.cbPaperilasku.AutoSize = true;
            this.cbPaperilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaperilasku.Location = new System.Drawing.Point(19, 200);
            this.cbPaperilasku.Name = "cbPaperilasku";
            this.cbPaperilasku.Size = new System.Drawing.Size(133, 29);
            this.cbPaperilasku.TabIndex = 3;
            this.cbPaperilasku.Text = "Paperilasku";
            this.cbPaperilasku.UseVisualStyleBackColor = true;
            // 
            // cbSpostilasku
            // 
            this.cbSpostilasku.AutoSize = true;
            this.cbSpostilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpostilasku.Location = new System.Drawing.Point(19, 235);
            this.cbSpostilasku.Name = "cbSpostilasku";
            this.cbSpostilasku.Size = new System.Drawing.Size(175, 29);
            this.cbSpostilasku.TabIndex = 4;
            this.cbSpostilasku.Text = "Sähköpostilasku";
            this.cbSpostilasku.UseVisualStyleBackColor = true;
            // 
            // btnVahvista
            // 
            this.btnVahvista.Enabled = false;
            this.btnVahvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVahvista.Location = new System.Drawing.Point(764, 397);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(214, 99);
            this.btnVahvista.TabIndex = 5;
            this.btnVahvista.Text = "Vahvista varaus";
            this.btnVahvista.UseVisualStyleBackColor = true;
            // 
            // btnPalaa
            // 
            this.btnPalaa.Enabled = false;
            this.btnPalaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalaa.Location = new System.Drawing.Point(19, 397);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(214, 99);
            this.btnPalaa.TabIndex = 6;
            this.btnPalaa.Text = "Muokkaa varausta";
            this.btnPalaa.UseVisualStyleBackColor = true;
            // 
            // frmVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 508);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnVahvista);
            this.Controls.Add(this.cbSpostilasku);
            this.Controls.Add(this.cbPaperilasku);
            this.Controls.Add(this.lblVaraus);
            this.Controls.Add(this.dgvVaraus);
            this.Name = "frmVaraus";
            this.Text = "Yhteenveto";
            this.Load += new System.EventHandler(this.frmVaraus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraus;
        private System.Windows.Forms.Label lblVaraus;
        private System.Windows.Forms.CheckBox cbPaperilasku;
        private System.Windows.Forms.CheckBox cbSpostilasku;
        private System.Windows.Forms.Button btnVahvista;
        private System.Windows.Forms.Button btnPalaa;
    }
}