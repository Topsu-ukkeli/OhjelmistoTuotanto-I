namespace Mokkivaraus
{
    partial class PalveluidenHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PalveluidenHallinta));
            this.dgwPalvelut = new System.Windows.Forms.DataGridView();
            this.tbPalvelunNimi = new System.Windows.Forms.TextBox();
            this.tbPalvelunTyyppi = new System.Windows.Forms.TextBox();
            this.tbPalvelunHinta = new System.Windows.Forms.TextBox();
            this.tbPalvelunKuvaus = new System.Windows.Forms.TextBox();
            this.tbALV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.btnPoistaPalvelu = new System.Windows.Forms.Button();
            this.btnPaivitaPalvelua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwPalvelut
            // 
            this.dgwPalvelut.AllowUserToAddRows = false;
            this.dgwPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPalvelut.Location = new System.Drawing.Point(75, 12);
            this.dgwPalvelut.Name = "dgwPalvelut";
            this.dgwPalvelut.Size = new System.Drawing.Size(822, 293);
            this.dgwPalvelut.TabIndex = 0;
            this.dgwPalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPalvelut_CellClick);
            // 
            // tbPalvelunNimi
            // 
            this.tbPalvelunNimi.Location = new System.Drawing.Point(204, 326);
            this.tbPalvelunNimi.Name = "tbPalvelunNimi";
            this.tbPalvelunNimi.Size = new System.Drawing.Size(179, 20);
            this.tbPalvelunNimi.TabIndex = 1;
            // 
            // tbPalvelunTyyppi
            // 
            this.tbPalvelunTyyppi.Location = new System.Drawing.Point(204, 362);
            this.tbPalvelunTyyppi.Name = "tbPalvelunTyyppi";
            this.tbPalvelunTyyppi.Size = new System.Drawing.Size(179, 20);
            this.tbPalvelunTyyppi.TabIndex = 2;
            // 
            // tbPalvelunHinta
            // 
            this.tbPalvelunHinta.Location = new System.Drawing.Point(204, 438);
            this.tbPalvelunHinta.Name = "tbPalvelunHinta";
            this.tbPalvelunHinta.Size = new System.Drawing.Size(179, 20);
            this.tbPalvelunHinta.TabIndex = 4;
            // 
            // tbPalvelunKuvaus
            // 
            this.tbPalvelunKuvaus.Location = new System.Drawing.Point(204, 401);
            this.tbPalvelunKuvaus.Name = "tbPalvelunKuvaus";
            this.tbPalvelunKuvaus.Size = new System.Drawing.Size(179, 20);
            this.tbPalvelunKuvaus.TabIndex = 3;
            // 
            // tbALV
            // 
            this.tbALV.Location = new System.Drawing.Point(204, 472);
            this.tbALV.Name = "tbALV";
            this.tbALV.Size = new System.Drawing.Size(179, 20);
            this.tbALV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palvelun nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palvelun tyyppi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palvelun kuvaus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palvelun hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ALV %";
            // 
            // cbAlue
            // 
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(527, 323);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(185, 21);
            this.cbAlue.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alueet";
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(769, 438);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(128, 58);
            this.btnLisaa.TabIndex = 13;
            this.btnLisaa.Text = "Lisää uusi palvelu";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(624, 438);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(128, 58);
            this.btnPoistaPalvelu.TabIndex = 14;
            this.btnPoistaPalvelu.Text = "Poista olemassa oleva palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = true;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // btnPaivitaPalvelua
            // 
            this.btnPaivitaPalvelua.Location = new System.Drawing.Point(476, 438);
            this.btnPaivitaPalvelua.Name = "btnPaivitaPalvelua";
            this.btnPaivitaPalvelua.Size = new System.Drawing.Size(128, 58);
            this.btnPaivitaPalvelua.TabIndex = 15;
            this.btnPaivitaPalvelua.Text = "Päivitä palvelun tietoja";
            this.btnPaivitaPalvelua.UseVisualStyleBackColor = true;
            this.btnPaivitaPalvelua.Click += new System.EventHandler(this.btnPaivitaPalvelua_Click);
            // 
            // PalveluidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 529);
            this.Controls.Add(this.btnPaivitaPalvelua);
            this.Controls.Add(this.btnPoistaPalvelu);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAlue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbALV);
            this.Controls.Add(this.tbPalvelunHinta);
            this.Controls.Add(this.tbPalvelunKuvaus);
            this.Controls.Add(this.tbPalvelunTyyppi);
            this.Controls.Add(this.tbPalvelunNimi);
            this.Controls.Add(this.dgwPalvelut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PalveluidenHallinta";
            this.Text = "PalveluidenHallinta";
            this.Load += new System.EventHandler(this.PalveluidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwPalvelut;
        private System.Windows.Forms.TextBox tbPalvelunNimi;
        private System.Windows.Forms.TextBox tbPalvelunTyyppi;
        private System.Windows.Forms.TextBox tbPalvelunHinta;
        private System.Windows.Forms.TextBox tbPalvelunKuvaus;
        private System.Windows.Forms.TextBox tbALV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.Button btnPoistaPalvelu;
        private System.Windows.Forms.Button btnPaivitaPalvelua;
    }
}