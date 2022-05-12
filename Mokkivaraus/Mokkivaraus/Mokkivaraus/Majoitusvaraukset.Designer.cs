namespace Mokkivaraus
{
    partial class Majoitusvaraukset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Majoitusvaraukset));
            this.dgwMajoitusvaraus = new System.Windows.Forms.DataGridView();
            this.cbAsiakas = new System.Windows.Forms.ComboBox();
            this.cbMokki = new System.Windows.Forms.ComboBox();
            this.dtpVarauspv = new System.Windows.Forms.DateTimePicker();
            this.dtpVahvistuspv = new System.Windows.Forms.DateTimePicker();
            this.dtpVarauksenAlkupv = new System.Windows.Forms.DateTimePicker();
            this.dtpVarauksenLoppupv = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPaivitaMajoitus = new System.Windows.Forms.Button();
            this.btnPoista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitusvaraus)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwMajoitusvaraus
            // 
            this.dgwMajoitusvaraus.AllowUserToAddRows = false;
            this.dgwMajoitusvaraus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgwMajoitusvaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMajoitusvaraus.Location = new System.Drawing.Point(32, 12);
            this.dgwMajoitusvaraus.Name = "dgwMajoitusvaraus";
            this.dgwMajoitusvaraus.Size = new System.Drawing.Size(786, 244);
            this.dgwMajoitusvaraus.TabIndex = 0;
            this.dgwMajoitusvaraus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMajoitusvaraus_CellClick);
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(100, 9);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(207, 32);
            this.cbAsiakas.TabIndex = 5;
            // 
            // cbMokki
            // 
            this.cbMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(100, 49);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(207, 32);
            this.cbMokki.TabIndex = 6;
            // 
            // dtpVarauspv
            // 
            this.dtpVarauspv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauspv.Enabled = false;
            this.dtpVarauspv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVarauspv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauspv.Location = new System.Drawing.Point(158, 18);
            this.dtpVarauspv.Name = "dtpVarauspv";
            this.dtpVarauspv.Size = new System.Drawing.Size(161, 29);
            this.dtpVarauspv.TabIndex = 7;
            // 
            // dtpVahvistuspv
            // 
            this.dtpVahvistuspv.CustomFormat = "yyyy-MM-dd";
            this.dtpVahvistuspv.Enabled = false;
            this.dtpVahvistuspv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVahvistuspv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVahvistuspv.Location = new System.Drawing.Point(158, 53);
            this.dtpVahvistuspv.Name = "dtpVahvistuspv";
            this.dtpVahvistuspv.Size = new System.Drawing.Size(161, 29);
            this.dtpVahvistuspv.TabIndex = 8;
            // 
            // dtpVarauksenAlkupv
            // 
            this.dtpVarauksenAlkupv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksenAlkupv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVarauksenAlkupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksenAlkupv.Location = new System.Drawing.Point(246, 15);
            this.dtpVarauksenAlkupv.Name = "dtpVarauksenAlkupv";
            this.dtpVarauksenAlkupv.Size = new System.Drawing.Size(161, 29);
            this.dtpVarauksenAlkupv.TabIndex = 9;
            // 
            // dtpVarauksenLoppupv
            // 
            this.dtpVarauksenLoppupv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksenLoppupv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVarauksenLoppupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksenLoppupv.Location = new System.Drawing.Point(246, 52);
            this.dtpVarauksenLoppupv.Name = "dtpVarauksenLoppupv";
            this.dtpVarauksenLoppupv.Size = new System.Drawing.Size(161, 29);
            this.dtpVarauksenLoppupv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Varauspäivä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vahvistuspäivä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Varauksen alkupäivä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Varauksen päättymispäivä";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Asiakas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mökki";
            // 
            // btnPaivitaMajoitus
            // 
            this.btnPaivitaMajoitus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaivitaMajoitus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivitaMajoitus.Location = new System.Drawing.Point(666, 376);
            this.btnPaivitaMajoitus.Name = "btnPaivitaMajoitus";
            this.btnPaivitaMajoitus.Size = new System.Drawing.Size(152, 84);
            this.btnPaivitaMajoitus.TabIndex = 17;
            this.btnPaivitaMajoitus.Text = "Päivitä varaus";
            this.btnPaivitaMajoitus.UseVisualStyleBackColor = false;
            this.btnPaivitaMajoitus.Click += new System.EventHandler(this.btnPaivitaMajoitus_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPoista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoista.Location = new System.Drawing.Point(468, 376);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(152, 84);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista varaus";
            this.btnPoista.UseVisualStyleBackColor = false;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbAsiakas);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbMokki);
            this.panel1.Location = new System.Drawing.Point(468, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 100);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpVarauspv);
            this.panel2.Controls.Add(this.dtpVahvistuspv);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(32, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 100);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dtpVarauksenLoppupv);
            this.panel3.Controls.Add(this.dtpVarauksenAlkupv);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(32, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 100);
            this.panel3.TabIndex = 21;
            // 
            // Majoitusvaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(846, 486);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPaivitaMajoitus);
            this.Controls.Add(this.dgwMajoitusvaraus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Majoitusvaraukset";
            this.Text = "Majoitusvaraukset";
            this.Load += new System.EventHandler(this.Majoitusvaraukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitusvaraus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMajoitusvaraus;
        private System.Windows.Forms.ComboBox cbAsiakas;
        private System.Windows.Forms.ComboBox cbMokki;
        private System.Windows.Forms.DateTimePicker dtpVarauspv;
        private System.Windows.Forms.DateTimePicker dtpVahvistuspv;
        private System.Windows.Forms.DateTimePicker dtpVarauksenAlkupv;
        private System.Windows.Forms.DateTimePicker dtpVarauksenLoppupv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPaivitaMajoitus;
        private System.Windows.Forms.Button btnPoista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}