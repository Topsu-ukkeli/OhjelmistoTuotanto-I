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
            this.cbPaperilasku.CheckedChanged += new System.EventHandler(this.cbPaperilasku_CheckedChanged);
            // 
            // cbSpostilasku
            // 
            this.cbSpostilasku.AutoSize = true;
            this.cbSpostilasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpostilasku.Location = new System.Drawing.Point(420, 200);
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
            this.btnVahvista.Location = new System.Drawing.Point(764, 397);
            this.btnVahvista.Name = "btnVahvista";
            this.btnVahvista.Size = new System.Drawing.Size(214, 99);
            this.btnVahvista.TabIndex = 5;
            this.btnVahvista.Text = "Vahvista varaus";
            this.btnVahvista.UseVisualStyleBackColor = true;
            this.btnVahvista.Click += new System.EventHandler(this.btnVahvista_Click);
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
            // cbLaskutusosoite
            // 
            this.cbLaskutusosoite.AutoSize = true;
            this.cbLaskutusosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLaskutusosoite.Location = new System.Drawing.Point(19, 235);
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
            this.tbLosoite.Location = new System.Drawing.Point(126, 269);
            this.tbLosoite.Name = "tbLosoite";
            this.tbLosoite.Size = new System.Drawing.Size(135, 23);
            this.tbLosoite.TabIndex = 8;
            this.tbLosoite.Visible = false;
            // 
            // tbPostinum
            // 
            this.tbPostinum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostinum.Location = new System.Drawing.Point(126, 298);
            this.tbPostinum.Name = "tbPostinum";
            this.tbPostinum.Size = new System.Drawing.Size(135, 23);
            this.tbPostinum.TabIndex = 9;
            this.tbPostinum.Visible = false;
            // 
            // tbPostitoim
            // 
            this.tbPostitoim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostitoim.Location = new System.Drawing.Point(126, 327);
            this.tbPostitoim.Name = "tbPostitoim";
            this.tbPostitoim.Size = new System.Drawing.Size(135, 23);
            this.tbPostitoim.TabIndex = 10;
            this.tbPostitoim.Visible = false;
            // 
            // lblOsoite
            // 
            this.lblOsoite.AutoSize = true;
            this.lblOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOsoite.Location = new System.Drawing.Point(16, 272);
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
            this.lblPostinumero.Location = new System.Drawing.Point(16, 301);
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
            this.lblPostitoimipaikka.Location = new System.Drawing.Point(16, 330);
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
            this.cbVahvistasposti.Location = new System.Drawing.Point(420, 235);
            this.cbVahvistasposti.Name = "cbVahvistasposti";
            this.cbVahvistasposti.Size = new System.Drawing.Size(378, 29);
            this.cbVahvistasposti.TabIndex = 14;
            this.cbVahvistasposti.Text = "Lähetä lasku eri sähköpostiosoitteeseen";
            this.cbVahvistasposti.UseVisualStyleBackColor = true;
            this.cbVahvistasposti.Visible = false;
            // 
            // tbLsposti
            // 
            this.tbLsposti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLsposti.Location = new System.Drawing.Point(526, 269);
            this.tbLsposti.Name = "tbLsposti";
            this.tbLsposti.Size = new System.Drawing.Size(179, 23);
            this.tbLsposti.TabIndex = 15;
            this.tbLsposti.Visible = false;
            this.tbLsposti.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSposlasku
            // 
            this.lblSposlasku.AutoSize = true;
            this.lblSposlasku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSposlasku.Location = new System.Drawing.Point(417, 272);
            this.lblSposlasku.Name = "lblSposlasku";
            this.lblSposlasku.Size = new System.Drawing.Size(103, 17);
            this.lblSposlasku.TabIndex = 16;
            this.lblSposlasku.Text = "Laskutusosoite";
            this.lblSposlasku.Visible = false;
            // 
            // frmVaraus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 508);
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
    }
}