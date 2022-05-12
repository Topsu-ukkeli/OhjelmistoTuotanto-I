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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsiakastiedot));
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
            this.btnVarauksiin = new System.Windows.Forms.Button();
            this.dgwTest = new System.Windows.Forms.DataGridView();
            this.btnLissee = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.dgvAsiakkaat = new System.Windows.Forms.DataGridView();
            this.dgwVali = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.dgwPostinro = new System.Windows.Forms.DataGridView();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEtu
            // 
            this.txtEtu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtu.Location = new System.Drawing.Point(155, 62);
            this.txtEtu.Name = "txtEtu";
            this.txtEtu.Size = new System.Drawing.Size(222, 26);
            this.txtEtu.TabIndex = 0;
            // 
            // txtSuku
            // 
            this.txtSuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuku.Location = new System.Drawing.Point(155, 104);
            this.txtSuku.Name = "txtSuku";
            this.txtSuku.Size = new System.Drawing.Size(222, 26);
            this.txtSuku.TabIndex = 1;
            // 
            // txtPostiO
            // 
            this.txtPostiO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostiO.Location = new System.Drawing.Point(155, 150);
            this.txtPostiO.Name = "txtPostiO";
            this.txtPostiO.Size = new System.Drawing.Size(222, 26);
            this.txtPostiO.TabIndex = 2;
            // 
            // cbPostiN
            // 
            this.cbPostiN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPostiN.FormattingEnabled = true;
            this.cbPostiN.Location = new System.Drawing.Point(155, 196);
            this.cbPostiN.Name = "cbPostiN";
            this.cbPostiN.Size = new System.Drawing.Size(222, 28);
            this.cbPostiN.TabIndex = 3;
            this.cbPostiN.TextChanged += new System.EventHandler(this.cbPostiN_TextChanged);
            // 
            // txtPuhelin
            // 
            this.txtPuhelin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuhelin.Location = new System.Drawing.Point(155, 340);
            this.txtPuhelin.Name = "txtPuhelin";
            this.txtPuhelin.Size = new System.Drawing.Size(222, 26);
            this.txtPuhelin.TabIndex = 6;
            // 
            // txtSahko
            // 
            this.txtSahko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSahko.Location = new System.Drawing.Point(155, 294);
            this.txtSahko.Name = "txtSahko";
            this.txtSahko.Size = new System.Drawing.Size(222, 26);
            this.txtSahko.TabIndex = 5;
            // 
            // txtPostiP
            // 
            this.txtPostiP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostiP.Location = new System.Drawing.Point(155, 246);
            this.txtPostiP.Name = "txtPostiP";
            this.txtPostiP.Size = new System.Drawing.Size(222, 26);
            this.txtPostiP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Postiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Postitoimipaikka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sähköposti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Puhelinnumero";
            // 
            // btnVarauksiin
            // 
            this.btnVarauksiin.BackColor = System.Drawing.Color.Orange;
            this.btnVarauksiin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarauksiin.Location = new System.Drawing.Point(1014, 343);
            this.btnVarauksiin.Name = "btnVarauksiin";
            this.btnVarauksiin.Size = new System.Drawing.Size(145, 74);
            this.btnVarauksiin.TabIndex = 10;
            this.btnVarauksiin.Text = "Siirry mökin valintaan";
            this.btnVarauksiin.UseVisualStyleBackColor = false;
            this.btnVarauksiin.Click += new System.EventHandler(this.btnVarauksiin_Click);
            // 
            // dgwTest
            // 
            this.dgwTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTest.Location = new System.Drawing.Point(829, 207);
            this.dgwTest.Name = "dgwTest";
            this.dgwTest.Size = new System.Drawing.Size(10, 10);
            this.dgwTest.TabIndex = 23;
            this.dgwTest.Visible = false;
            // 
            // btnLissee
            // 
            this.btnLissee.BackColor = System.Drawing.Color.Orange;
            this.btnLissee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLissee.Location = new System.Drawing.Point(41, 348);
            this.btnLissee.Name = "btnLissee";
            this.btnLissee.Size = new System.Drawing.Size(104, 65);
            this.btnLissee.TabIndex = 24;
            this.btnLissee.Text = "Lisää";
            this.btnLissee.UseVisualStyleBackColor = false;
            this.btnLissee.Click += new System.EventHandler(this.btnLissee_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.Color.Orange;
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(261, 348);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(104, 65);
            this.btnPoista.TabIndex = 25;
            this.btnPoista.Text = "Poista";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // dgvAsiakkaat
            // 
            this.dgvAsiakkaat.AllowUserToAddRows = false;
            this.dgvAsiakkaat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAsiakkaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsiakkaat.Location = new System.Drawing.Point(405, 61);
            this.dgvAsiakkaat.Name = "dgvAsiakkaat";
            this.dgvAsiakkaat.Size = new System.Drawing.Size(766, 205);
            this.dgvAsiakkaat.TabIndex = 26;
            this.dgvAsiakkaat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsiakkaat_CellClick);
            this.dgvAsiakkaat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsiakkaat_CellContentClick);
            // 
            // dgwVali
            // 
            this.dgwVali.AllowUserToAddRows = false;
            this.dgwVali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwVali.Location = new System.Drawing.Point(2000, 2000);
            this.dgwVali.Name = "dgwVali";
            this.dgwVali.Size = new System.Drawing.Size(10, 10);
            this.dgwVali.TabIndex = 27;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(2000, 1000);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "0";
            // 
            // dgwPostinro
            // 
            this.dgwPostinro.AllowUserToAddRows = false;
            this.dgwPostinro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPostinro.Location = new System.Drawing.Point(741, 114);
            this.dgwPostinro.Name = "dgwPostinro";
            this.dgwPostinro.Size = new System.Drawing.Size(10, 10);
            this.dgwPostinro.TabIndex = 29;
            // 
            // btnPaivita
            // 
            this.btnPaivita.BackColor = System.Drawing.Color.Orange;
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(151, 348);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(104, 65);
            this.btnPaivita.TabIndex = 30;
            this.btnPaivita.Text = "Päivitä tiedot";
            this.btnPaivita.UseVisualStyleBackColor = false;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnPaivita);
            this.panel1.Controls.Add(this.btnVarauksiin);
            this.panel1.Controls.Add(this.btnLissee);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnPoista);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 430);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmAsiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1212, 493);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgwVali);
            this.Controls.Add(this.dgvAsiakkaat);
            this.Controls.Add(this.txtPuhelin);
            this.Controls.Add(this.txtSahko);
            this.Controls.Add(this.txtPostiP);
            this.Controls.Add(this.cbPostiN);
            this.Controls.Add(this.txtPostiO);
            this.Controls.Add(this.txtSuku);
            this.Controls.Add(this.txtEtu);
            this.Controls.Add(this.dgwPostinro);
            this.Controls.Add(this.dgwTest);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsiakastiedot";
            this.Text = "Asiakastiedot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAsiakastiedot_FormClosing);
            this.Load += new System.EventHandler(this.frmAsiakastiedot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiakkaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPostinro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button btnVarauksiin;
        private System.Windows.Forms.DataGridView dgwTest;
        private System.Windows.Forms.Button btnLissee;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.DataGridView dgvAsiakkaat;
        private System.Windows.Forms.DataGridView dgwVali;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgwPostinro;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.Panel panel1;
    }
}

