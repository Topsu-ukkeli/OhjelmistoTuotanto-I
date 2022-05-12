
namespace Mokkivaraus
{
    partial class LaskuHallinta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaskuHallinta));
            this.dgvLaskut = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLaskuID = new System.Windows.Forms.TextBox();
            this.tbVarausID = new System.Windows.Forms.TextBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbAlv = new System.Windows.Forms.TextBox();
            this.tbTilanne = new System.Windows.Forms.TextBox();
            this.tbMaksaja = new System.Windows.Forms.TextBox();
            this.btnPaivita = new System.Windows.Forms.Button();
            this.cbMerkitse = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLaskut
            // 
            this.dgvLaskut.AllowUserToAddRows = false;
            this.dgvLaskut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaskut.Location = new System.Drawing.Point(12, 12);
            this.dgvLaskut.Name = "dgvLaskut";
            this.dgvLaskut.ReadOnly = true;
            this.dgvLaskut.Size = new System.Drawing.Size(498, 522);
            this.dgvLaskut.TabIndex = 0;
            this.dgvLaskut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLaskut_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Laskutunnus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Summa";
            // 
            // alv
            // 
            this.alv.AutoSize = true;
            this.alv.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.alv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alv.Location = new System.Drawing.Point(805, 132);
            this.alv.Name = "alv";
            this.alv.Size = new System.Drawing.Size(46, 24);
            this.alv.TabIndex = 3;
            this.alv.Text = "ALV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varaustunnus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tilanne";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Maksaja";
            // 
            // tbLaskuID
            // 
            this.tbLaskuID.Enabled = false;
            this.tbLaskuID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLaskuID.Location = new System.Drawing.Point(135, 47);
            this.tbLaskuID.Name = "tbLaskuID";
            this.tbLaskuID.Size = new System.Drawing.Size(157, 29);
            this.tbLaskuID.TabIndex = 7;
            // 
            // tbVarausID
            // 
            this.tbVarausID.Enabled = false;
            this.tbVarausID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVarausID.Location = new System.Drawing.Point(135, 82);
            this.tbVarausID.Name = "tbVarausID";
            this.tbVarausID.Size = new System.Drawing.Size(157, 29);
            this.tbVarausID.TabIndex = 8;
            // 
            // tbSumma
            // 
            this.tbSumma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSumma.Location = new System.Drawing.Point(135, 117);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.Size = new System.Drawing.Size(157, 29);
            this.tbSumma.TabIndex = 9;
            // 
            // tbAlv
            // 
            this.tbAlv.Enabled = false;
            this.tbAlv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlv.Location = new System.Drawing.Point(341, 117);
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(75, 29);
            this.tbAlv.TabIndex = 10;
            // 
            // tbTilanne
            // 
            this.tbTilanne.Enabled = false;
            this.tbTilanne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTilanne.Location = new System.Drawing.Point(135, 152);
            this.tbTilanne.Name = "tbTilanne";
            this.tbTilanne.Size = new System.Drawing.Size(157, 29);
            this.tbTilanne.TabIndex = 11;
            // 
            // tbMaksaja
            // 
            this.tbMaksaja.Enabled = false;
            this.tbMaksaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaksaja.Location = new System.Drawing.Point(135, 217);
            this.tbMaksaja.Name = "tbMaksaja";
            this.tbMaksaja.Size = new System.Drawing.Size(157, 29);
            this.tbMaksaja.TabIndex = 12;
            // 
            // btnPaivita
            // 
            this.btnPaivita.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPaivita.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaivita.Location = new System.Drawing.Point(523, 298);
            this.btnPaivita.Name = "btnPaivita";
            this.btnPaivita.Size = new System.Drawing.Size(182, 86);
            this.btnPaivita.TabIndex = 13;
            this.btnPaivita.Text = "Päivitä laskun tiedot";
            this.btnPaivita.UseVisualStyleBackColor = false;
            this.btnPaivita.Click += new System.EventHandler(this.btnPaivita_Click);
            // 
            // cbMerkitse
            // 
            this.cbMerkitse.AutoSize = true;
            this.cbMerkitse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbMerkitse.Location = new System.Drawing.Point(135, 187);
            this.cbMerkitse.Name = "cbMerkitse";
            this.cbMerkitse.Size = new System.Drawing.Size(122, 17);
            this.cbMerkitse.TabIndex = 14;
            this.cbMerkitse.Text = "Merkitse maksetuksi";
            this.cbMerkitse.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbMerkitse);
            this.panel1.Controls.Add(this.tbLaskuID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMaksaja);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbTilanne);
            this.panel1.Controls.Add(this.tbAlv);
            this.panel1.Controls.Add(this.tbSumma);
            this.panel1.Controls.Add(this.tbVarausID);
            this.panel1.Location = new System.Drawing.Point(516, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 280);
            this.panel1.TabIndex = 15;
            // 
            // LaskuHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(956, 546);
            this.Controls.Add(this.btnPaivita);
            this.Controls.Add(this.alv);
            this.Controls.Add(this.dgvLaskut);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LaskuHallinta";
            this.Text = "LaskuHallinta";
            this.Load += new System.EventHandler(this.LaskuHallinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaskut)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaskut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label alv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLaskuID;
        private System.Windows.Forms.TextBox tbVarausID;
        private System.Windows.Forms.TextBox tbSumma;
        private System.Windows.Forms.TextBox tbAlv;
        private System.Windows.Forms.TextBox tbTilanne;
        private System.Windows.Forms.TextBox tbMaksaja;
        private System.Windows.Forms.Button btnPaivita;
        private System.Windows.Forms.CheckBox cbMerkitse;
        private System.Windows.Forms.Panel panel1;
    }
}