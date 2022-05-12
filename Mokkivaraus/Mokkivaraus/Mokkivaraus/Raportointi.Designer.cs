namespace Mokkivaraus
{
    partial class Raportointi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raportointi));
            this.dgwMajoitus = new System.Windows.Forms.DataGridView();
            this.dtpAlkupv = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppupv = new System.Windows.Forms.DateTimePicker();
            this.btnHae = new System.Windows.Forms.Button();
            this.btnHaeAlue = new System.Windows.Forms.Button();
            this.cbAlueet = new System.Windows.Forms.ComboBox();
            this.dgwPalveluID = new System.Windows.Forms.DataGridView();
            this.lbNimet = new System.Windows.Forms.ListBox();
            this.lblHinnat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalveluID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMajoitus
            // 
            this.dgwMajoitus.AllowUserToAddRows = false;
            this.dgwMajoitus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMajoitus.Location = new System.Drawing.Point(24, 82);
            this.dgwMajoitus.Name = "dgwMajoitus";
            this.dgwMajoitus.Size = new System.Drawing.Size(739, 303);
            this.dgwMajoitus.TabIndex = 0;
            // 
            // dtpAlkupv
            // 
            this.dtpAlkupv.CustomFormat = "yyyy-MM-dd";
            this.dtpAlkupv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAlkupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlkupv.Location = new System.Drawing.Point(364, 395);
            this.dtpAlkupv.Name = "dtpAlkupv";
            this.dtpAlkupv.Size = new System.Drawing.Size(200, 26);
            this.dtpAlkupv.TabIndex = 2;
            // 
            // dtpLoppupv
            // 
            this.dtpLoppupv.CustomFormat = "yyyy-MM-dd";
            this.dtpLoppupv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoppupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppupv.Location = new System.Drawing.Point(364, 434);
            this.dtpLoppupv.Name = "dtpLoppupv";
            this.dtpLoppupv.Size = new System.Drawing.Size(200, 26);
            this.dtpLoppupv.TabIndex = 3;
            // 
            // btnHae
            // 
            this.btnHae.BackColor = System.Drawing.Color.Orange;
            this.btnHae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHae.Location = new System.Drawing.Point(589, 393);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(174, 67);
            this.btnHae.TabIndex = 4;
            this.btnHae.Text = "Hae päivämäärän mukaan";
            this.btnHae.UseVisualStyleBackColor = false;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // btnHaeAlue
            // 
            this.btnHaeAlue.BackColor = System.Drawing.Color.Orange;
            this.btnHaeAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaeAlue.Location = new System.Drawing.Point(1061, 391);
            this.btnHaeAlue.Name = "btnHaeAlue";
            this.btnHaeAlue.Size = new System.Drawing.Size(135, 67);
            this.btnHaeAlue.TabIndex = 5;
            this.btnHaeAlue.Text = "Hae Aluiden palvelut";
            this.btnHaeAlue.UseVisualStyleBackColor = false;
            this.btnHaeAlue.Click += new System.EventHandler(this.btnHaeAlue_Click);
            // 
            // cbAlueet
            // 
            this.cbAlueet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlueet.FormattingEnabled = true;
            this.cbAlueet.Location = new System.Drawing.Point(796, 424);
            this.cbAlueet.Name = "cbAlueet";
            this.cbAlueet.Size = new System.Drawing.Size(209, 28);
            this.cbAlueet.TabIndex = 6;
            // 
            // dgwPalveluID
            // 
            this.dgwPalveluID.AllowUserToAddRows = false;
            this.dgwPalveluID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPalveluID.Location = new System.Drawing.Point(668, 214);
            this.dgwPalveluID.Name = "dgwPalveluID";
            this.dgwPalveluID.Size = new System.Drawing.Size(10, 10);
            this.dgwPalveluID.TabIndex = 7;
            // 
            // lbNimet
            // 
            this.lbNimet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNimet.FormattingEnabled = true;
            this.lbNimet.ItemHeight = 25;
            this.lbNimet.Location = new System.Drawing.Point(796, 82);
            this.lbNimet.Name = "lbNimet";
            this.lbNimet.Size = new System.Drawing.Size(400, 304);
            this.lbNimet.TabIndex = 8;
            // 
            // lblHinnat
            // 
            this.lblHinnat.AutoSize = true;
            this.lblHinnat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHinnat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinnat.Location = new System.Drawing.Point(796, 396);
            this.lblHinnat.Name = "lblHinnat";
            this.lblHinnat.Size = new System.Drawing.Size(124, 25);
            this.lblHinnat.TabIndex = 25;
            this.lblHinnat.Text = "Valitse alue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Varauksen alkamispäivä";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Varauksen päättymispäivä";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(17, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 453);
            this.panel1.TabIndex = 28;
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1222, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHinnat);
            this.Controls.Add(this.lbNimet);
            this.Controls.Add(this.cbAlueet);
            this.Controls.Add(this.btnHaeAlue);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.dtpLoppupv);
            this.Controls.Add(this.dtpAlkupv);
            this.Controls.Add(this.dgwMajoitus);
            this.Controls.Add(this.dgwPalveluID);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalveluID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMajoitus;
        private System.Windows.Forms.DateTimePicker dtpAlkupv;
        private System.Windows.Forms.DateTimePicker dtpLoppupv;
        private System.Windows.Forms.Button btnHae;
        private System.Windows.Forms.Button btnHaeAlue;
        private System.Windows.Forms.ComboBox cbAlueet;
        private System.Windows.Forms.DataGridView dgwPalveluID;
        private System.Windows.Forms.ListBox lbNimet;
        private System.Windows.Forms.Label lblHinnat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}