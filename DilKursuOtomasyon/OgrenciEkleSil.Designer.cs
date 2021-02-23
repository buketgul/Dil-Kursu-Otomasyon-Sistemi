namespace DilKursuOtomasyon
{
    partial class OgrenciEkleSil
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
            this.labelDurumBilgisi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSilID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOgrenciSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBoxOdemeBilgileri = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEvTelefonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCepTelefonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOgrenciEkle = new System.Windows.Forms.Button();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDurumBilgisi
            // 
            this.labelDurumBilgisi.AutoSize = true;
            this.labelDurumBilgisi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelDurumBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurumBilgisi.ForeColor = System.Drawing.Color.Gold;
            this.labelDurumBilgisi.Location = new System.Drawing.Point(0, 481);
            this.labelDurumBilgisi.Name = "labelDurumBilgisi";
            this.labelDurumBilgisi.Size = new System.Drawing.Size(155, 25);
            this.labelDurumBilgisi.TabIndex = 8;
            this.labelDurumBilgisi.Text = "Durum Bilgisi Gir";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.textBoxSilID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonOgrenciSil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 100);
            this.panel2.TabIndex = 7;
            // 
            // textBoxSilID
            // 
            this.textBoxSilID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSilID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textBoxSilID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSilID.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxSilID.Location = new System.Drawing.Point(21, 58);
            this.textBoxSilID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSilID.Name = "textBoxSilID";
            this.textBoxSilID.Size = new System.Drawing.Size(458, 15);
            this.textBoxSilID.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(17, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Öğrenci ID\'si:";
            // 
            // buttonOgrenciSil
            // 
            this.buttonOgrenciSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOgrenciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.buttonOgrenciSil.FlatAppearance.BorderSize = 0;
            this.buttonOgrenciSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOgrenciSil.ForeColor = System.Drawing.Color.Gold;
            this.buttonOgrenciSil.Location = new System.Drawing.Point(485, 32);
            this.buttonOgrenciSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOgrenciSil.Name = "buttonOgrenciSil";
            this.buttonOgrenciSil.Size = new System.Drawing.Size(204, 46);
            this.buttonOgrenciSil.TabIndex = 43;
            this.buttonOgrenciSil.Text = "Öğrenci Sil";
            this.buttonOgrenciSil.UseVisualStyleBackColor = false;
            this.buttonOgrenciSil.Click += new System.EventHandler(this.buttonOgrenciSil_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.richTextBoxOdemeBilgileri);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textEvTelefonu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textCepTelefonu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonOgrenciEkle);
            this.panel1.Controls.Add(this.textAd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 451);
            this.panel1.TabIndex = 6;
            // 
            // richTextBoxOdemeBilgileri
            // 
            this.richTextBoxOdemeBilgileri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxOdemeBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.richTextBoxOdemeBilgileri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxOdemeBilgileri.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxOdemeBilgileri.Location = new System.Drawing.Point(21, 102);
            this.richTextBoxOdemeBilgileri.Name = "richTextBoxOdemeBilgileri";
            this.richTextBoxOdemeBilgileri.Size = new System.Drawing.Size(304, 331);
            this.richTextBoxOdemeBilgileri.TabIndex = 40;
            this.richTextBoxOdemeBilgileri.Text = "";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(17, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Ödeme Bilgileri:";
            // 
            // textEvTelefonu
            // 
            this.textEvTelefonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEvTelefonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textEvTelefonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEvTelefonu.ForeColor = System.Drawing.SystemColors.Info;
            this.textEvTelefonu.Location = new System.Drawing.Point(385, 102);
            this.textEvTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEvTelefonu.Name = "textEvTelefonu";
            this.textEvTelefonu.Size = new System.Drawing.Size(304, 15);
            this.textEvTelefonu.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(381, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ev Telefonu:";
            // 
            // textCepTelefonu
            // 
            this.textCepTelefonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textCepTelefonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textCepTelefonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCepTelefonu.ForeColor = System.Drawing.SystemColors.Info;
            this.textCepTelefonu.Location = new System.Drawing.Point(385, 49);
            this.textCepTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCepTelefonu.Name = "textCepTelefonu";
            this.textCepTelefonu.Size = new System.Drawing.Size(304, 15);
            this.textCepTelefonu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(381, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cep Telefonu:";
            // 
            // buttonOgrenciEkle
            // 
            this.buttonOgrenciEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.buttonOgrenciEkle.FlatAppearance.BorderSize = 0;
            this.buttonOgrenciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOgrenciEkle.ForeColor = System.Drawing.Color.Gold;
            this.buttonOgrenciEkle.Location = new System.Drawing.Point(385, 374);
            this.buttonOgrenciEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            this.buttonOgrenciEkle.Size = new System.Drawing.Size(304, 59);
            this.buttonOgrenciEkle.TabIndex = 41;
            this.buttonOgrenciEkle.Text = "Öğrenci Ekle";
            this.buttonOgrenciEkle.UseVisualStyleBackColor = false;
            this.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEkle_Click);
            // 
            // textAd
            // 
            this.textAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAd.ForeColor = System.Drawing.SystemColors.Info;
            this.textAd.Location = new System.Drawing.Point(21, 49);
            this.textAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(304, 15);
            this.textAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(17, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Ekle/Sil";
            // 
            // OgrenciEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(701, 606);
            this.Controls.Add(this.labelDurumBilgisi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrenciEkleSil";
            this.Text = "OgrenciEkleSil";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelDurumBilgisi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button buttonOgrenciSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEvTelefonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCepTelefonu;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonOgrenciEkle;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxOdemeBilgileri;
        public System.Windows.Forms.TextBox textBoxSilID;
    }
}