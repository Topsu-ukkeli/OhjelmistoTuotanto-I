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
            this.dtpSyntyma = new System.Windows.Forms.DateTimePicker();
            this.dtpSaapumis = new System.Windows.Forms.DateTimePicker();
            this.dtpPoistumis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkYksityinen = new System.Windows.Forms.CheckBox();
            this.chkYritys = new System.Windows.Forms.CheckBox();
            this.btnVarauksiin = new System.Windows.Forms.Button();
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
            // dtpSyntyma
            // 
            this.dtpSyntyma.Location = new System.Drawing.Point(155, 413);
            this.dtpSyntyma.Name = "dtpSyntyma";
            this.dtpSyntyma.Size = new System.Drawing.Size(222, 20);
            this.dtpSyntyma.TabIndex = 7;
            // 
            // dtpSaapumis
            // 
            this.dtpSaapumis.Location = new System.Drawing.Point(534, 62);
            this.dtpSaapumis.Name = "dtpSaapumis";
            this.dtpSaapumis.Size = new System.Drawing.Size(222, 20);
            this.dtpSaapumis.TabIndex = 8;
            // 
            // dtpPoistumis
            // 
            this.dtpPoistumis.Location = new System.Drawing.Point(534, 104);
            this.dtpPoistumis.Name = "dtpPoistumis";
            this.dtpPoistumis.Size = new System.Drawing.Size(222, 20);
            this.dtpPoistumis.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Etunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sukunimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Postiosoite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Postinumero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Postitoimipaikka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sähköposti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Puhelinnumero";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Syntymäaika";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(437, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Saapumispäivä";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(437, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Poistumispäivä";
            // 
            // chkYksityinen
            // 
            this.chkYksityinen.AutoSize = true;
            this.chkYksityinen.Location = new System.Drawing.Point(155, 28);
            this.chkYksityinen.Name = "chkYksityinen";
            this.chkYksityinen.Size = new System.Drawing.Size(74, 17);
            this.chkYksityinen.TabIndex = 20;
            this.chkYksityinen.Text = "Yksityinen";
            this.chkYksityinen.UseVisualStyleBackColor = true;
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
            // 
            // btnVarauksiin
            // 
            this.btnVarauksiin.Location = new System.Drawing.Point(648, 387);
            this.btnVarauksiin.Name = "btnVarauksiin";
            this.btnVarauksiin.Size = new System.Drawing.Size(108, 46);
            this.btnVarauksiin.TabIndex = 22;
            this.btnVarauksiin.Text = "Siirry mökin valintaan";
            this.btnVarauksiin.UseVisualStyleBackColor = true;
            this.btnVarauksiin.Click += new System.EventHandler(this.btnVarauksiin_Click);
            // 
            // frmAsiakastiedot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 488);
            this.Controls.Add(this.btnVarauksiin);
            this.Controls.Add(this.chkYritys);
            this.Controls.Add(this.chkYksityinen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPoistumis);
            this.Controls.Add(this.dtpSaapumis);
            this.Controls.Add(this.dtpSyntyma);
            this.Controls.Add(this.txtPuhelin);
            this.Controls.Add(this.txtSahko);
            this.Controls.Add(this.txtPostiP);
            this.Controls.Add(this.cbPostiN);
            this.Controls.Add(this.txtPostiO);
            this.Controls.Add(this.txtSuku);
            this.Controls.Add(this.txtEtu);
            this.Name = "frmAsiakastiedot";
            this.Text = "Asiakastiedot";
            this.Load += new System.EventHandler(this.frmAsiakastiedot_Load);
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
        private System.Windows.Forms.DateTimePicker dtpSyntyma;
        private System.Windows.Forms.DateTimePicker dtpSaapumis;
        private System.Windows.Forms.DateTimePicker dtpPoistumis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkYksityinen;
        private System.Windows.Forms.CheckBox chkYritys;
        private System.Windows.Forms.Button btnVarauksiin;
    }
}

