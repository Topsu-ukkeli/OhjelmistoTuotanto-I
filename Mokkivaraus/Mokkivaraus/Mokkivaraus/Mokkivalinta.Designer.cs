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
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.lblValitut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbHinta = new System.Windows.Forms.ListBox();
            this.lbHintaValitut = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVapaat = new System.Windows.Forms.Button();
            this.dgwVarauksenID = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokinid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVarauksenID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMokkivalinta
            // 
            this.dgwMokkivalinta.AllowUserToAddRows = false;
            this.dgwMokkivalinta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMokkivalinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokkivalinta.Location = new System.Drawing.Point(44, 103);
            this.dgwMokkivalinta.Name = "dgwMokkivalinta";
            this.dgwMokkivalinta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMokkivalinta.Size = new System.Drawing.Size(1025, 238);
            this.dgwMokkivalinta.TabIndex = 0;
            this.dgwMokkivalinta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokkivalinta_CellClick);
            this.dgwMokkivalinta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMokkivalinta_CellContentClick);
            // 
            // btnVaraaM
            // 
            this.btnVaraaM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVaraaM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraaM.Location = new System.Drawing.Point(877, 671);
            this.btnVaraaM.Name = "btnVaraaM";
            this.btnVaraaM.Size = new System.Drawing.Size(192, 103);
            this.btnVaraaM.TabIndex = 3;
            this.btnVaraaM.Text = "Varaa valittu mökki";
            this.btnVaraaM.UseVisualStyleBackColor = false;
            this.btnVaraaM.Click += new System.EventHandler(this.btnVaraaM_Click);
            // 
            // dtpPoistumis
            // 
            this.dtpPoistumis.CustomFormat = "yyyy-MM-dd";
            this.dtpPoistumis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPoistumis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPoistumis.Location = new System.Drawing.Point(179, 47);
            this.dtpPoistumis.Name = "dtpPoistumis";
            this.dtpPoistumis.Size = new System.Drawing.Size(221, 31);
            this.dtpPoistumis.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = "Poistumispäivä";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Saapumispäivä";
            // 
            // dtpSaapumis
            // 
            this.dtpSaapumis.CustomFormat = "yyyy-MM-dd";
            this.dtpSaapumis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaapumis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaapumis.Location = new System.Drawing.Point(179, 4);
            this.dtpSaapumis.Name = "dtpSaapumis";
            this.dtpSaapumis.Size = new System.Drawing.Size(221, 31);
            this.dtpSaapumis.TabIndex = 24;
            // 
            // tbMokinnimi
            // 
            this.tbMokinnimi.Enabled = false;
            this.tbMokinnimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMokinnimi.Location = new System.Drawing.Point(245, 366);
            this.tbMokinnimi.Name = "tbMokinnimi";
            this.tbMokinnimi.Size = new System.Drawing.Size(221, 31);
            this.tbMokinnimi.TabIndex = 28;
            // 
            // tbKatuosoite
            // 
            this.tbKatuosoite.Enabled = false;
            this.tbKatuosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKatuosoite.Location = new System.Drawing.Point(245, 403);
            this.tbKatuosoite.Name = "tbKatuosoite";
            this.tbKatuosoite.Size = new System.Drawing.Size(221, 31);
            this.tbKatuosoite.TabIndex = 29;
            // 
            // tbHinta
            // 
            this.tbHinta.Enabled = false;
            this.tbHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHinta.Location = new System.Drawing.Point(245, 440);
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(221, 31);
            this.tbHinta.TabIndex = 30;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.Enabled = false;
            this.tbKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKuvaus.Location = new System.Drawing.Point(201, 204);
            this.tbKuvaus.Multiline = true;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(221, 80);
            this.tbKuvaus.TabIndex = 31;
            // 
            // tbPostiN
            // 
            this.tbPostiN.Enabled = false;
            this.tbPostiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostiN.Location = new System.Drawing.Point(245, 514);
            this.tbPostiN.Name = "tbPostiN";
            this.tbPostiN.Size = new System.Drawing.Size(221, 31);
            this.tbPostiN.TabIndex = 34;
            // 
            // tbVarustelu
            // 
            this.tbVarustelu.Enabled = false;
            this.tbVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarustelu.Location = new System.Drawing.Point(201, 290);
            this.tbVarustelu.Multiline = true;
            this.tbVarustelu.Name = "tbVarustelu";
            this.tbVarustelu.Size = new System.Drawing.Size(221, 80);
            this.tbVarustelu.TabIndex = 33;
            // 
            // tbMax
            // 
            this.tbMax.Enabled = false;
            this.tbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMax.Location = new System.Drawing.Point(201, 130);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(221, 31);
            this.tbMax.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mökin nimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Katuosoite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Hinta/Yö";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Kuvaus";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Max henkilömäärä";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Varustelu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Postinumero";
            // 
            // dgwMokinid
            // 
            this.dgwMokinid.AllowUserToAddRows = false;
            this.dgwMokinid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokinid.Location = new System.Drawing.Point(1030, 227);
            this.dgwMokinid.Name = "dgwMokinid";
            this.dgwMokinid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwMokinid.Size = new System.Drawing.Size(10, 10);
            this.dgwMokinid.TabIndex = 42;
            // 
            // lbPalvelut
            // 
            this.lbPalvelut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPalvelut.FormattingEnabled = true;
            this.lbPalvelut.ItemHeight = 25;
            this.lbPalvelut.Location = new System.Drawing.Point(18, 39);
            this.lbPalvelut.Name = "lbPalvelut";
            this.lbPalvelut.Size = new System.Drawing.Size(279, 250);
            this.lbPalvelut.TabIndex = 44;
            this.lbPalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbPalvelut_MouseClick);
            this.lbPalvelut.SelectedIndexChanged += new System.EventHandler(this.lbPalvelut_SelectedIndexChanged);
            // 
            // lbValitutpalvelut
            // 
            this.lbValitutpalvelut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbValitutpalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValitutpalvelut.FormattingEnabled = true;
            this.lbValitutpalvelut.ItemHeight = 25;
            this.lbValitutpalvelut.Location = new System.Drawing.Point(303, 39);
            this.lbValitutpalvelut.Name = "lbValitutpalvelut";
            this.lbValitutpalvelut.Size = new System.Drawing.Size(279, 250);
            this.lbValitutpalvelut.TabIndex = 45;
            this.lbValitutpalvelut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbValitutpalvelut_MouseClick);
            // 
            // dgwAlue
            // 
            this.dgwAlue.AllowUserToAddRows = false;
            this.dgwAlue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAlue.Location = new System.Drawing.Point(903, 188);
            this.dgwAlue.Name = "dgwAlue";
            this.dgwAlue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAlue.Size = new System.Drawing.Size(10, 10);
            this.dgwAlue.TabIndex = 46;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.AutoSize = true;
            this.lblPalvelut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalvelut.Location = new System.Drawing.Point(494, 358);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(284, 25);
            this.lblPalvelut.TabIndex = 47;
            this.lblPalvelut.Text = "Saatavilla olevat lisäpalvelut";
            // 
            // lblValitut
            // 
            this.lblValitut.AutoSize = true;
            this.lblValitut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValitut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValitut.Location = new System.Drawing.Point(784, 358);
            this.lblValitut.Name = "lblValitut";
            this.lblValitut.Size = new System.Drawing.Size(186, 25);
            this.lblValitut.TabIndex = 48;
            this.lblValitut.Text = "Valitut lisäpalvelut";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tbVarustelu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbMax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbKuvaus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(44, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 397);
            this.panel1.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbHinta);
            this.panel2.Controls.Add(this.lbHintaValitut);
            this.panel2.Controls.Add(this.lbPalvelut);
            this.panel2.Controls.Add(this.lbValitutpalvelut);
            this.panel2.Location = new System.Drawing.Point(481, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 318);
            this.panel2.TabIndex = 50;
            // 
            // lbHinta
            // 
            this.lbHinta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinta.FormattingEnabled = true;
            this.lbHinta.ItemHeight = 25;
            this.lbHinta.Location = new System.Drawing.Point(201, 39);
            this.lbHinta.Name = "lbHinta";
            this.lbHinta.Size = new System.Drawing.Size(96, 250);
            this.lbHinta.TabIndex = 52;
            // 
            // lbHintaValitut
            // 
            this.lbHintaValitut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHintaValitut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHintaValitut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbHintaValitut.FormattingEnabled = true;
            this.lbHintaValitut.ItemHeight = 25;
            this.lbHintaValitut.Location = new System.Drawing.Point(486, 39);
            this.lbHintaValitut.Name = "lbHintaValitut";
            this.lbHintaValitut.Size = new System.Drawing.Size(96, 250);
            this.lbHintaValitut.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dtpPoistumis);
            this.panel3.Controls.Add(this.dtpSaapumis);
            this.panel3.Location = new System.Drawing.Point(44, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 85);
            this.panel3.TabIndex = 51;
            // 
            // btnVapaat
            // 
            this.btnVapaat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVapaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVapaat.Location = new System.Drawing.Point(481, 12);
            this.btnVapaat.Name = "btnVapaat";
            this.btnVapaat.Size = new System.Drawing.Size(192, 85);
            this.btnVapaat.TabIndex = 52;
            this.btnVapaat.Text = "Hae vapaat mökit";
            this.btnVapaat.UseVisualStyleBackColor = false;
            this.btnVapaat.Click += new System.EventHandler(this.btnVapaat_Click);
            // 
            // dgwVarauksenID
            // 
            this.dgwVarauksenID.AllowUserToAddRows = false;
            this.dgwVarauksenID.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwVarauksenID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVarauksenID.Location = new System.Drawing.Point(12, 21);
            this.dgwVarauksenID.Name = "dgwVarauksenID";
            this.dgwVarauksenID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVarauksenID.Size = new System.Drawing.Size(10, 10);
            this.dgwVarauksenID.TabIndex = 53;
            this.dgwVarauksenID.Visible = false;
            // 
            // frmMokkivalinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1095, 794);
            this.Controls.Add(this.btnVapaat);
            this.Controls.Add(this.lblValitut);
            this.Controls.Add(this.lblPalvelut);
            this.Controls.Add(this.tbPostiN);
            this.Controls.Add(this.tbHinta);
            this.Controls.Add(this.tbKatuosoite);
            this.Controls.Add(this.tbMokinnimi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnVaraaM);
            this.Controls.Add(this.dgwVarauksenID);
            this.Controls.Add(this.dgwMokkivalinta);
            this.Controls.Add(this.dgwMokinid);
            this.Controls.Add(this.dgwAlue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMokkivalinta";
            this.Text = "Mokkivalinta";
            this.Load += new System.EventHandler(this.frmMokkivalinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokinid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAlue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVarauksenID)).EndInit();
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
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.Label lblValitut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbHinta;
        private System.Windows.Forms.ListBox lbHintaValitut;
        private System.Windows.Forms.Button btnVapaat;
        private System.Windows.Forms.DataGridView dgwVarauksenID;
    }
}