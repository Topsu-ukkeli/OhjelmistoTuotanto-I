namespace Mokkivaraus
{
    partial class frmAsiakastiedot
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
            this.txtEtu = new System.Windows.Forms.TextBox();
            this.txtSuku = new System.Windows.Forms.TextBox();
            this.txtPostiO = new System.Windows.Forms.TextBox();
            this.cbPostiN = new System.Windows.Forms.ComboBox();
            this.txtPuhelin = new System.Windows.Forms.TextBox();
            this.txtSahko = new System.Windows.Forms.TextBox();
            this.txtPostiP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkYksityinen = new System.Windows.Forms.CheckBox();
            this.chkYritys = new System.Windows.Forms.CheckBox();
            this.btnVarauksiin = new System.Windows.Forms.Button();
            this.dgwTest = new System.Windows.Forms.DataGridView();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnLissee = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.btnhae = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEtu
            // 
            this.txtEtu.Location = new System.Drawing.Point(155, 62);
            this.txtEtu.Name = "txtEtu";
            this.txtEtu.Size = new System.Drawing.Size(222, 20);
            this.txtEtu.TabIndex = 0;
            // 
            // txtSuku
            // 
            this.txtSuku.Location = new System.Drawing.Point(155, 104);
            this.txtSuku.Name = "txtSuku";
            this.txtSuku.Size = new System.Drawing.Size(222, 20);
            this.txtSuku.TabIndex = 1;
            // 
            // txtPostiO
            // 
            this.txtPostiO.Location = new System.Drawing.Point(155, 150);
            this.txtPostiO.Name = "txtPostiO";
            this.txtPostiO.Size = new System.Drawing.Size(222, 20);
            this.txtPostiO.TabIndex = 2;
            // 
            // cbPostiN
            // 
            this.cbPostiN.FormattingEnabled = true;
            this.cbPostiN.Location = new System.Drawing.Point(155, 196);
            this.cbPostiN.Name = "cbPostiN";
            this.cbPostiN.Size = new System.Drawing.Size(222, 21);
            this.cbPostiN.TabIndex = 3;
            // 
            // txtPuhelin
            // 
            this.txtPuhelin.Location = new System.Drawing.Point(155, 340);
            this.txtPuhelin.Name = "txtPuhelin";
            this.txtPuhelin.Size = new System.Drawing.Size(222, 20);
            this.txtPuhelin.TabIndex = 6;
            // 
            // txtSahko
            // 
            this.txtSahko.Location = new System.Drawing.Point(155, 294);
            this.txtSahko.Name = "txtSahko";
            this.txtSahko.Size = new System.Drawing.Size(222, 20);
            this.txtSahko.TabIndex = 5;
            // 
            // txtPostiP
            // 
            this.txtPostiP.Location = new System.Drawing.Point(155, 246);
            this.txtPostiP.Name = "txtPostiP";
            this.txtPostiP.Size = new System.Drawing.Size(222, 20);
            this.txtPostiP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Postiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postitoimipaikka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sähköposti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Puhelinnumero";
            // 
            // chkYksityinen
            // 
            this.chkYksityinen.AutoSize = true;
            this.chkYksityinen.Checked = true;
            this.chkYksityinen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkYksityinen.Location = new System.Drawing.Point(155, 28);
            this.chkYksityinen.Name = "chkYksityinen";
            this.chkYksityinen.Size = new System.Drawing.Size(74, 17);
            this.chkYksityinen.TabIndex = 20;
            this.chkYksityinen.Text = "Yksityinen";
            this.chkYksityinen.UseVisualStyleBackColor = true;
            this.chkYksityinen.CheckedChanged += new System.EventHandler(this.chkYksityinen_CheckedChanged);
            // 
            // chkYritys
            // 
            this.chkYritys.AutoSize = true;
            this.chkYritys.Location = new System.Drawing.Point(297, 28);
            this.chkYritys.Name = "chkYritys";
            this.chkYritys.Size = new System.Drawing.Size(51, 17);
            this.chkYritys.TabIndex = 21;
            this.chkYritys.Text = "Yritys";
            this.chkYritys.UseVisualStyleBackColor = true;
            this.chkYritys.CheckedChanged += new System.EventHandler(this.chkYritys_CheckedChanged);
            // 
            // btnVarauksiin
            // 
            this.btnVarauksiin.Location = new System.Drawing.Point(68, 415);
            this.btnVarauksiin.Name = "btnVarauksiin";
            this.btnVarauksiin.Size = new System.Drawing.Size(108, 64);
            this.btnVarauksiin.TabIndex = 10;
            this.btnVarauksiin.Text = "Siirry mökin valintaan";
            this.btnVarauksiin.UseVisualStyleBackColor = true;
            this.btnVarauksiin.Click += new System.EventHandler(this.btnVarauksiin_Click);
            // 
            // dgwTest
            // 
            this.dgwTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTest.Location = new System.Drawing.Point(1041, 463);
            this.dgwTest.Name = "dgwTest";
            this.dgwTest.Size = new System.Drawing.Size(10, 10);
            this.dgwTest.TabIndex = 23;
            this.dgwTest.Visible = false;
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Location = new System.Drawing.Point(182, 415);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Size = new System.Drawing.Size(108, 64);
            this.btnAsiakkaat.TabIndex = 11;
            this.btnAsiakkaat.Text = "Tarkasta asiakkaiden tiedot";
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAsiakkaat_Click);
            // 
            // btnLissee
            // 
            this.btnLissee.Location = new System.Drawing.Point(296, 449);
            this.btnLissee.Name = "btnLissee";
            this.btnLissee.Size = new System.Drawing.Size(104, 30);
            this.btnLissee.TabIndex = 24;
            this.btnLissee.Text = "Lisää";
            this.btnLissee.UseVisualStyleBackColor = true;
            this.btnLissee.Click += new System.EventHandler(this.btnLissee_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(296, 415);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(104, 28);
            this.btnPoista.TabIndex = 25;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(413, 12);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(471, 205);
            this.dgvAsiakkaat.TabIndex = 26;
            // 
            // btnhae
            // 
            this.btnhae.Location = new System.Drawing.Point(448, 451);
            this.btnhae.Name = "btnhae";
            this.btnhae.Size = new System.Drawing.Size(104, 28);
            this.btnhae.TabIndex = 27;
            this.btnhae.Text = "Hae";
            this.btnhae.UseVisualStyleBackColor = true;
            this.btnhae.Click += new System.EventHandler(this.btnhae_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(471, 205);
            this.dataGridView1.TabIndex = 28;
            // 
            // frmAsiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 491);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhae);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnLissee);
            this.Controls.Add(this.btnAsiakkaat);
            this.Controls.Add(this.dgwTest);
            this.Controls.Add(this.btnVarauksiin);
            this.Controls.Add(this.chkYritys);
            this.Controls.Add(this.chkYksityinen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPuhelin);
            this.Controls.Add(this.txtSahko);
            this.Controls.Add(this.txtPostiP);
            this.Controls.Add(this.cbPostiN);
            this.Controls.Add(this.txtPostiO);
            this.Controls.Add(this.txtSuku);
            this.Controls.Add(this.txtEtu);
            this.Name = "frmAsiakastiedot";
            this.Text = "Asiakastiedot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsiakastiedot_FormClosing);
            this.Load += new System.EventHandler(this.frmAsiakastiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEtu;
        private System.Windows.Forms.TextBox txtSuku;
        private System.Windows.Forms.TextBox txtPostiO;
        private System.Windows.Forms.ComboBox cbPostiN;
        private System.Windows.Forms.TextBox txtPuhelin;
        private System.Windows.Forms.TextBox txtSahko;
        private System.Windows.Forms.TextBox txtPostiP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkYksityinen;
        private System.Windows.Forms.CheckBox chkYritys;
        private System.Windows.Forms.Button btnVarauksiin;
        private System.Windows.Forms.DataGridView dgwTest;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnLissee;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.Button btnhae;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

