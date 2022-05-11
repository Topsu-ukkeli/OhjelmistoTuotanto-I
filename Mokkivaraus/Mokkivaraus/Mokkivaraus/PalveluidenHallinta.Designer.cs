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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwPalvelut
            // 
            this.dgwPalvelut.AllowUserToAddRows = false;
            this.dgwPalvelut.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPalvelut.Location = new System.Drawing.Point(12, 12);
            this.dgwPalvelut.Name = "dgwPalvelut";
            this.dgwPalvelut.Size = new System.Drawing.Size(799, 293);
            this.dgwPalvelut.TabIndex = 0;
            this.dgwPalvelut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPalvelut_CellClick);
            // 
            // tbPalvelunNimi
            // 
            this.tbPalvelunNimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalvelunNimi.Location = new System.Drawing.Point(176, 326);
            this.tbPalvelunNimi.Name = "tbPalvelunNimi";
            this.tbPalvelunNimi.Size = new System.Drawing.Size(179, 29);
            this.tbPalvelunNimi.TabIndex = 1;
            // 
            // tbPalvelunTyyppi
            // 
            this.tbPalvelunTyyppi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalvelunTyyppi.Location = new System.Drawing.Point(176, 362);
            this.tbPalvelunTyyppi.Name = "tbPalvelunTyyppi";
            this.tbPalvelunTyyppi.Size = new System.Drawing.Size(179, 29);
            this.tbPalvelunTyyppi.TabIndex = 2;
            // 
            // tbPalvelunHinta
            // 
            this.tbPalvelunHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalvelunHinta.Location = new System.Drawing.Point(176, 432);
            this.tbPalvelunHinta.Name = "tbPalvelunHinta";
            this.tbPalvelunHinta.Size = new System.Drawing.Size(179, 29);
            this.tbPalvelunHinta.TabIndex = 4;
            // 
            // tbPalvelunKuvaus
            // 
            this.tbPalvelunKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPalvelunKuvaus.Location = new System.Drawing.Point(177, 397);
            this.tbPalvelunKuvaus.Name = "tbPalvelunKuvaus";
            this.tbPalvelunKuvaus.Size = new System.Drawing.Size(179, 29);
            this.tbPalvelunKuvaus.TabIndex = 3;
            // 
            // tbALV
            // 
            this.tbALV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbALV.Location = new System.Drawing.Point(176, 467);
            this.tbALV.Name = "tbALV";
            this.tbALV.Size = new System.Drawing.Size(179, 29);
            this.tbALV.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palvelun nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Palvelun tyyppi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Palvelun kuvaus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palvelun hinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 470);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "ALV %";
            // 
            // cbAlue
            // 
            this.cbAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlue.FormattingEnabled = true;
            this.cbAlue.Location = new System.Drawing.Point(73, 15);
            this.cbAlue.Name = "cbAlue";
            this.cbAlue.Size = new System.Drawing.Size(185, 32);
            this.cbAlue.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alueet";
            // 
            // btnLisaa
            // 
            this.btnLisaa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLisaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaa.Location = new System.Drawing.Point(527, 420);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(131, 97);
            this.btnLisaa.TabIndex = 13;
            this.btnLisaa.Text = "Lisää uusi palvelu";
            this.btnLisaa.UseVisualStyleBackColor = false;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnPoistaPalvelu
            // 
            this.btnPoistaPalvelu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPoistaPalvelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaPalvelu.Location = new System.Drawing.Point(680, 420);
            this.btnPoistaPalvelu.Name = "btnPoistaPalvelu";
            this.btnPoistaPalvelu.Size = new System.Drawing.Size(131, 97);
            this.btnPoistaPalvelu.TabIndex = 14;
            this.btnPoistaPalvelu.Text = "Poista palvelu";
            this.btnPoistaPalvelu.UseVisualStyleBackColor = false;
            this.btnPoistaPalvelu.Click += new System.EventHandler(this.btnPoistaPalvelu_Click);
            // 
            // btnPaivitaPalvelua
            // 
            this.btnPaivitaPalvelua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaivitaPalvelua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivitaPalvelua.Location = new System.Drawing.Point(384, 420);
            this.btnPaivitaPalvelua.Name = "btnPaivitaPalvelua";
            this.btnPaivitaPalvelua.Size = new System.Drawing.Size(131, 97);
            this.btnPaivitaPalvelua.TabIndex = 15;
            this.btnPaivitaPalvelua.Text = "Päivitä palvelu";
            this.btnPaivitaPalvelua.UseVisualStyleBackColor = false;
            this.btnPaivitaPalvelua.Click += new System.EventHandler(this.btnPaivitaPalvelua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(12, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 206);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbAlue);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(377, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 62);
            this.panel2.TabIndex = 17;
            // 
            // PalveluidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(828, 529);
            this.Controls.Add(this.btnPaivitaPalvelua);
            this.Controls.Add(this.btnPoistaPalvelu);
            this.Controls.Add(this.btnLisaa);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PalveluidenHallinta";
            this.Text = "PalveluidenHallinta";
            this.Load += new System.EventHandler(this.PalveluidenHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalvelut)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}