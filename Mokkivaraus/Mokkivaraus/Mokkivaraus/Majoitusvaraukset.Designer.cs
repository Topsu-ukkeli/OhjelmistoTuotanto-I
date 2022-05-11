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
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitusvaraus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMajoitusvaraus
            // 
            this.dgwMajoitusvaraus.AllowUserToAddRows = false;
            this.dgwMajoitusvaraus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMajoitusvaraus.Location = new System.Drawing.Point(32, 12);
            this.dgwMajoitusvaraus.Name = "dgwMajoitusvaraus";
            this.dgwMajoitusvaraus.Size = new System.Drawing.Size(899, 244);
            this.dgwMajoitusvaraus.TabIndex = 0;
            this.dgwMajoitusvaraus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMajoitusvaraus_CellClick);
            // 
            // cbAsiakas
            // 
            this.cbAsiakas.FormattingEnabled = true;
            this.cbAsiakas.Location = new System.Drawing.Point(722, 288);
            this.cbAsiakas.Name = "cbAsiakas";
            this.cbAsiakas.Size = new System.Drawing.Size(209, 21);
            this.cbAsiakas.TabIndex = 5;
            // 
            // cbMokki
            // 
            this.cbMokki.FormattingEnabled = true;
            this.cbMokki.Location = new System.Drawing.Point(750, 357);
            this.cbMokki.Name = "cbMokki";
            this.cbMokki.Size = new System.Drawing.Size(181, 21);
            this.cbMokki.TabIndex = 6;
            // 
            // dtpVarauspv
            // 
            this.dtpVarauspv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauspv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauspv.Location = new System.Drawing.Point(120, 286);
            this.dtpVarauspv.Name = "dtpVarauspv";
            this.dtpVarauspv.Size = new System.Drawing.Size(161, 20);
            this.dtpVarauspv.TabIndex = 7;
            // 
            // dtpVahvistuspv
            // 
            this.dtpVahvistuspv.CustomFormat = "yyyy-MM-dd";
            this.dtpVahvistuspv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVahvistuspv.Location = new System.Drawing.Point(120, 354);
            this.dtpVahvistuspv.Name = "dtpVahvistuspv";
            this.dtpVahvistuspv.Size = new System.Drawing.Size(161, 20);
            this.dtpVahvistuspv.TabIndex = 8;
            // 
            // dtpVarauksenAlkupv
            // 
            this.dtpVarauksenAlkupv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksenAlkupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksenAlkupv.Location = new System.Drawing.Point(466, 288);
            this.dtpVarauksenAlkupv.Name = "dtpVarauksenAlkupv";
            this.dtpVarauksenAlkupv.Size = new System.Drawing.Size(161, 20);
            this.dtpVarauksenAlkupv.TabIndex = 9;
            // 
            // dtpVarauksenLoppupv
            // 
            this.dtpVarauksenLoppupv.CustomFormat = "yyyy-MM-dd";
            this.dtpVarauksenLoppupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVarauksenLoppupv.Location = new System.Drawing.Point(502, 354);
            this.dtpVarauksenLoppupv.Name = "dtpVarauksenLoppupv";
            this.dtpVarauksenLoppupv.Size = new System.Drawing.Size(161, 20);
            this.dtpVarauksenLoppupv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Varauspäivä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vahvistuspäivä";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Varauksen alkupäivä";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Varauksen päättymispäivä";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(650, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Asiakas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(685, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mökki";
            // 
            // btnPaivitaMajoitus
            // 
            this.btnPaivitaMajoitus.Location = new System.Drawing.Point(821, 451);
            this.btnPaivitaMajoitus.Name = "btnPaivitaMajoitus";
            this.btnPaivitaMajoitus.Size = new System.Drawing.Size(110, 45);
            this.btnPaivitaMajoitus.TabIndex = 17;
            this.btnPaivitaMajoitus.Text = "Päivitä varaus";
            this.btnPaivitaMajoitus.UseVisualStyleBackColor = true;
            this.btnPaivitaMajoitus.Click += new System.EventHandler(this.btnPaivitaMajoitus_Click);
            // 
            // btnPoista
            // 
            this.btnPoista.Location = new System.Drawing.Point(702, 451);
            this.btnPoista.Name = "btnPoista";
            this.btnPoista.Size = new System.Drawing.Size(110, 45);
            this.btnPoista.TabIndex = 18;
            this.btnPoista.Text = "Poista varaus";
            this.btnPoista.UseVisualStyleBackColor = true;
            this.btnPoista.Click += new System.EventHandler(this.btnPoista_Click);
            // 
            // Majoitusvaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 508);
            this.Controls.Add(this.btnPoista);
            this.Controls.Add(this.btnPaivitaMajoitus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpVarauksenLoppupv);
            this.Controls.Add(this.dtpVarauksenAlkupv);
            this.Controls.Add(this.dtpVahvistuspv);
            this.Controls.Add(this.dtpVarauspv);
            this.Controls.Add(this.cbMokki);
            this.Controls.Add(this.cbAsiakas);
            this.Controls.Add(this.dgwMajoitusvaraus);
            this.Name = "Majoitusvaraukset";
            this.Text = "Majoitusvaraukset";
            this.Load += new System.EventHandler(this.Majoitusvaraukset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitusvaraus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}