namespace Mokkivaraus
{
    partial class frmMokkivalinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMokkivalinta));
            this.dgwMokkivalinta = new System.Windows.Forms.DataGridView();
            this.btnVaraaM = new System.Windows.Forms.Button();
            this.dtpPoistumis = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpSaapumis = new System.Windows.Forms.DateTimePicker();
            this.tbMokinnimi = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbPostiN = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwMokinid = new System.Windows.Forms.DataGridView();
            this.lbPalvelut = new System.Windows.Forms.ListBox();
            this.lbValitutpalvelut = new System.Windows.Forms.ListBox();
            this.dgwAlue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokinid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMokkivalinta
            // 
            this.dgwMokkivalinta.AllowUserToAddRows = false;
            this.dgwMokkivalinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokkivalinta.Location = new System.Drawing.Point(15, 20);
            this.dgwMokkivalinta.Name = "dgwMokkivalinta";
            this.dgwMokkivalinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMokkivalinta.Size = new System.Drawing.Size(1009, 223);
            this.dgwMokkivalinta.TabIndex = 0;
            this.dgwMokkivalinta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokkivalinta_CellClick);
            this.dgwMokkivalinta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokkivalinta_CellContentClick);
            // 
            // btnVaraaM
            // 
            this.btnVaraaM.Location = new System.Drawing.Point(901, 470);
            this.btnVaraaM.Name = "btnVaraaM";
            this.btnVaraaM.Size = new System.Drawing.Size(120, 79);
            this.btnVaraaM.TabIndex = 3;
            this.btnVaraaM.Text = "Varaa valittu mökki";
            this.btnVaraaM.UseVisualStyleBackColor = true;
            this.btnVaraaM.Click += new System.EventHandler(this.btnVaraaM_Click);
            // 
            // dtpPoistumis
            // 
            this.dtpPoistumis.CustomFormat = "yyyy-MM-dd";
            this.dtpPoistumis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPoistumis.Location = new System.Drawing.Point(421, 419);
            this.dtpPoistumis.Name = "dtpPoistumis";
            this.dtpPoistumis.Size = new System.Drawing.Size(192, 20);
            this.dtpPoistumis.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Poistumispäivä";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Saapumispäivä";
            // 
            // dtpSaapumis
            // 
            this.dtpSaapumis.CustomFormat = "yyyy-MM-dd";
            this.dtpSaapumis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaapumis.Location = new System.Drawing.Point(421, 376);
            this.dtpSaapumis.Name = "dtpSaapumis";
            this.dtpSaapumis.Size = new System.Drawing.Size(192, 20);
            this.dtpSaapumis.TabIndex = 24;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Enabled = false;
            this.tbMokinnimi.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinnimi.Location = new System.Drawing.Point(102, 249);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(192, 22);
            this.tbMokinnimi.TabIndex = 28;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Enabled = false;
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKatuosoite.Location = new System.Drawing.Point(102, 289);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(192, 22);
            this.tbKatuosoite.TabIndex = 29;
            // 
            // tbHinta
            // 
            this.tbHinta.Enabled = false;
            this.tbHinta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHinta.Location = new System.Drawing.Point(102, 332);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(192, 22);
            this.tbHinta.TabIndex = 30;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Enabled = false;
            this.tbKuvaus.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKuvaus.Location = new System.Drawing.Point(102, 375);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(192, 74);
            this.tbKuvaus.TabIndex = 31;
            // 
            // tbPostiN
            // 
            this.tbPostiN.Enabled = false;
            this.tbPostiN.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostiN.Location = new System.Drawing.Point(421, 332);
            this.tbPostiN.Name = "tbPostiN";
            this.tbPostiN.Size = new System.Drawing.Size(192, 22);
            this.tbPostiN.TabIndex = 34;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Enabled = false;
            this.tbVarustelu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarustelu.Location = new System.Drawing.Point(421, 289);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(192, 22);
            this.tbVarustelu.TabIndex = 33;
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.Location = new System.Drawing.Point(421, 249);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(192, 22);
            this.tbMax.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mökin nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Katuosoite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Hinta/Yö";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Kuvaus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Max henkilömäärä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Postinumero";
            // 
            // dgwMokinid
            // 
            this.dgwMokinid.AllowUserToAddRows = false;
            this.dgwMokinid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokinid.Location = new System.Drawing.Point(989, 225);
            this.dgwMokinid.Name = "dgwMokinid";
            this.dgwMokinid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMokinid.Size = new System.Drawing.Size(10, 10);
            this.dgwMokinid.TabIndex = 42;
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.FormattingEnabled = true;
            this.lbPalvelut.Location = new System.Drawing.Point(619, 249);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.Size = new System.Drawing.Size(173, 186);
            this.lbPalvelut.TabIndex = 44;
            this.lbPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPalvelut_MouseClick);
            this.lbPalvelut.SelectedIndexChanged += new System.EventHandler(this.lbPalvelut_SelectedIndexChanged);
            // 
            // lbValitutpalvelut
            // 
            this.lbValitutpalvelut.FormattingEnabled = true;
            this.lbValitutpalvelut.Location = new System.Drawing.Point(854, 249);
            this.lbValitutpalvelut.Name = "lbValitutpalvelut";
            this.lbValitutpalvelut.Size = new System.Drawing.Size(170, 186);
            this.lbValitutpalvelut.TabIndex = 45;
            this.lbValitutpalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbValitutpalvelut_MouseClick);
            // 
            // dgwAlue
            // 
            this.dgwAlue.AllowUserToAddRows = false;
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlue.Location = new System.Drawing.Point(862, 186);
            this.dgwAlue.Name = "dgwAlue";
            this.dgwAlue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAlue.Size = new System.Drawing.Size(10, 10);
            this.dgwAlue.TabIndex = 46;
            // 
            // frmMokkivalinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 592);
            this.Controls.Add(this.lbValitutpalvelut);
            this.Controls.Add(this.lbPalvelut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPostiN);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokinnimi);
            this.Controls.Add(this.dtpPoistumis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpSaapumis);
            this.Controls.Add(this.btnVaraaM);
            this.Controls.Add(this.dgwMokkivalinta);
            this.Controls.Add(this.dgwMokinid);
            this.Controls.Add(this.dgwAlue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMokkivalinta";
            this.Text = "Mokkivalinta";
            this.Load += new System.EventHandler(this.frmMokkivalinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokinid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMokkivalinta;
        private System.Windows.Forms.Button btnVaraaM;
        private System.Windows.Forms.DateTimePicker dtpPoistumis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpSaapumis;
        private System.Windows.Forms.TextBox tbMokinnimi;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbPostiN;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwMokinid;
        private System.Windows.Forms.ListBox lbPalvelut;
        private System.Windows.Forms.ListBox lbValitutpalvelut;
        private System.Windows.Forms.DataGridView dgwAlue;
    }
}