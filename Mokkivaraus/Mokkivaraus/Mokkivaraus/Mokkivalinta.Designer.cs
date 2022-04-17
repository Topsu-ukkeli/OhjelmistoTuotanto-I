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
            this.dgwMokkivalinta = new System.Windows.Forms.DataGridView();
            this.chkPaikanP = new System.Windows.Forms.CheckBox();
            this.chkLasku = new System.Windows.Forms.CheckBox();
            this.btnVaraaM = new System.Windows.Forms.Button();
            this.btnAsiakkaisiin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMokkivalinta
            // 
            this.dgwMokkivalinta.AllowUserToAddRows = false;
            this.dgwMokkivalinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMokkivalinta.Location = new System.Drawing.Point(12, 12);
            this.dgwMokkivalinta.Name = "dgwMokkivalinta";
            this.dgwMokkivalinta.Size = new System.Drawing.Size(1040, 223);
            this.dgwMokkivalinta.TabIndex = 0;
            // 
            // chkPaikanP
            // 
            this.chkPaikanP.AutoSize = true;
            this.chkPaikanP.Location = new System.Drawing.Point(12, 254);
            this.chkPaikanP.Name = "chkPaikanP";
            this.chkPaikanP.Size = new System.Drawing.Size(120, 17);
            this.chkPaikanP.TabIndex = 1;
            this.chkPaikanP.Text = "maksa paikanpäällä";
            this.chkPaikanP.UseVisualStyleBackColor = true;
            this.chkPaikanP.CheckedChanged += new System.EventHandler(this.chkPaikanP_CheckedChanged);
            // 
            // chkLasku
            // 
            this.chkLasku.AutoSize = true;
            this.chkLasku.Location = new System.Drawing.Point(138, 254);
            this.chkLasku.Name = "chkLasku";
            this.chkLasku.Size = new System.Drawing.Size(95, 17);
            this.chkLasku.TabIndex = 2;
            this.chkLasku.Text = "maksa laskulla";
            this.chkLasku.UseVisualStyleBackColor = true;
            this.chkLasku.CheckedChanged += new System.EventHandler(this.chkLasku_CheckedChanged);
            // 
            // btnVaraaM
            // 
            this.btnVaraaM.Location = new System.Drawing.Point(12, 301);
            this.btnVaraaM.Name = "btnVaraaM";
            this.btnVaraaM.Size = new System.Drawing.Size(91, 34);
            this.btnVaraaM.TabIndex = 3;
            this.btnVaraaM.Text = "Varaa valittu mökki";
            this.btnVaraaM.UseVisualStyleBackColor = true;
            this.btnVaraaM.Click += new System.EventHandler(this.btnVaraaM_Click);
            // 
            // btnAsiakkaisiin
            // 
            this.btnAsiakkaisiin.Location = new System.Drawing.Point(138, 301);
            this.btnAsiakkaisiin.Name = "btnAsiakkaisiin";
            this.btnAsiakkaisiin.Size = new System.Drawing.Size(91, 34);
            this.btnAsiakkaisiin.TabIndex = 4;
            this.btnAsiakkaisiin.Text = "Tarkasta asiakkaita";
            this.btnAsiakkaisiin.UseVisualStyleBackColor = true;
            this.btnAsiakkaisiin.Click += new System.EventHandler(this.btnAsiakkaisiin_Click);
            // 
            // frmMokkivalinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 482);
            this.Controls.Add(this.btnAsiakkaisiin);
            this.Controls.Add(this.btnVaraaM);
            this.Controls.Add(this.chkLasku);
            this.Controls.Add(this.chkPaikanP);
            this.Controls.Add(this.dgwMokkivalinta);
            this.Name = "frmMokkivalinta";
            this.Text = "Mokkivalinta";
            this.Load += new System.EventHandler(this.frmMokkivalinta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMokkivalinta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMokkivalinta;
        private System.Windows.Forms.CheckBox chkPaikanP;
        private System.Windows.Forms.CheckBox chkLasku;
        private System.Windows.Forms.Button btnVaraaM;
        private System.Windows.Forms.Button btnAsiakkaisiin;
    }
}