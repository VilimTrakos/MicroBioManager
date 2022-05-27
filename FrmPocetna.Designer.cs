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
            this.PopisNaloga = new System.Windows.Forms.DataGridView();
            this.Otvori = new System.Windows.Forms.Button();
            this.DodajKrvna = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.DodajUrin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopisNaloga)).BeginInit();
            this.SuspendLayout();
            // 
            // PopisNaloga
            // 
            this.PopisNaloga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopisNaloga.Location = new System.Drawing.Point(34, 28);
            this.PopisNaloga.Name = "PopisNaloga";
            this.PopisNaloga.RowHeadersWidth = 51;
            this.PopisNaloga.RowTemplate.Height = 24;
            this.PopisNaloga.Size = new System.Drawing.Size(418, 370);
            this.PopisNaloga.TabIndex = 0;
            // 
            // Otvori
            // 
            this.Otvori.Location = new System.Drawing.Point(540, 104);
            this.Otvori.Name = "Otvori";
            this.Otvori.Size = new System.Drawing.Size(196, 32);
            this.Otvori.TabIndex = 1;
            this.Otvori.Text = "Otvori nalog";
            this.Otvori.UseVisualStyleBackColor = true;
            // 
            // DodajKrvna
            // 
            this.DodajKrvna.Location = new System.Drawing.Point(540, 167);
            this.DodajKrvna.Name = "DodajKrvna";
            this.DodajKrvna.Size = new System.Drawing.Size(196, 34);
            this.DodajKrvna.TabIndex = 2;
            this.DodajKrvna.Text = "Dodaj krvnu analizu";
            this.DodajKrvna.UseVisualStyleBackColor = true;
            this.DodajKrvna.Click += new System.EventHandler(this.DodajKrvna_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(540, 337);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(202, 22);
            this.search.TabIndex = 3;
            // 
            // DodajUrin
            // 
            this.DodajUrin.Location = new System.Drawing.Point(540, 207);
            this.DodajUrin.Name = "DodajUrin";
            this.DodajUrin.Size = new System.Drawing.Size(196, 32);
            this.DodajUrin.TabIndex = 4;
            this.DodajUrin.Text = "Dodaj analizu urina";
            this.DodajUrin.UseVisualStyleBackColor = true;
            this.DodajUrin.Click += new System.EventHandler(this.DodajUrin_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajUrin);
            this.Controls.Add(this.search);
            this.Controls.Add(this.DodajKrvna);
            this.Controls.Add(this.Otvori);
            this.Controls.Add(this.PopisNaloga);
            this.Name = "FrmPocetna";
            this.Text = "Form1";

            ((System.ComponentModel.ISupportInitialize)(this.PopisNaloga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopisNaloga;
        private System.Windows.Forms.Button Otvori;
        private System.Windows.Forms.Button DodajKrvna;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button DodajUrin;
    }
}

