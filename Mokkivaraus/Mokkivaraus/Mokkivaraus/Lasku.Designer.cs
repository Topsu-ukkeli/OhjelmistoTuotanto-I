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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaraus));
            this.dgvVaraus = new System.Windows.Forms.DataGridView();
            this.cbPaperilasku = new System.Windows.Forms.CheckBox();
            this.cbSpostilasku = new System.Windows.Forms.CheckBox();
            this.btnVahvista = new System.Windows.Forms.Button();
            this.btnPalaa = new System.Windows.Forms.Button();
            this.cbLaskutusosoite = new System.Windows.Forms.CheckBox();
            this.tbLosoite = new System.Windows.Forms.TextBox();
            this.tbPostinum = new System.Windows.Forms.TextBox();
            this.tbPostitoim = new System.Windows.Forms.TextBox();
            this.lblOsoite = new System.Windows.Forms.Label();
            this.lblPostinumero = new System.Windows.Forms.Label();
            this.lblPostitoimipaikka = new System.Windows.Forms.Label();
            this.cbVahvistasposti = new System.Windows.Forms.CheckBox();
            this.tbLsposti = new System.Windows.Forms.TextBox();
            this.lblSposlasku = new System.Windows.Forms.Label();
            this.dgvVarausMokki = new System.Windows.Forms.DataGridView();
            this.dgvVarausPalvelut = new System.Windows.Forms.DataGridView();
            this.dgvLasku = new System.Windows.Forms.DataGridView();
            this.lblVaraaja = new System.Windows.Forms.Label();
            this.lblVarausmokki = new System.Windows.Forms.Label();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.lbHinnat = new System.Windows.Forms.ListBox();
            this.lblHinnat = new System.Windows.Forms.Label();
            this.dtpAika = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.AllowUserToAddRows = false;
            this.dgvVaraus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(238, 30);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.Size = new System.Drawing.Size(996, 71);
            this.dgvVaraus.TabIndex = 1;
            // 
            // cbPaperilasku
            // 
            this.cbPaperilasku.AutoSize = true;
            this.cbPaperilasku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbPaperilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaperilasku.Location = new System.Drawing.Point(18, 29);
            this.cbPaperilasku.Name = "cbPaperilasku";
            this.cbPaperilasku.Size = new System.Drawing.Size(126, 28);
            this.cbPaperilasku.TabIndex = 3;
            this.cbPaperilasku.Text = "Paperilasku";
            this.cbPaperilasku.UseVisualStyleBackColor = false;
            this.cbPaperilasku.CheckedChanged += new System.EventHandler(this.cbPaperilasku_CheckedChanged);
            // 
            // cbSpostilasku
            // 
            this.cbSpostilasku.AutoSize = true;
            this.cbSpostilasku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbSpostilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpostilasku.Location = new System.Drawing.Point(18, 176);
            this.cbSpostilasku.Name = "cbSpostilasku";
            this.cbSpostilasku.Size = new System.Drawing.Size(164, 28);
            this.cbSpostilasku.TabIndex = 4;
            this.cbSpostilasku.Text = "Sähköpostilasku";
            this.cbSpostilasku.UseVisualStyleBackColor = false;
            this.cbSpostilasku.CheckedChanged += new System.EventHandler(this.cbSpostilasku_CheckedChanged);
            // 
            // btnVahvista
            // 
            this.btnVahvista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVahvista.Enabled = false;
            this.btnVahvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVahvista.Location = new System.Drawing.Point(1020, 617);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(214, 117);
            this.btnVahvista.TabIndex = 5;
            this.btnVahvista.Text = "Vahvista varaus ja lähetä lasku";
            this.btnVahvista.UseVisualStyleBackColor = false;
            this.btnVahvista.Click += new System.EventHandler(this.btnVahvista_Click);
            // 
            // btnPalaa
            // 
            this.btnPalaa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPalaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalaa.Location = new System.Drawing.Point(12, 617);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(214, 117);
            this.btnPalaa.TabIndex = 6;
            this.btnPalaa.Text = "Muokkaa varausta";
            this.btnPalaa.UseVisualStyleBackColor = false;
            this.btnPalaa.Click += new System.EventHandler(this.btnPalaa_Click);
            // 
            // cbLaskutusosoite
            // 
            this.cbLaskutusosoite.AutoSize = true;
            this.cbLaskutusosoite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbLaskutusosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLaskutusosoite.Location = new System.Drawing.Point(18, 63);
            this.cbLaskutusosoite.Name = "cbLaskutusosoite";
            this.cbLaskutusosoite.Size = new System.Drawing.Size(205, 28);
            this.cbLaskutusosoite.TabIndex = 7;
            this.cbLaskutusosoite.Text = "Laskutusosoite on eri";
            this.cbLaskutusosoite.UseVisualStyleBackColor = false;
            this.cbLaskutusosoite.Visible = false;
            this.cbLaskutusosoite.CheckedChanged += new System.EventHandler(this.cbLaskutusosoite_CheckedChanged);
            // 
            // tbLosoite
            // 
            this.tbLosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLosoite.Location = new System.Drawing.Point(125, 91);
            this.tbLosoite.Name = "tbLosoite";
            this.tbLosoite.Size = new System.Drawing.Size(135, 23);
            this.tbLosoite.TabIndex = 8;
            this.tbLosoite.Visible = false;
            // 
            // tbPostinum
            // 
            this.tbPostinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostinum.Location = new System.Drawing.Point(125, 118);
            this.tbPostinum.Name = "tbPostinum";
            this.tbPostinum.Size = new System.Drawing.Size(135, 23);
            this.tbPostinum.TabIndex = 9;
            this.tbPostinum.Visible = false;
            // 
            // tbPostitoim
            // 
            this.tbPostitoim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostitoim.Location = new System.Drawing.Point(125, 147);
            this.tbPostitoim.Name = "tbPostitoim";
            this.tbPostitoim.Size = new System.Drawing.Size(135, 23);
            this.tbPostitoim.TabIndex = 10;
            this.tbPostitoim.Visible = false;
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(15, 94);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(88, 17);
            this.lblOsoite.TabIndex = 11;
            this.lblOsoite.Text = "Laskutusoite";
            this.lblOsoite.Visible = false;
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinumero.Location = new System.Drawing.Point(15, 121);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(87, 17);
            this.lblPostinumero.TabIndex = 12;
            this.lblPostinumero.Text = "Postinumero";
            this.lblPostinumero.Visible = false;
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(15, 147);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(109, 17);
            this.lblPostitoimipaikka.TabIndex = 13;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            this.lblPostitoimipaikka.Visible = false;
            // 
            // cbVahvistasposti
            // 
            this.cbVahvistasposti.AutoSize = true;
            this.cbVahvistasposti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbVahvistasposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVahvistasposti.Location = new System.Drawing.Point(18, 210);
            this.cbVahvistasposti.Name = "cbVahvistasposti";
            this.cbVahvistasposti.Size = new System.Drawing.Size(360, 28);
            this.cbVahvistasposti.TabIndex = 14;
            this.cbVahvistasposti.Text = "Lähetä lasku eri sähköpostiosoitteeseen";
            this.cbVahvistasposti.UseVisualStyleBackColor = false;
            this.cbVahvistasposti.Visible = false;
            this.cbVahvistasposti.CheckedChanged += new System.EventHandler(this.cbVahvistasposti_CheckedChanged);
            // 
            // tbLsposti
            // 
            this.tbLsposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLsposti.Location = new System.Drawing.Point(124, 238);
            this.tbLsposti.Name = "tbLsposti";
            this.tbLsposti.Size = new System.Drawing.Size(179, 23);
            this.tbLsposti.TabIndex = 15;
            this.tbLsposti.Visible = false;
            // 
            // lblSposlasku
            // 
            this.lblSposlasku.AutoSize = true;
            this.lblSposlasku.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSposlasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposlasku.Location = new System.Drawing.Point(15, 241);
            this.lblSposlasku.Name = "lblSposlasku";
            this.lblSposlasku.Size = new System.Drawing.Size(103, 17);
            this.lblSposlasku.TabIndex = 16;
            this.lblSposlasku.Text = "Laskutusosoite";
            this.lblSposlasku.Visible = false;
            // 
            // dgvVarausMokki
            // 
            this.dgvVarausMokki.AllowUserToAddRows = false;
            this.dgvVarausMokki.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVarausMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarausMokki.Location = new System.Drawing.Point(238, 107);
            this.dgvVarausMokki.Name = "dgvVarausMokki";
            this.dgvVarausMokki.Size = new System.Drawing.Size(996, 71);
            this.dgvVarausMokki.TabIndex = 17;
            // 
            // dgvVarausPalvelut
            // 
            this.dgvVarausPalvelut.AllowUserToAddRows = false;
            this.dgvVarausPalvelut.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVarausPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarausPalvelut.Location = new System.Drawing.Point(238, 184);
            this.dgvVarausPalvelut.Name = "dgvVarausPalvelut";
            this.dgvVarausPalvelut.Size = new System.Drawing.Size(996, 120);
            this.dgvVarausPalvelut.TabIndex = 18;
            // 
            // dgvLasku
            // 
            this.dgvLasku.AllowUserToAddRows = false;
            this.dgvLasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku.Location = new System.Drawing.Point(243, 3);
            this.dgvLasku.Name = "dgvLasku";
            this.dgvLasku.Size = new System.Drawing.Size(10, 10);
            this.dgvLasku.TabIndex = 19;
            // 
            // lblVaraaja
            // 
            this.lblVaraaja.AutoSize = true;
            this.lblVaraaja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVaraaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraaja.Location = new System.Drawing.Point(3, 21);
            this.lblVaraaja.Name = "lblVaraaja";
            this.lblVaraaja.Size = new System.Drawing.Size(86, 25);
            this.lblVaraaja.TabIndex = 20;
            this.lblVaraaja.Text = "Varaaja";
            // 
            // lblVarausmokki
            // 
            this.lblVarausmokki.AutoSize = true;
            this.lblVarausmokki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVarausmokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarausmokki.Location = new System.Drawing.Point(3, 23);
            this.lblVarausmokki.Name = "lblVarausmokki";
            this.lblVarausmokki.Size = new System.Drawing.Size(69, 25);
            this.lblVarausmokki.TabIndex = 21;
            this.lblVarausmokki.Text = "Mökki";
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalvelut.Location = new System.Drawing.Point(3, 47);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(127, 25);
            this.lblPalvelut.TabIndex = 22;
            this.lblPalvelut.Text = "Lisäpalvelut";
            // 
            // lbHinnat
            // 
            this.lbHinnat.BackColor = System.Drawing.SystemColors.Control;
            this.lbHinnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinnat.FormattingEnabled = true;
            this.lbHinnat.ItemHeight = 25;
            this.lbHinnat.Location = new System.Drawing.Point(238, 310);
            this.lbHinnat.Name = "lbHinnat";
            this.lbHinnat.Size = new System.Drawing.Size(563, 229);
            this.lbHinnat.TabIndex = 23;
            // 
            // lblHinnat
            // 
            this.lblHinnat.AutoSize = true;
            this.lblHinnat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHinnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinnat.Location = new System.Drawing.Point(3, 29);
            this.lblHinnat.Name = "lblHinnat";
            this.lblHinnat.Size = new System.Drawing.Size(168, 25);
            this.lblHinnat.TabIndex = 24;
            this.lblHinnat.Text = "Varauksen hinta";
            // 
            // dtpAika
            // 
            this.dtpAika.CustomFormat = "yyyy-MM-dd";
            this.dtpAika.Location = new System.Drawing.Point(1170, 107);
            this.dtpAika.Name = "dtpAika";
            this.dtpAika.Size = new System.Drawing.Size(64, 20);
            this.dtpAika.TabIndex = 26;
            this.dtpAika.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            this.dtpAika.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbPaperilasku);
            this.panel1.Controls.Add(this.cbLaskutusosoite);
            this.panel1.Controls.Add(this.lblOsoite);
            this.panel1.Controls.Add(this.lblPostinumero);
            this.panel1.Controls.Add(this.lblPostitoimipaikka);
            this.panel1.Controls.Add(this.tbLosoite);
            this.panel1.Controls.Add(this.tbLsposti);
            this.panel1.Controls.Add(this.tbPostinum);
            this.panel1.Controls.Add(this.tbPostitoim);
            this.panel1.Controls.Add(this.lblSposlasku);
            this.panel1.Controls.Add(this.cbVahvistasposti);
            this.panel1.Controls.Add(this.cbSpostilasku);
            this.panel1.Location = new System.Drawing.Point(827, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 301);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblVaraaja);
            this.panel2.Controls.Add(this.dgvLasku);
            this.panel2.Location = new System.Drawing.Point(22, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 71);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.lblVarausmokki);
            this.panel3.Location = new System.Drawing.Point(22, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 71);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.lblPalvelut);
            this.panel4.Location = new System.Drawing.Point(22, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 120);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.lblHinnat);
            this.panel5.Location = new System.Drawing.Point(22, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 91);
            this.panel5.TabIndex = 31;
            // 
            // frmVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1254, 741);
            this.Controls.Add(this.lbHinnat);
            this.Controls.Add(this.dgvVarausPalvelut);
            this.Controls.Add(this.dgvVarausMokki);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnVahvista);
            this.Controls.Add(this.dgvVaraus);
            this.Controls.Add(this.dtpAika);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVaraus";
            this.Text = "Yhteenveto";
            this.Load += new System.EventHandler(this.frmVaraus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaraus;
        private System.Windows.Forms.CheckBox cbPaperilasku;
        private System.Windows.Forms.CheckBox cbSpostilasku;
        private System.Windows.Forms.Button btnVahvista;
        private System.Windows.Forms.Button btnPalaa;
        private System.Windows.Forms.CheckBox cbLaskutusosoite;
        private System.Windows.Forms.TextBox tbLosoite;
        private System.Windows.Forms.TextBox tbPostinum;
        private System.Windows.Forms.TextBox tbPostitoim;
        private System.Windows.Forms.Label lblOsoite;
        private System.Windows.Forms.Label lblPostinumero;
        private System.Windows.Forms.Label lblPostitoimipaikka;
        private System.Windows.Forms.CheckBox cbVahvistasposti;
        private System.Windows.Forms.TextBox tbLsposti;
        private System.Windows.Forms.Label lblSposlasku;
        private System.Windows.Forms.DataGridView dgvVarausMokki;
        private System.Windows.Forms.DataGridView dgvVarausPalvelut;
        private System.Windows.Forms.DataGridView dgvLasku;
        private System.Windows.Forms.Label lblVaraaja;
        private System.Windows.Forms.Label lblVarausmokki;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.ListBox lbHinnat;
        private System.Windows.Forms.Label lblHinnat;
        private System.Windows.Forms.DateTimePicker dtpAika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}