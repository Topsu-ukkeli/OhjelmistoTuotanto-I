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
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausPalvelut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaraus
            // 
            this.dgvVaraus.AllowUserToAddRows = false;
            this.dgvVaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaraus.Location = new System.Drawing.Point(201, 12);
            this.dgvVaraus.Name = "dgvVaraus";
            this.dgvVaraus.Size = new System.Drawing.Size(996, 71);
            this.dgvVaraus.TabIndex = 1;
            // 
            // cbPaperilasku
            // 
            this.cbPaperilasku.AutoSize = true;
            this.cbPaperilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaperilasku.Location = new System.Drawing.Point(769, 292);
            this.cbPaperilasku.Name = "cbPaperilasku";
            this.cbPaperilasku.Size = new System.Drawing.Size(133, 29);
            this.cbPaperilasku.TabIndex = 3;
            this.cbPaperilasku.Text = "Paperilasku";
            this.cbPaperilasku.UseVisualStyleBackColor = true;
            this.cbPaperilasku.CheckedChanged += new System.EventHandler(this.cbPaperilasku_CheckedChanged);
            // 
            // cbSpostilasku
            // 
            this.cbSpostilasku.AutoSize = true;
            this.cbSpostilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpostilasku.Location = new System.Drawing.Point(1035, 292);
            this.cbSpostilasku.Name = "cbSpostilasku";
            this.cbSpostilasku.Size = new System.Drawing.Size(175, 29);
            this.cbSpostilasku.TabIndex = 4;
            this.cbSpostilasku.Text = "Sähköpostilasku";
            this.cbSpostilasku.UseVisualStyleBackColor = true;
            this.cbSpostilasku.CheckedChanged += new System.EventHandler(this.cbSpostilasku_CheckedChanged);
            // 
            // btnVahvista
            // 
            this.btnVahvista.Enabled = false;
            this.btnVahvista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVahvista.Location = new System.Drawing.Point(1117, 698);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(214, 99);
            this.btnVahvista.TabIndex = 5;
            this.btnVahvista.Text = "Vahvista varaus";
            this.btnVahvista.UseVisualStyleBackColor = true;
            this.btnVahvista.Click += new System.EventHandler(this.btnVahvista_Click);
            // 
            // btnPalaa
            // 
            this.btnPalaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalaa.Location = new System.Drawing.Point(19, 698);
            this.btnPalaa.Name = "btnPalaa";
            this.btnPalaa.Size = new System.Drawing.Size(214, 99);
            this.btnPalaa.TabIndex = 6;
            this.btnPalaa.Text = "Muokkaa varausta";
            this.btnPalaa.UseVisualStyleBackColor = true;
            // 
            // cbLaskutusosoite
            // 
            this.cbLaskutusosoite.AutoSize = true;
            this.cbLaskutusosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLaskutusosoite.Location = new System.Drawing.Point(769, 327);
            this.cbLaskutusosoite.Name = "cbLaskutusosoite";
            this.cbLaskutusosoite.Size = new System.Drawing.Size(215, 29);
            this.cbLaskutusosoite.TabIndex = 7;
            this.cbLaskutusosoite.Text = "Laskutusosoite on eri";
            this.cbLaskutusosoite.UseVisualStyleBackColor = true;
            this.cbLaskutusosoite.Visible = false;
            this.cbLaskutusosoite.CheckedChanged += new System.EventHandler(this.cbLaskutusosoite_CheckedChanged);
            // 
            // tbLosoite
            // 
            this.tbLosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLosoite.Location = new System.Drawing.Point(876, 361);
            this.tbLosoite.Name = "tbLosoite";
            this.tbLosoite.Size = new System.Drawing.Size(135, 23);
            this.tbLosoite.TabIndex = 8;
            this.tbLosoite.Visible = false;
            // 
            // tbPostinum
            // 
            this.tbPostinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostinum.Location = new System.Drawing.Point(876, 390);
            this.tbPostinum.Name = "tbPostinum";
            this.tbPostinum.Size = new System.Drawing.Size(135, 23);
            this.tbPostinum.TabIndex = 9;
            this.tbPostinum.Visible = false;
            // 
            // tbPostitoim
            // 
            this.tbPostitoim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostitoim.Location = new System.Drawing.Point(876, 419);
            this.tbPostitoim.Name = "tbPostitoim";
            this.tbPostitoim.Size = new System.Drawing.Size(135, 23);
            this.tbPostitoim.TabIndex = 10;
            this.tbPostitoim.Visible = false;
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(766, 364);
            this.lblOsoite.Name = "lblOsoite";
            this.lblOsoite.Size = new System.Drawing.Size(88, 17);
            this.lblOsoite.TabIndex = 11;
            this.lblOsoite.Text = "Laskutusoite";
            this.lblOsoite.Visible = false;
            // 
            // lblPostinumero
            // 
            this.lblPostinumero.AutoSize = true;
            this.lblPostinumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostinumero.Location = new System.Drawing.Point(766, 393);
            this.lblPostinumero.Name = "lblPostinumero";
            this.lblPostinumero.Size = new System.Drawing.Size(87, 17);
            this.lblPostinumero.TabIndex = 12;
            this.lblPostinumero.Text = "Postinumero";
            this.lblPostinumero.Visible = false;
            // 
            // lblPostitoimipaikka
            // 
            this.lblPostitoimipaikka.AutoSize = true;
            this.lblPostitoimipaikka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(766, 422);
            this.lblPostitoimipaikka.Name = "lblPostitoimipaikka";
            this.lblPostitoimipaikka.Size = new System.Drawing.Size(109, 17);
            this.lblPostitoimipaikka.TabIndex = 13;
            this.lblPostitoimipaikka.Text = "Postitoimipaikka";
            this.lblPostitoimipaikka.Visible = false;
            // 
            // cbVahvistasposti
            // 
            this.cbVahvistasposti.AutoSize = true;
            this.cbVahvistasposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVahvistasposti.Location = new System.Drawing.Point(1035, 327);
            this.cbVahvistasposti.Name = "cbVahvistasposti";
            this.cbVahvistasposti.Size = new System.Drawing.Size(378, 29);
            this.cbVahvistasposti.TabIndex = 14;
            this.cbVahvistasposti.Text = "Lähetä lasku eri sähköpostiosoitteeseen";
            this.cbVahvistasposti.UseVisualStyleBackColor = true;
            this.cbVahvistasposti.Visible = false;
            this.cbVahvistasposti.CheckedChanged += new System.EventHandler(this.cbVahvistasposti_CheckedChanged);
            // 
            // tbLsposti
            // 
            this.tbLsposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLsposti.Location = new System.Drawing.Point(1035, 390);
            this.tbLsposti.Name = "tbLsposti";
            this.tbLsposti.Size = new System.Drawing.Size(179, 23);
            this.tbLsposti.TabIndex = 15;
            this.tbLsposti.Visible = false;
            // 
            // lblSposlasku
            // 
            this.lblSposlasku.AutoSize = true;
            this.lblSposlasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposlasku.Location = new System.Drawing.Point(1032, 364);
            this.lblSposlasku.Name = "lblSposlasku";
            this.lblSposlasku.Size = new System.Drawing.Size(103, 17);
            this.lblSposlasku.TabIndex = 16;
            this.lblSposlasku.Text = "Laskutusosoite";
            this.lblSposlasku.Visible = false;
            // 
            // dgvVarausMokki
            // 
            this.dgvVarausMokki.AllowUserToAddRows = false;
            this.dgvVarausMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarausMokki.Location = new System.Drawing.Point(200, 166);
            this.dgvVarausMokki.Name = "dgvVarausMokki";
            this.dgvVarausMokki.Size = new System.Drawing.Size(996, 71);
            this.dgvVarausMokki.TabIndex = 17;
            // 
            // dgvVarausPalvelut
            // 
            this.dgvVarausPalvelut.AllowUserToAddRows = false;
            this.dgvVarausPalvelut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarausPalvelut.Location = new System.Drawing.Point(201, 166);
            this.dgvVarausPalvelut.Name = "dgvVarausPalvelut";
            this.dgvVarausPalvelut.Size = new System.Drawing.Size(996, 120);
            this.dgvVarausPalvelut.TabIndex = 18;
            // 
            // dgvLasku
            // 
            this.dgvLasku.AllowUserToAddRows = false;
            this.dgvLasku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLasku.Location = new System.Drawing.Point(201, 12);
            this.dgvLasku.Name = "dgvLasku";
            this.dgvLasku.Size = new System.Drawing.Size(10, 10);
            this.dgvLasku.TabIndex = 19;
            // 
            // lblVaraaja
            // 
            this.lblVaraaja.AutoSize = true;
            this.lblVaraaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVaraaja.Location = new System.Drawing.Point(80, 38);
            this.lblVaraaja.Name = "lblVaraaja";
            this.lblVaraaja.Size = new System.Drawing.Size(80, 25);
            this.lblVaraaja.TabIndex = 20;
            this.lblVaraaja.Text = "Varaaja";
            // 
            // lblVarausmokki
            // 
            this.lblVarausmokki.AutoSize = true;
            this.lblVarausmokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVarausmokki.Location = new System.Drawing.Point(80, 114);
            this.lblVarausmokki.Name = "lblVarausmokki";
            this.lblVarausmokki.Size = new System.Drawing.Size(64, 25);
            this.lblVarausmokki.TabIndex = 21;
            this.lblVarausmokki.Text = "Mökki";
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblPalvelut.Location = new System.Drawing.Point(80, 209);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(115, 25);
            this.lblPalvelut.TabIndex = 22;
            this.lblPalvelut.Text = "Lisäpalvelut";
            // 
            // lbHinnat
            // 
            this.lbHinnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinnat.FormattingEnabled = true;
            this.lbHinnat.ItemHeight = 25;
            this.lbHinnat.Location = new System.Drawing.Point(200, 292);
            this.lbHinnat.Name = "lbHinnat";
            this.lbHinnat.Size = new System.Drawing.Size(563, 279);
            this.lbHinnat.TabIndex = 23;
            // 
            // lblHinnat
            // 
            this.lblHinnat.AutoSize = true;
            this.lblHinnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHinnat.Location = new System.Drawing.Point(41, 292);
            this.lblHinnat.Name = "lblHinnat";
            this.lblHinnat.Size = new System.Drawing.Size(154, 25);
            this.lblHinnat.TabIndex = 24;
            this.lblHinnat.Text = "Varauksen hinta";
            // 
            // dtpAika
            // 
            this.dtpAika.CustomFormat = "yyyy-MM-dd";
            this.dtpAika.Location = new System.Drawing.Point(1133, 89);
            this.dtpAika.Name = "dtpAika";
            this.dtpAika.Size = new System.Drawing.Size(64, 20);
            this.dtpAika.TabIndex = 26;
            this.dtpAika.Value = new System.DateTime(2022, 5, 10, 0, 0, 0, 0);
            this.dtpAika.Visible = false;
            // 
            // frmVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 809);
            this.Controls.Add(this.lblHinnat);
            this.Controls.Add(this.lbHinnat);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.lblVarausmokki);
            this.Controls.Add(this.lblVaraaja);
            this.Controls.Add(this.dgvVarausPalvelut);
            this.Controls.Add(this.dgvVarausMokki);
            this.Controls.Add(this.lblSposlasku);
            this.Controls.Add(this.tbLsposti);
            this.Controls.Add(this.cbVahvistasposti);
            this.Controls.Add(this.lblPostitoimipaikka);
            this.Controls.Add(this.lblPostinumero);
            this.Controls.Add(this.lblOsoite);
            this.Controls.Add(this.tbPostitoim);
            this.Controls.Add(this.tbPostinum);
            this.Controls.Add(this.tbLosoite);
            this.Controls.Add(this.cbLaskutusosoite);
            this.Controls.Add(this.btnPalaa);
            this.Controls.Add(this.btnVahvista);
            this.Controls.Add(this.cbSpostilasku);
            this.Controls.Add(this.cbPaperilasku);
            this.Controls.Add(this.dgvVaraus);
            this.Controls.Add(this.dgvLasku);
            this.Controls.Add(this.dtpAika);
            this.Name = "frmVaraus";
            this.Text = "Yhteenveto";
            this.Load += new System.EventHandler(this.frmVaraus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaraus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarausPalvelut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLasku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}