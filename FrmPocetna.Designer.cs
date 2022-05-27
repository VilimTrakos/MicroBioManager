namespace MicroBioManager
{
    partial class FrmPocetna
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
            this.dgvPopisNaloga = new System.Windows.Forms.DataGridView();
            this.OtvoriNalog = new System.Windows.Forms.Button();
            this.DodajKrvna = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.DodajUrin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisNaloga)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisNaloga
            // 
            this.dgvPopisNaloga.AllowUserToDeleteRows = false;
            this.dgvPopisNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisNaloga.Location = new System.Drawing.Point(34, 28);
            this.dgvPopisNaloga.Name = "dgvPopisNaloga";
            this.dgvPopisNaloga.RowHeadersWidth = 51;
            this.dgvPopisNaloga.RowTemplate.Height = 24;
            this.dgvPopisNaloga.Size = new System.Drawing.Size(480, 370);
            this.dgvPopisNaloga.TabIndex = 0;
            // 
            // OtvoriNalog
            // 
            this.OtvoriNalog.Location = new System.Drawing.Point(545, 98);
            this.OtvoriNalog.Name = "OtvoriNalog";
            this.OtvoriNalog.Size = new System.Drawing.Size(196, 32);
            this.OtvoriNalog.TabIndex = 1;
            this.OtvoriNalog.Text = "Otvori nalog";
            this.OtvoriNalog.UseVisualStyleBackColor = true;
            this.OtvoriNalog.Click += new System.EventHandler(this.OtvoriNalog_Click);
            // 
            // DodajKrvna
            // 
            this.DodajKrvna.Location = new System.Drawing.Point(545, 207);
            this.DodajKrvna.Name = "DodajKrvna";
            this.DodajKrvna.Size = new System.Drawing.Size(196, 34);
            this.DodajKrvna.TabIndex = 2;
            this.DodajKrvna.Text = "Dodaj krvnu analizu";
            this.DodajKrvna.UseVisualStyleBackColor = true;
            this.DodajKrvna.Click += new System.EventHandler(this.DodajKrvna_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(545, 376);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(202, 22);
            this.search.TabIndex = 3;
            // 
            // DodajUrin
            // 
            this.DodajUrin.Location = new System.Drawing.Point(545, 247);
            this.DodajUrin.Name = "DodajUrin";
            this.DodajUrin.Size = new System.Drawing.Size(196, 32);
            this.DodajUrin.TabIndex = 4;
            this.DodajUrin.Text = "Dodaj analizu urina";
            this.DodajUrin.UseVisualStyleBackColor = true;
            this.DodajUrin.Click += new System.EventHandler(this.DodajUrin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uneiste pojam za pretragu:";
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DodajUrin);
            this.Controls.Add(this.search);
            this.Controls.Add(this.DodajKrvna);
            this.Controls.Add(this.OtvoriNalog);
            this.Controls.Add(this.dgvPopisNaloga);
            this.Name = "FrmPocetna";
            this.Text = "MicroBioManager ";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisNaloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisNaloga;
        private System.Windows.Forms.Button OtvoriNalog;
        private System.Windows.Forms.Button DodajKrvna;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button DodajUrin;
        private System.Windows.Forms.Label label1;
    }
}

