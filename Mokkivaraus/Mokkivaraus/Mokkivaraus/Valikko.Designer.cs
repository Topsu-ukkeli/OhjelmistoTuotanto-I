
namespace Mokkivaraus
{
    partial class Valikko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Valikko));
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRaportointi = new System.Windows.Forms.Button();
            this.btnLaskuihin = new System.Windows.Forms.Button();
            this.btnMokkiAlue = new System.Windows.Forms.Button();
            this.btnPalveluihin = new System.Windows.Forms.Button();
            this.btnVarauksiin = new System.Windows.Forms.Button();
            this.btnUusivaraus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOtsikko
            // 
            this.lblOtsikko.AutoSize = true;
            this.lblOtsikko.BackColor = System.Drawing.Color.Orange;
            this.lblOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtsikko.Location = new System.Drawing.Point(97, 26);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(360, 42);
            this.lblOtsikko.TabIndex = 0;
            this.lblOtsikko.Text = "Village Newbies Oy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mökkien varausjärjestelmä";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnRaportointi);
            this.panel1.Controls.Add(this.btnLaskuihin);
            this.panel1.Controls.Add(this.btnMokkiAlue);
            this.panel1.Controls.Add(this.btnPalveluihin);
            this.panel1.Controls.Add(this.btnVarauksiin);
            this.panel1.Controls.Add(this.btnUusivaraus);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 356);
            this.panel1.TabIndex = 2;
            // 
            // btnRaportointi
            // 
            this.btnRaportointi.BackColor = System.Drawing.Color.Orange;
            this.btnRaportointi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportointi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRaportointi.Location = new System.Drawing.Point(328, 174);
            this.btnRaportointi.Name = "btnRaportointi";
            this.btnRaportointi.Size = new System.Drawing.Size(145, 120);
            this.btnRaportointi.TabIndex = 5;
            this.btnRaportointi.Text = "Seuranta";
            this.btnRaportointi.UseVisualStyleBackColor = false;
            this.btnRaportointi.Click += new System.EventHandler(this.btnRaportointi_Click);
            // 
            // btnLaskuihin
            // 
            this.btnLaskuihin.BackColor = System.Drawing.Color.Orange;
            this.btnLaskuihin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskuihin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLaskuihin.Location = new System.Drawing.Point(26, 48);
            this.btnLaskuihin.Name = "btnLaskuihin";
            this.btnLaskuihin.Size = new System.Drawing.Size(145, 120);
            this.btnLaskuihin.TabIndex = 4;
            this.btnLaskuihin.Text = "Laskujen hallinta";
            this.btnLaskuihin.UseVisualStyleBackColor = false;
            this.btnLaskuihin.Click += new System.EventHandler(this.btnLaskuihin_Click);
            // 
            // btnMokkiAlue
            // 
            this.btnMokkiAlue.BackColor = System.Drawing.Color.Orange;
            this.btnMokkiAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokkiAlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMokkiAlue.Location = new System.Drawing.Point(177, 48);
            this.btnMokkiAlue.Name = "btnMokkiAlue";
            this.btnMokkiAlue.Size = new System.Drawing.Size(145, 120);
            this.btnMokkiAlue.TabIndex = 3;
            this.btnMokkiAlue.Text = "Mökki/alue hallinta";
            this.btnMokkiAlue.UseVisualStyleBackColor = false;
            this.btnMokkiAlue.Click += new System.EventHandler(this.btnMokkiAlue_Click);
            // 
            // btnPalveluihin
            // 
            this.btnPalveluihin.BackColor = System.Drawing.Color.Orange;
            this.btnPalveluihin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalveluihin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPalveluihin.Location = new System.Drawing.Point(177, 174);
            this.btnPalveluihin.Name = "btnPalveluihin";
            this.btnPalveluihin.Size = new System.Drawing.Size(145, 120);
            this.btnPalveluihin.TabIndex = 2;
            this.btnPalveluihin.Text = "Palveluiden hallinta";
            this.btnPalveluihin.UseVisualStyleBackColor = false;
            this.btnPalveluihin.Click += new System.EventHandler(this.btnPalveluihin_Click);
            // 
            // btnVarauksiin
            // 
            this.btnVarauksiin.BackColor = System.Drawing.Color.Orange;
            this.btnVarauksiin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarauksiin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVarauksiin.Location = new System.Drawing.Point(26, 174);
            this.btnVarauksiin.Name = "btnVarauksiin";
            this.btnVarauksiin.Size = new System.Drawing.Size(145, 120);
            this.btnVarauksiin.TabIndex = 1;
            this.btnVarauksiin.Text = "Varausten hallinta";
            this.btnVarauksiin.UseVisualStyleBackColor = false;
            this.btnVarauksiin.Click += new System.EventHandler(this.btnVarauksiin_Click);
            // 
            // btnUusivaraus
            // 
            this.btnUusivaraus.BackColor = System.Drawing.Color.Orange;
            this.btnUusivaraus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUusivaraus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUusivaraus.Location = new System.Drawing.Point(328, 48);
            this.btnUusivaraus.Name = "btnUusivaraus";
            this.btnUusivaraus.Size = new System.Drawing.Size(145, 120);
            this.btnUusivaraus.TabIndex = 0;
            this.btnUusivaraus.Text = "Uusi varaus";
            this.btnUusivaraus.UseVisualStyleBackColor = false;
            this.btnUusivaraus.Click += new System.EventHandler(this.btnUusivaraus_Click);
            // 
            // Valikko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(529, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOtsikko);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Valikko";
            this.Text = "Valikko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Valikko_FormClosing);
            this.Load += new System.EventHandler(this.Valikko_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtsikko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMokkiAlue;
        private System.Windows.Forms.Button btnPalveluihin;
        private System.Windows.Forms.Button btnVarauksiin;
        private System.Windows.Forms.Button btnUusivaraus;
        private System.Windows.Forms.Button btnLaskuihin;
        private System.Windows.Forms.Button btnRaportointi;
    }
}