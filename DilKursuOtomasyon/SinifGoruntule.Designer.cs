namespace DilKursuOtomasyon
{
    partial class SinifGoruntule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelSinifID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Duzenle = new System.Windows.Forms.Button();
            this.button_GeriDon = new System.Windows.Forms.Button();
            this.textBox_SinifID = new System.Windows.Forms.TextBox();
            this.textBox_SinifAdi = new System.Windows.Forms.TextBox();
            this.button_SinifSil = new System.Windows.Forms.Button();
            this.dataGridView_Dersler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dersler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Adı:";
            // 
            // LabelSinifID
            // 
            this.LabelSinifID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSinifID.AutoSize = true;
            this.LabelSinifID.ForeColor = System.Drawing.Color.Gold;
            this.LabelSinifID.Location = new System.Drawing.Point(12, 9);
            this.LabelSinifID.Name = "LabelSinifID";
            this.LabelSinifID.Size = new System.Drawing.Size(56, 17);
            this.LabelSinifID.TabIndex = 1;
            this.LabelSinifID.Text = "Sınıf ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Haftalık Ders Listesi:";
            // 
            // button_Duzenle
            // 
            this.button_Duzenle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Duzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.button_Duzenle.FlatAppearance.BorderSize = 0;
            this.button_Duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Duzenle.ForeColor = System.Drawing.Color.Gold;
            this.button_Duzenle.Location = new System.Drawing.Point(224, 9);
            this.button_Duzenle.Name = "button_Duzenle";
            this.button_Duzenle.Size = new System.Drawing.Size(150, 80);
            this.button_Duzenle.TabIndex = 3;
            this.button_Duzenle.Text = "Düzenle";
            this.button_Duzenle.UseVisualStyleBackColor = false;
            this.button_Duzenle.Click += new System.EventHandler(this.button_Duzenle_Click);
            // 
            // button_GeriDon
            // 
            this.button_GeriDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_GeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.button_GeriDon.FlatAppearance.BorderSize = 0;
            this.button_GeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GeriDon.ForeColor = System.Drawing.Color.Gold;
            this.button_GeriDon.Location = new System.Drawing.Point(536, 9);
            this.button_GeriDon.Name = "button_GeriDon";
            this.button_GeriDon.Size = new System.Drawing.Size(150, 80);
            this.button_GeriDon.TabIndex = 4;
            this.button_GeriDon.Text = "Geri Dön";
            this.button_GeriDon.UseVisualStyleBackColor = false;
            // 
            // textBox_SinifID
            // 
            this.textBox_SinifID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SinifID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.textBox_SinifID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SinifID.ForeColor = System.Drawing.Color.Gold;
            this.textBox_SinifID.Location = new System.Drawing.Point(15, 29);
            this.textBox_SinifID.Name = "textBox_SinifID";
            this.textBox_SinifID.ReadOnly = true;
            this.textBox_SinifID.Size = new System.Drawing.Size(203, 15);
            this.textBox_SinifID.TabIndex = 5;
            // 
            // textBox_SinifAdi
            // 
            this.textBox_SinifAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SinifAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.textBox_SinifAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_SinifAdi.ForeColor = System.Drawing.Color.Gold;
            this.textBox_SinifAdi.Location = new System.Drawing.Point(15, 74);
            this.textBox_SinifAdi.Name = "textBox_SinifAdi";
            this.textBox_SinifAdi.ReadOnly = true;
            this.textBox_SinifAdi.Size = new System.Drawing.Size(203, 15);
            this.textBox_SinifAdi.TabIndex = 6;
            // 
            // button_SinifSil
            // 
            this.button_SinifSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_SinifSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.button_SinifSil.FlatAppearance.BorderSize = 0;
            this.button_SinifSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SinifSil.ForeColor = System.Drawing.Color.Gold;
            this.button_SinifSil.Location = new System.Drawing.Point(380, 9);
            this.button_SinifSil.Name = "button_SinifSil";
            this.button_SinifSil.Size = new System.Drawing.Size(150, 80);
            this.button_SinifSil.TabIndex = 8;
            this.button_SinifSil.Text = "Sınıf Sil";
            this.button_SinifSil.UseVisualStyleBackColor = false;
            this.button_SinifSil.Click += new System.EventHandler(this.button_SinifSil_Click);
            // 
            // dataGridView_Dersler
            // 
            this.dataGridView_Dersler.AllowUserToAddRows = false;
            this.dataGridView_Dersler.AllowUserToDeleteRows = false;
            this.dataGridView_Dersler.AllowUserToOrderColumns = true;
            this.dataGridView_Dersler.AllowUserToResizeColumns = false;
            this.dataGridView_Dersler.AllowUserToResizeRows = false;
            this.dataGridView_Dersler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Dersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Dersler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.dataGridView_Dersler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Dersler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Dersler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Dersler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Dersler.ColumnHeadersHeight = 30;
            this.dataGridView_Dersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Dersler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Dersler.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView_Dersler.Location = new System.Drawing.Point(15, 118);
            this.dataGridView_Dersler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Dersler.MultiSelect = false;
            this.dataGridView_Dersler.Name = "dataGridView_Dersler";
            this.dataGridView_Dersler.ReadOnly = true;
            this.dataGridView_Dersler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Dersler.RowHeadersVisible = false;
            this.dataGridView_Dersler.RowHeadersWidth = 51;
            this.dataGridView_Dersler.RowTemplate.Height = 30;
            this.dataGridView_Dersler.RowTemplate.ReadOnly = true;
            this.dataGridView_Dersler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Dersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Dersler.Size = new System.Drawing.Size(671, 477);
            this.dataGridView_Dersler.TabIndex = 25;
            // 
            // SinifGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(701, 606);
            this.Controls.Add(this.dataGridView_Dersler);
            this.Controls.Add(this.button_SinifSil);
            this.Controls.Add(this.textBox_SinifAdi);
            this.Controls.Add(this.textBox_SinifID);
            this.Controls.Add(this.button_GeriDon);
            this.Controls.Add(this.button_Duzenle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelSinifID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinifGoruntule";
            this.Text = "SinifGoruntule";
            this.Load += new System.EventHandler(this.SinifGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelSinifID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_SinifID;
        public System.Windows.Forms.TextBox textBox_SinifAdi;
        public System.Windows.Forms.Button button_Duzenle;
        public System.Windows.Forms.Button button_GeriDon;
        public System.Windows.Forms.Button button_SinifSil;
        public System.Windows.Forms.DataGridView dataGridView_Dersler;
    }
}