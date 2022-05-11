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
            this.dgwAlue = new System.Windows.Forms.DataGridView();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.tbAlue = new System.Windows.Forms.TextBox();
            this.lblAlue = new System.Windows.Forms.Label();
            this.btnLisaaAlue = new System.Windows.Forms.Button();
            this.dgwMokki = new System.Windows.Forms.DataGridView();
            this.lblPostiN = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblHinta = new System.Windows.Forms.Label();
            this.lblkatu = new System.Windows.Forms.Label();
            this.lblMokinnimi = new System.Windows.Forms.Label();
            this.tbPostiN = new System.Windows.Forms.TextBox();
            this.tbVarustelu = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbKuvaus = new System.Windows.Forms.TextBox();
            this.tbHinta = new System.Windows.Forms.TextBox();
            this.tbKatuosoite = new System.Windows.Forms.TextBox();
            this.tbMokinnimi = new System.Windows.Forms.TextBox();
            this.btnLisaaMokki = new System.Windows.Forms.Button();
            this.btnPoistaAlue = new System.Windows.Forms.Button();
            this.btnPoistaMokki = new System.Windows.Forms.Button();
            this.cbAlueid = new System.Windows.Forms.ComboBox();
            this.lblAlueV = new System.Windows.Forms.Label();
            this.rdbAlue = new System.Windows.Forms.RadioButton();
            this.rdbMokki = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cbPostiN = new System.Windows.Forms.ComboBox();
            this.dgwPostinro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAlue
            // 
            this.dgwAlue.AllowUserToAddRows = false;
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlue.Location = new System.Drawing.Point(130, 12);
            this.dgwAlue.Name = "dgwAlue";
            this.dgwAlue.Size = new System.Drawing.Size(296, 244);
            this.dgwAlue.TabIndex = 0;
            this.dgwAlue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAlue_CellClick);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(130, 491);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(125, 69);
            this.btnAsiakkaat.TabIndex = 1;
            this.btnAsiakkaat.Text = "Lisää asiakas";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // tbAlue
            // 
            this.tbAlue.Location = new System.Drawing.Point(247, 287);
            this.tbAlue.Name = "tbAlue";
            this.tbAlue.Size = new System.Drawing.Size(179, 20);
            this.tbAlue.TabIndex = 3;
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlue.Location = new System.Drawing.Point(130, 287);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(111, 24);
            this.lblAlue.TabIndex = 5;
            this.lblAlue.Text = "Alueen nimi";
            // 
            // btnLisaaAlue
            // 
            this.btnLisaaAlue.Location = new System.Drawing.Point(130, 328);
            this.btnLisaaAlue.Name = "btnLisaaAlue";
            this.btnLisaaAlue.Size = new System.Drawing.Size(102, 23);
            this.btnLisaaAlue.TabIndex = 7;
            this.btnLisaaAlue.Text = "Lisää alue";
            this.btnLisaaAlue.UseVisualStyleBackColor = true;
            this.btnLisaaAlue.Click += new System.EventHandler(this.btnLisaaAlue_Click);
            // 
            // dgwMokki
            // 
            this.dgwMokki.AllowUserToAddRows = false;
            this.dgwMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokki.Location = new System.Drawing.Point(475, 12);
            this.dgwMokki.Name = "dgwMokki";
            this.dgwMokki.Size = new System.Drawing.Size(627, 244);
            this.dgwMokki.TabIndex = 8;
            this.dgwMokki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokki_CellClick);
            this.dgwMokki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokki_CellContentClick);
            // 
            // lblPostiN
            // 
            this.lblPostiN.AutoSize = true;
            this.lblPostiN.Location = new System.Drawing.Point(769, 353);
            this.lblPostiN.Name = "lblPostiN";
            this.lblPostiN.Size = new System.Drawing.Size(65, 13);
            this.lblPostiN.TabIndex = 55;
            this.lblPostiN.Text = "Postinumero";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Location = new System.Drawing.Point(769, 310);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(51, 13);
            this.lblVarustelu.TabIndex = 54;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(769, 270);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(93, 13);
            this.lblMax.TabIndex = 53;
            this.lblMax.Text = "Max henkilömäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Location = new System.Drawing.Point(472, 396);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(43, 13);
            this.lblKuvaus.TabIndex = 52;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.Location = new System.Drawing.Point(472, 353);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(50, 13);
            this.lblHinta.TabIndex = 51;
            this.lblHinta.Text = "Hinta/Yö";
            // 
            // lblkatu
            // 
            this.lblkatu.AutoSize = true;
            this.lblkatu.Location = new System.Drawing.Point(472, 310);
            this.lblkatu.Name = "lblkatu";
            this.lblkatu.Size = new System.Drawing.Size(57, 13);
            this.lblkatu.TabIndex = 50;
            this.lblkatu.Text = "Katuosoite";
            // 
            // lblMokinnimi
            // 
            this.lblMokinnimi.AutoSize = true;
            this.lblMokinnimi.Location = new System.Drawing.Point(472, 270);
            this.lblMokinnimi.Name = "lblMokinnimi";
            this.lblMokinnimi.Size = new System.Drawing.Size(57, 13);
            this.lblMokinnimi.TabIndex = 49;
            this.lblMokinnimi.Text = "Mökin nimi";
            // 
            // tbPostiN
            // 
            this.tbPostiN.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostiN.Location = new System.Drawing.Point(881, 346);
            this.tbPostiN.Name = "tbPostiN";
            this.tbPostiN.Size = new System.Drawing.Size(192, 22);
            this.tbPostiN.TabIndex = 48;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarustelu.Location = new System.Drawing.Point(881, 303);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(192, 22);
            this.tbVarustelu.TabIndex = 47;
            // 
            // tbMax
            // 
            this.tbMax.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.Location = new System.Drawing.Point(881, 263);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(192, 22);
            this.tbMax.TabIndex = 46;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKuvaus.Location = new System.Drawing.Point(562, 374);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(192, 74);
            this.tbKuvaus.TabIndex = 45;
            // 
            // tbHinta
            // 
            this.tbHinta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHinta.Location = new System.Drawing.Point(562, 346);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(192, 22);
            this.tbHinta.TabIndex = 44;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKatuosoite.Location = new System.Drawing.Point(562, 303);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(192, 22);
            this.tbKatuosoite.TabIndex = 43;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinnimi.Location = new System.Drawing.Point(562, 263);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(192, 22);
            this.tbMokinnimi.TabIndex = 42;
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.Location = new System.Drawing.Point(960, 489);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(113, 67);
            this.btnLisaaMokki.TabIndex = 56;
            this.btnLisaaMokki.Text = "Lisää uusi mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // btnPoistaAlue
            // 
            this.btnPoistaAlue.Location = new System.Drawing.Point(324, 328);
            this.btnPoistaAlue.Name = "btnPoistaAlue";
            this.btnPoistaAlue.Size = new System.Drawing.Size(102, 23);
            this.btnPoistaAlue.TabIndex = 57;
            this.btnPoistaAlue.Text = "Poista alue";
            this.btnPoistaAlue.UseVisualStyleBackColor = true;
            this.btnPoistaAlue.Click += new System.EventHandler(this.btnPoistaAlue_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.Location = new System.Drawing.Point(475, 491);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(113, 67);
            this.btnPoistaMokki.TabIndex = 58;
            this.btnPoistaMokki.Text = "Poista mökin tiedot";
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // cbAlueid
            // 
            this.cbAlueid.FormattingEnabled = true;
            this.cbAlueid.Location = new System.Drawing.Point(881, 396);
            this.cbAlueid.Name = "cbAlueid";
            this.cbAlueid.Size = new System.Drawing.Size(192, 21);
            this.cbAlueid.TabIndex = 59;
            this.cbAlueid.SelectedIndexChanged += new System.EventHandler(this.cbAlueid_SelectedIndexChanged);
            this.cbAlueid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAlueid_MouseClick);
            // 
            // lblAlueV
            // 
            this.lblAlueV.AutoSize = true;
            this.lblAlueV.Location = new System.Drawing.Point(769, 404);
            this.lblAlueV.Name = "lblAlueV";
            this.lblAlueV.Size = new System.Drawing.Size(74, 13);
            this.lblAlueV.TabIndex = 60;
            this.lblAlueV.Text = "Alueen valinta";
            // 
            // rdbAlue
            // 
            this.rdbAlue.AutoSize = true;
            this.rdbAlue.Checked = true;
            this.rdbAlue.Location = new System.Drawing.Point(12, 12);
            this.rdbAlue.Name = "rdbAlue";
            this.rdbAlue.Size = new System.Drawing.Size(104, 17);
            this.rdbAlue.TabIndex = 61;
            this.rdbAlue.TabStop = true;
            this.rdbAlue.Text = "Muokkaa alueita";
            this.rdbAlue.UseVisualStyleBackColor = true;
            this.rdbAlue.CheckedChanged += new System.EventHandler(this.rdbAlue_CheckedChanged);
            // 
            // rdbMokki
            // 
            this.rdbMokki.AutoSize = true;
            this.rdbMokki.Location = new System.Drawing.Point(12, 46);
            this.rdbMokki.Name = "rdbMokki";
            this.rdbMokki.Size = new System.Drawing.Size(113, 17);
            this.rdbMokki.TabIndex = 62;
            this.rdbMokki.Text = "Muokkaa mökkejä";
            this.rdbMokki.UseVisualStyleBackColor = true;
            this.rdbMokki.CheckedChanged += new System.EventHandler(this.rdbMokki_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 69);
            this.button1.TabIndex = 63;
            this.button1.Text = "Palvelunmuokkauksee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbPostiN
            // 
            this.cbPostiN.FormattingEnabled = true;
            this.cbPostiN.Location = new System.Drawing.Point(881, 442);
            this.cbPostiN.Name = "cbPostiN";
            this.cbPostiN.Size = new System.Drawing.Size(192, 21);
            this.cbPostiN.TabIndex = 64;
            this.cbPostiN.SelectedIndexChanged += new System.EventHandler(this.cbPostiN_SelectedIndexChanged);
            // 
            // dgwPostinro
            // 
            this.dgwPostinro.AllowUserToAddRows = false;
            this.dgwPostinro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPostinro.Location = new System.Drawing.Point(130, 491);
            this.dgwPostinro.Name = "dgwPostinro";
            this.dgwPostinro.Size = new System.Drawing.Size(10, 10);
            this.dgwPostinro.TabIndex = 65;
            // 
            // frmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 582);
            this.Controls.Add(this.cbPostiN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbMokki);
            this.Controls.Add(this.rdbAlue);
            this.Controls.Add(this.lblAlueV);
            this.Controls.Add(this.cbAlueid);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.btnPoistaAlue);
            this.Controls.Add(this.btnLisaaMokki);
            this.Controls.Add(this.lblPostiN);
            this.Controls.Add(this.lblVarustelu);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblKuvaus);
            this.Controls.Add(this.lblHinta);
            this.Controls.Add(this.lblkatu);
            this.Controls.Add(this.lblMokinnimi);
            this.Controls.Add(this.tbPostiN);
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbKuvaus);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokinnimi);
            this.Controls.Add(this.dgwMokki);
            this.Controls.Add(this.btnLisaaAlue);
            this.Controls.Add(this.lblAlue);
            this.Controls.Add(this.tbAlue);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.dgwAlue);
            this.Controls.Add(this.dgwPostinro);
            this.Name = "frmTiedot";
            this.Text = "Tiedot";
            this.Load += new System.EventHandler(this.frmTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAlue;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.TextBox tbAlue;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.Button btnLisaaAlue;
        private System.Windows.Forms.DataGridView dgwMokki;
        private System.Windows.Forms.Label lblPostiN;
        private System.Windows.Forms.Label lblVarustelu;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblHinta;
        private System.Windows.Forms.Label lblkatu;
        private System.Windows.Forms.Label lblMokinnimi;
        private System.Windows.Forms.TextBox tbPostiN;
        private System.Windows.Forms.TextBox tbVarustelu;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.TextBox tbKuvaus;
        private System.Windows.Forms.TextBox tbHinta;
        private System.Windows.Forms.TextBox tbKatuosoite;
        private System.Windows.Forms.TextBox tbMokinnimi;
        private System.Windows.Forms.Button btnLisaaMokki;
        private System.Windows.Forms.Button btnPoistaAlue;
        private System.Windows.Forms.Button btnPoistaMokki;
        private System.Windows.Forms.ComboBox cbAlueid;
        private System.Windows.Forms.Label lblAlueV;
        private System.Windows.Forms.RadioButton rdbAlue;
        private System.Windows.Forms.RadioButton rdbMokki;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbPostiN;
        private System.Windows.Forms.DataGridView dgwPostinro;
    }
}