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
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalveluID)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMajoitus
            // 
            this.dgwMajoitus.AllowUserToAddRows = false;
            this.dgwMajoitus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMajoitus.Location = new System.Drawing.Point(12, 12);
            this.dgwMajoitus.Name = "dgwMajoitus";
            this.dgwMajoitus.Size = new System.Drawing.Size(739, 310);
            this.dgwMajoitus.TabIndex = 0;
            // 
            // dtpAlkupv
            // 
            this.dtpAlkupv.CustomFormat = "yyyy-MM-dd";
            this.dtpAlkupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlkupv.Location = new System.Drawing.Point(12, 360);
            this.dtpAlkupv.Name = "dtpAlkupv";
            this.dtpAlkupv.Size = new System.Drawing.Size(200, 20);
            this.dtpAlkupv.TabIndex = 2;
            // 
            // dtpLoppupv
            // 
            this.dtpLoppupv.CustomFormat = "yyyy-MM-dd";
            this.dtpLoppupv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppupv.Location = new System.Drawing.Point(551, 360);
            this.dtpLoppupv.Name = "dtpLoppupv";
            this.dtpLoppupv.Size = new System.Drawing.Size(200, 20);
            this.dtpLoppupv.TabIndex = 3;
            // 
            // btnHae
            // 
            this.btnHae.Location = new System.Drawing.Point(322, 431);
            this.btnHae.Name = "btnHae";
            this.btnHae.Size = new System.Drawing.Size(75, 23);
            this.btnHae.TabIndex = 4;
            this.btnHae.Text = "KYS";
            this.btnHae.UseVisualStyleBackColor = true;
            this.btnHae.Click += new System.EventHandler(this.btnHae_Click);
            // 
            // btnHaeAlue
            // 
            this.btnHaeAlue.Location = new System.Drawing.Point(784, 330);
            this.btnHaeAlue.Name = "btnHaeAlue";
            this.btnHaeAlue.Size = new System.Drawing.Size(75, 23);
            this.btnHaeAlue.TabIndex = 5;
            this.btnHaeAlue.Text = "KYS2.0";
            this.btnHaeAlue.UseVisualStyleBackColor = true;
            this.btnHaeAlue.Click += new System.EventHandler(this.btnHaeAlue_Click);
            // 
            // cbAlueet
            // 
            this.cbAlueet.FormattingEnabled = true;
            this.cbAlueet.Location = new System.Drawing.Point(975, 330);
            this.cbAlueet.Name = "cbAlueet";
            this.cbAlueet.Size = new System.Drawing.Size(209, 21);
            this.cbAlueet.TabIndex = 6;
            // 
            // dgwPalveluID
            // 
            this.dgwPalveluID.AllowUserToAddRows = false;
            this.dgwPalveluID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPalveluID.Location = new System.Drawing.Point(654, 244);
            this.dgwPalveluID.Name = "dgwPalveluID";
            this.dgwPalveluID.Size = new System.Drawing.Size(10, 10);
            this.dgwPalveluID.TabIndex = 7;
            // 
            // lbNimet
            // 
            this.lbNimet.FormattingEnabled = true;
            this.lbNimet.Location = new System.Drawing.Point(784, 12);
            this.lbNimet.Name = "lbNimet";
            this.lbNimet.Size = new System.Drawing.Size(400, 303);
            this.lbNimet.TabIndex = 8;
            // 
            // Raportointi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 647);
            this.Controls.Add(this.lbNimet);
            this.Controls.Add(this.cbAlueet);
            this.Controls.Add(this.btnHaeAlue);
            this.Controls.Add(this.btnHae);
            this.Controls.Add(this.dtpLoppupv);
            this.Controls.Add(this.dtpAlkupv);
            this.Controls.Add(this.dgwMajoitus);
            this.Controls.Add(this.dgwPalveluID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Raportointi";
            this.Text = "Raportointi";
            this.Load += new System.EventHandler(this.Raportointi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMajoitus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPalveluID)).EndInit();
            this.ResumeLayout(false);

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
    }
}