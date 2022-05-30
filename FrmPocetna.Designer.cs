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
            this.btnPretraga = new System.Windows.Forms.Button();
            this.btnNoviPacijent = new System.Windows.Forms.Button();
            this.btnNalog = new System.Windows.Forms.Button();
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
            this.OtvoriNalog.Location = new System.Drawing.Point(545, 43);
            this.OtvoriNalog.Name = "OtvoriNalog";
            this.OtvoriNalog.Size = new System.Drawing.Size(196, 32);
            this.OtvoriNalog.TabIndex = 1;
            this.OtvoriNalog.Text = "Otvori nalog";
            this.OtvoriNalog.UseVisualStyleBackColor = true;
            this.OtvoriNalog.Click += new System.EventHandler(this.OtvoriNalog_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(545, 362);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(196, 36);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.Location = new System.Drawing.Point(545, 171);
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(196, 30);
            this.btnNoviPacijent.TabIndex = 6;
            this.btnNoviPacijent.Text = "Dodaj pacijenta";
            this.btnNoviPacijent.UseVisualStyleBackColor = true;
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // btnNalog
            // 
            this.btnNalog.Location = new System.Drawing.Point(545, 218);
            this.btnNalog.Name = "btnNalog";
            this.btnNalog.Size = new System.Drawing.Size(196, 36);
            this.btnNalog.TabIndex = 7;
            this.btnNalog.Text = "Dodaj nalog";
            this.btnNalog.UseVisualStyleBackColor = true;
            this.btnNalog.Click += new System.EventHandler(this.btnNalog_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNalog);
            this.Controls.Add(this.btnNoviPacijent);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.OtvoriNalog);
            this.Controls.Add(this.dgvPopisNaloga);
            this.Name = "FrmPocetna";
            this.Text = "MicroBioManager ";
            this.Load += new System.EventHandler(this.FrmPocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisNaloga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisNaloga;
        private System.Windows.Forms.Button OtvoriNalog;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Button btnNoviPacijent;
        private System.Windows.Forms.Button btnNalog;
    }
}

