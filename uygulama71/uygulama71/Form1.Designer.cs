namespace uygulama71
{
    partial class Form1
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
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblDersSaati = new System.Windows.Forms.Label();
            this.lblNot1 = new System.Windows.Forms.Label();
            this.lblNot2 = new System.Windows.Forms.Label();
            this.lblHesapla = new System.Windows.Forms.Button();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtDersSaati = new System.Windows.Forms.TextBox();
            this.txtNot1 = new System.Windows.Forms.TextBox();
            this.txtNot2 = new System.Windows.Forms.TextBox();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListe
            // 
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(333, 75);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.Size = new System.Drawing.Size(545, 234);
            this.dgvListe.TabIndex = 0;
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdi.Location = new System.Drawing.Point(59, 104);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(65, 16);
            this.lblDersAdi.TabIndex = 1;
            this.lblDersAdi.Text = "Ders Adı :";
            // 
            // lblDersSaati
            // 
            this.lblDersSaati.AutoSize = true;
            this.lblDersSaati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersSaati.Location = new System.Drawing.Point(60, 132);
            this.lblDersSaati.Name = "lblDersSaati";
            this.lblDersSaati.Size = new System.Drawing.Size(76, 16);
            this.lblDersSaati.TabIndex = 2;
            this.lblDersSaati.Text = "Ders Saati :";
            // 
            // lblNot1
            // 
            this.lblNot1.AutoSize = true;
            this.lblNot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot1.Location = new System.Drawing.Point(59, 159);
            this.lblNot1.Name = "lblNot1";
            this.lblNot1.Size = new System.Drawing.Size(44, 16);
            this.lblNot1.TabIndex = 3;
            this.lblNot1.Text = "Not 1 :";
            // 
            // lblNot2
            // 
            this.lblNot2.AutoSize = true;
            this.lblNot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot2.Location = new System.Drawing.Point(60, 189);
            this.lblNot2.Name = "lblNot2";
            this.lblNot2.Size = new System.Drawing.Size(44, 16);
            this.lblNot2.TabIndex = 4;
            this.lblNot2.Text = "Not 2 :";
            // 
            // lblHesapla
            // 
            this.lblHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHesapla.Location = new System.Drawing.Point(109, 236);
            this.lblHesapla.Name = "lblHesapla";
            this.lblHesapla.Size = new System.Drawing.Size(157, 31);
            this.lblHesapla.TabIndex = 5;
            this.lblHesapla.Text = "Hesapla";
            this.lblHesapla.UseVisualStyleBackColor = true;
            this.lblHesapla.Click += new System.EventHandler(this.lblHesapla_Click);
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(141, 103);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(147, 20);
            this.txtDersAdi.TabIndex = 6;
            // 
            // txtDersSaati
            // 
            this.txtDersSaati.Location = new System.Drawing.Point(141, 128);
            this.txtDersSaati.Name = "txtDersSaati";
            this.txtDersSaati.Size = new System.Drawing.Size(147, 20);
            this.txtDersSaati.TabIndex = 7;
            // 
            // txtNot1
            // 
            this.txtNot1.Location = new System.Drawing.Point(141, 155);
            this.txtNot1.Name = "txtNot1";
            this.txtNot1.Size = new System.Drawing.Size(147, 20);
            this.txtNot1.TabIndex = 8;
            // 
            // txtNot2
            // 
            this.txtNot2.Location = new System.Drawing.Point(141, 185);
            this.txtNot2.Name = "txtNot2";
            this.txtNot2.Size = new System.Drawing.Size(147, 20);
            this.txtNot2.TabIndex = 9;
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.Location = new System.Drawing.Point(59, 312);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(68, 16);
            this.lblOrtalama.TabIndex = 10;
            this.lblOrtalama.Text = "Ortalama :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(59, 344);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 16);
            this.lblDurum.TabIndex = 11;
            this.lblDurum.Text = "Durum :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 413);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.txtNot2);
            this.Controls.Add(this.txtNot1);
            this.Controls.Add(this.txtDersSaati);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.lblHesapla);
            this.Controls.Add(this.lblNot2);
            this.Controls.Add(this.lblNot1);
            this.Controls.Add(this.lblDersSaati);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.dgvListe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblDersSaati;
        private System.Windows.Forms.Label lblNot1;
        private System.Windows.Forms.Label lblNot2;
        private System.Windows.Forms.Button lblHesapla;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtDersSaati;
        private System.Windows.Forms.TextBox txtNot1;
        private System.Windows.Forms.TextBox txtNot2;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblDurum;
    }
}

