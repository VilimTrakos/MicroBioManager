namespace MicroBioManager
{
    partial class FrmDodajNalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifraPacijenta = new System.Windows.Forms.TextBox();
            this.cboUzorak = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddRezultate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrikazRezultata = new System.Windows.Forms.DataGridView();
            this.txtIdRezultata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajNalog = new System.Windows.Forms.Button();
            this.txtSifraNalog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboUzorakNalog = new System.Windows.Forms.ComboBox();
            this.btnPocetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRezultata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sifra pacijenta:";
            // 
            // txtSifraPacijenta
            // 
            this.txtSifraPacijenta.Location = new System.Drawing.Point(158, 35);
            this.txtSifraPacijenta.Name = "txtSifraPacijenta";
            this.txtSifraPacijenta.Size = new System.Drawing.Size(121, 22);
            this.txtSifraPacijenta.TabIndex = 1;
            // 
            // cboUzorak
            // 
            this.cboUzorak.Items.AddRange(new object[] {
            "Krv",
            "Urin"});
            this.cboUzorak.Location = new System.Drawing.Point(373, 35);
            this.cboUzorak.Name = "cboUzorak";
            this.cboUzorak.Size = new System.Drawing.Size(121, 24);
            this.cboUzorak.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Uzorak:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(522, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddRezultate
            // 
            this.btnAddRezultate.Location = new System.Drawing.Point(620, 21);
            this.btnAddRezultate.Name = "btnAddRezultate";
            this.btnAddRezultate.Size = new System.Drawing.Size(131, 51);
            this.btnAddRezultate.TabIndex = 5;
            this.btnAddRezultate.Text = "Dodaj rezultate";
            this.btnAddRezultate.UseVisualStyleBackColor = true;
            this.btnAddRezultate.Click += new System.EventHandler(this.btnAddRezultate_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dodaj novi popis rezultata:";
            // 
            // dgvPrikazRezultata
            // 
            this.dgvPrikazRezultata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazRezultata.Location = new System.Drawing.Point(24, 87);
            this.dgvPrikazRezultata.Name = "dgvPrikazRezultata";
            this.dgvPrikazRezultata.RowHeadersWidth = 51;
            this.dgvPrikazRezultata.RowTemplate.Height = 24;
            this.dgvPrikazRezultata.Size = new System.Drawing.Size(737, 150);
            this.dgvPrikazRezultata.TabIndex = 7;
            // 
            // txtIdRezultata
            // 
            this.txtIdRezultata.Location = new System.Drawing.Point(40, 273);
            this.txtIdRezultata.Name = "txtIdRezultata";
            this.txtIdRezultata.Size = new System.Drawing.Size(174, 22);
            this.txtIdRezultata.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unesite id kreiranih rezultata:";
            // 
            // btnDodajNalog
            // 
            this.btnDodajNalog.Location = new System.Drawing.Point(311, 304);
            this.btnDodajNalog.Name = "btnDodajNalog";
            this.btnDodajNalog.Size = new System.Drawing.Size(151, 63);
            this.btnDodajNalog.TabIndex = 10;
            this.btnDodajNalog.Text = "Dodaj nalog";
            this.btnDodajNalog.UseVisualStyleBackColor = true;
            this.btnDodajNalog.Click += new System.EventHandler(this.btnDodajNalog_Click);
            // 
            // txtSifraNalog
            // 
            this.txtSifraNalog.Location = new System.Drawing.Point(40, 323);
            this.txtSifraNalog.Name = "txtSifraNalog";
            this.txtSifraNalog.Size = new System.Drawing.Size(174, 22);
            this.txtSifraNalog.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sifra pacijenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Uzorak:";
            // 
            // cboUzorakNalog
            // 
            this.cboUzorakNalog.Items.AddRange(new object[] {
            "Krv",
            "Urin"});
            this.cboUzorakNalog.Location = new System.Drawing.Point(40, 373);
            this.cboUzorakNalog.Name = "cboUzorakNalog";
            this.cboUzorakNalog.Size = new System.Drawing.Size(174, 24);
            this.cboUzorakNalog.TabIndex = 13;
            // 
            // btnPocetak
            // 
            this.btnPocetak.Location = new System.Drawing.Point(522, 304);
            this.btnPocetak.Name = "btnPocetak";
            this.btnPocetak.Size = new System.Drawing.Size(143, 63);
            this.btnPocetak.TabIndex = 15;
            this.btnPocetak.Text = "Povratak na pocetak";
            this.btnPocetak.UseVisualStyleBackColor = true;
            this.btnPocetak.Click += new System.EventHandler(this.btnPocetak_Click);
            // 
            // FrmDodajNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 438);
            this.Controls.Add(this.btnPocetak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboUzorakNalog);
            this.Controls.Add(this.txtSifraNalog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajNalog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdRezultata);
            this.Controls.Add(this.dgvPrikazRezultata);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddRezultate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboUzorak);
            this.Controls.Add(this.txtSifraPacijenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajNalog";
            this.Text = "FrmDodajNalog";
            this.Load += new System.EventHandler(this.FrmDodajNalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazRezultata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifraPacijenta;
        private System.Windows.Forms.ComboBox cboUzorak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddRezultate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrikazRezultata;
        private System.Windows.Forms.TextBox txtIdRezultata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajNalog;
        private System.Windows.Forms.TextBox txtSifraNalog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboUzorakNalog;
        private System.Windows.Forms.Button btnPocetak;
    }
}