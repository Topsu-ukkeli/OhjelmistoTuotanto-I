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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiedot));
            this.dgwAlue = new System.Windows.Forms.DataGridView();
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
            this.cbPostiN = new System.Windows.Forms.ComboBox();
            this.dgwPostinro = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAlue
            // 
            this.dgwAlue.AllowUserToAddRows = false;
            this.dgwAlue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlue.Location = new System.Drawing.Point(33, 12);
            this.dgwAlue.Name = "dgwAlue";
            this.dgwAlue.Size = new System.Drawing.Size(322, 244);
            this.dgwAlue.TabIndex = 0;
            this.dgwAlue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAlue_CellClick);
            // 
            // tbAlue
            // 
            this.tbAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlue.Location = new System.Drawing.Point(160, 287);
            this.tbAlue.Name = "tbAlue";
            this.tbAlue.Size = new System.Drawing.Size(179, 29);
            this.tbAlue.TabIndex = 3;
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlue.Location = new System.Drawing.Point(43, 287);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(111, 24);
            this.lblAlue.TabIndex = 5;
            this.lblAlue.Text = "Alueen nimi";
            // 
            // btnLisaaAlue
            // 
            this.btnLisaaAlue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLisaaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaAlue.Location = new System.Drawing.Point(202, 368);
            this.btnLisaaAlue.Name = "btnLisaaAlue";
            this.btnLisaaAlue.Size = new System.Drawing.Size(153, 81);
            this.btnLisaaAlue.TabIndex = 7;
            this.btnLisaaAlue.Text = "Lisää alue";
            this.btnLisaaAlue.UseVisualStyleBackColor = false;
            this.btnLisaaAlue.Click += new System.EventHandler(this.btnLisaaAlue_Click);
            // 
            // dgwMokki
            // 
            this.dgwMokki.AllowUserToAddRows = false;
            this.dgwMokki.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMokki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokki.Location = new System.Drawing.Point(361, 12);
            this.dgwMokki.Name = "dgwMokki";
            this.dgwMokki.Size = new System.Drawing.Size(721, 244);
            this.dgwMokki.TabIndex = 8;
            this.dgwMokki.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokki_CellClick);
            this.dgwMokki.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokki_CellContentClick);
            // 
            // lblPostiN
            // 
            this.lblPostiN.AutoSize = true;
            this.lblPostiN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPostiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostiN.Location = new System.Drawing.Point(746, 359);
            this.lblPostiN.Name = "lblPostiN";
            this.lblPostiN.Size = new System.Drawing.Size(116, 24);
            this.lblPostiN.TabIndex = 55;
            this.lblPostiN.Text = "Postinumero";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarustelu.Location = new System.Drawing.Point(773, 322);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(89, 24);
            this.lblVarustelu.TabIndex = 54;
            this.lblVarustelu.Text = "Varustelu";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(702, 287);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(164, 24);
            this.lblMax.TabIndex = 53;
            this.lblMax.Text = "Max henkilömäärä";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuvaus.Location = new System.Drawing.Point(405, 392);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(72, 24);
            this.lblKuvaus.TabIndex = 52;
            this.lblKuvaus.Text = "Kuvaus";
            // 
            // lblHinta
            // 
            this.lblHinta.AutoSize = true;
            this.lblHinta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinta.Location = new System.Drawing.Point(396, 359);
            this.lblHinta.Name = "lblHinta";
            this.lblHinta.Size = new System.Drawing.Size(81, 24);
            this.lblHinta.TabIndex = 51;
            this.lblHinta.Text = "Hinta/Yö";
            // 
            // lblkatu
            // 
            this.lblkatu.AutoSize = true;
            this.lblkatu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblkatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkatu.Location = new System.Drawing.Point(381, 322);
            this.lblkatu.Name = "lblkatu";
            this.lblkatu.Size = new System.Drawing.Size(97, 24);
            this.lblkatu.TabIndex = 50;
            this.lblkatu.Text = "Katuosoite";
            // 
            // lblMokinnimi
            // 
            this.lblMokinnimi.AutoSize = true;
            this.lblMokinnimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMokinnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokinnimi.Location = new System.Drawing.Point(377, 287);
            this.lblMokinnimi.Name = "lblMokinnimi";
            this.lblMokinnimi.Size = new System.Drawing.Size(101, 24);
            this.lblMokinnimi.TabIndex = 49;
            this.lblMokinnimi.Text = "Mökin nimi";
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarustelu.Location = new System.Drawing.Point(868, 319);
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(192, 29);
            this.tbVarustelu.TabIndex = 47;
            // 
            // tbMax
            // 
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.Location = new System.Drawing.Point(868, 284);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(192, 29);
            this.tbMax.TabIndex = 46;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKuvaus.Location = new System.Drawing.Point(483, 394);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(192, 74);
            this.tbKuvaus.TabIndex = 45;
            // 
            // tbHinta
            // 
            this.tbHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHinta.Location = new System.Drawing.Point(483, 354);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(192, 29);
            this.tbHinta.TabIndex = 44;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKatuosoite.Location = new System.Drawing.Point(483, 319);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(192, 29);
            this.tbKatuosoite.TabIndex = 43;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinnimi.Location = new System.Drawing.Point(483, 284);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(192, 29);
            this.tbMokinnimi.TabIndex = 42;
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLisaaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLisaaMokki.Location = new System.Drawing.Point(929, 502);
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.Size = new System.Drawing.Size(153, 81);
            this.btnLisaaMokki.TabIndex = 56;
            this.btnLisaaMokki.Text = "Lisää uusi mökki";
            this.btnLisaaMokki.UseVisualStyleBackColor = false;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // btnPoistaAlue
            // 
            this.btnPoistaAlue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPoistaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaAlue.Location = new System.Drawing.Point(33, 368);
            this.btnPoistaAlue.Name = "btnPoistaAlue";
            this.btnPoistaAlue.Size = new System.Drawing.Size(153, 81);
            this.btnPoistaAlue.TabIndex = 57;
            this.btnPoistaAlue.Text = "Poista alue";
            this.btnPoistaAlue.UseVisualStyleBackColor = false;
            this.btnPoistaAlue.Click += new System.EventHandler(this.btnPoistaAlue_Click);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPoistaMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoistaMokki.Location = new System.Drawing.Point(770, 502);
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.Size = new System.Drawing.Size(153, 81);
            this.btnPoistaMokki.TabIndex = 58;
            this.btnPoistaMokki.Text = "Poista mökin tiedot";
            this.btnPoistaMokki.UseVisualStyleBackColor = false;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // cbAlueid
            // 
            this.cbAlueid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlueid.FormattingEnabled = true;
            this.cbAlueid.Location = new System.Drawing.Point(868, 389);
            this.cbAlueid.Name = "cbAlueid";
            this.cbAlueid.Size = new System.Drawing.Size(192, 32);
            this.cbAlueid.TabIndex = 59;
            this.cbAlueid.SelectedIndexChanged += new System.EventHandler(this.cbAlueid_SelectedIndexChanged);
            this.cbAlueid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAlueid_MouseClick);
            // 
            // lblAlueV
            // 
            this.lblAlueV.AutoSize = true;
            this.lblAlueV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAlueV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlueV.Location = new System.Drawing.Point(734, 397);
            this.lblAlueV.Name = "lblAlueV";
            this.lblAlueV.Size = new System.Drawing.Size(128, 24);
            this.lblAlueV.TabIndex = 60;
            this.lblAlueV.Text = "Alueen valinta";
            // 
            // rdbAlue
            // 
            this.rdbAlue.AutoSize = true;
            this.rdbAlue.Checked = true;
            this.rdbAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAlue.Location = new System.Drawing.Point(33, 467);
            this.rdbAlue.Name = "rdbAlue";
            this.rdbAlue.Size = new System.Drawing.Size(188, 29);
            this.rdbAlue.TabIndex = 61;
            this.rdbAlue.TabStop = true;
            this.rdbAlue.Text = "Muokkaa alueita";
            this.rdbAlue.UseVisualStyleBackColor = true;
            this.rdbAlue.CheckedChanged += new System.EventHandler(this.rdbAlue_CheckedChanged);
            // 
            // rdbMokki
            // 
            this.rdbMokki.AutoSize = true;
            this.rdbMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMokki.Location = new System.Drawing.Point(33, 502);
            this.rdbMokki.Name = "rdbMokki";
            this.rdbMokki.Size = new System.Drawing.Size(204, 29);
            this.rdbMokki.TabIndex = 62;
            this.rdbMokki.Text = "Muokkaa mökkejä";
            this.rdbMokki.UseVisualStyleBackColor = true;
            this.rdbMokki.CheckedChanged += new System.EventHandler(this.rdbMokki_CheckedChanged);
            // 
            // cbPostiN
            // 
            this.cbPostiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPostiN.FormattingEnabled = true;
            this.cbPostiN.Location = new System.Drawing.Point(176, 88);
            this.cbPostiN.Name = "cbPostiN";
            this.cbPostiN.Size = new System.Drawing.Size(192, 32);
            this.cbPostiN.TabIndex = 64;
            this.cbPostiN.SelectedIndexChanged += new System.EventHandler(this.cbPostiN_SelectedIndexChanged);
            // 
            // dgwPostinro
            // 
            this.dgwPostinro.AllowUserToAddRows = false;
            this.dgwPostinro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPostinro.Location = new System.Drawing.Point(555, 124);
            this.dgwPostinro.Name = "dgwPostinro";
            this.dgwPostinro.Size = new System.Drawing.Size(10, 10);
            this.dgwPostinro.TabIndex = 65;
            this.dgwPostinro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(361, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 230);
            this.panel1.TabIndex = 66;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbPostiN);
            this.panel2.Location = new System.Drawing.Point(692, 264);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 232);
            this.panel2.TabIndex = 67;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(33, 264);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 82);
            this.panel3.TabIndex = 68;
            // 
            // frmTiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1097, 597);
            this.Controls.Add(this.tbKuvaus);
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
            this.Controls.Add(this.tbVarustelu);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokinnimi);
            this.Controls.Add(this.dgwMokki);
            this.Controls.Add(this.btnLisaaAlue);
            this.Controls.Add(this.lblAlue);
            this.Controls.Add(this.tbAlue);
            this.Controls.Add(this.dgwAlue);
            this.Controls.Add(this.dgwPostinro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTiedot";
            this.Text = "Tiedot";
            this.Load += new System.EventHandler(this.frmTiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAlue;
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
        private System.Windows.Forms.ComboBox cbPostiN;
        private System.Windows.Forms.DataGridView dgwPostinro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}