namespace DilKursuOtomasyon
{
    partial class OgretmenGoruntule
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
            this.dataGridViewOgretmenler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSecileniGoruntule = new System.Windows.Forms.Button();
            this.buttonArama = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textAraID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOgretmenler
            // 
            this.dataGridViewOgretmenler.AllowUserToAddRows = false;
            this.dataGridViewOgretmenler.AllowUserToDeleteRows = false;
            this.dataGridViewOgretmenler.AllowUserToOrderColumns = true;
            this.dataGridViewOgretmenler.AllowUserToResizeColumns = false;
            this.dataGridViewOgretmenler.AllowUserToResizeRows = false;
            this.dataGridViewOgretmenler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewOgretmenler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgretmenler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.dataGridViewOgretmenler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOgretmenler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOgretmenler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOgretmenler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOgretmenler.ColumnHeadersHeight = 30;
            this.dataGridViewOgretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOgretmenler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOgretmenler.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewOgretmenler.Location = new System.Drawing.Point(12, 27);
            this.dataGridViewOgretmenler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOgretmenler.Name = "dataGridViewOgretmenler";
            this.dataGridViewOgretmenler.ReadOnly = true;
            this.dataGridViewOgretmenler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewOgretmenler.RowHeadersVisible = false;
            this.dataGridViewOgretmenler.RowHeadersWidth = 51;
            this.dataGridViewOgretmenler.RowTemplate.Height = 30;
            this.dataGridViewOgretmenler.RowTemplate.ReadOnly = true;
            this.dataGridViewOgretmenler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOgretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgretmenler.Size = new System.Drawing.Size(677, 494);
            this.dataGridViewOgretmenler.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Öğretmenler:";
            // 
            // buttonSecileniGoruntule
            // 
            this.buttonSecileniGoruntule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSecileniGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.buttonSecileniGoruntule.FlatAppearance.BorderSize = 0;
            this.buttonSecileniGoruntule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSecileniGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSecileniGoruntule.ForeColor = System.Drawing.Color.Gold;
            this.buttonSecileniGoruntule.Location = new System.Drawing.Point(572, 533);
            this.buttonSecileniGoruntule.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSecileniGoruntule.Name = "buttonSecileniGoruntule";
            this.buttonSecileniGoruntule.Size = new System.Drawing.Size(117, 62);
            this.buttonSecileniGoruntule.TabIndex = 32;
            this.buttonSecileniGoruntule.Text = "Seçileni Görüntüle";
            this.buttonSecileniGoruntule.UseVisualStyleBackColor = false;
            this.buttonSecileniGoruntule.Click += new System.EventHandler(this.buttonSecileniGoruntule_Click);
            // 
            // buttonArama
            // 
            this.buttonArama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonArama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.buttonArama.FlatAppearance.BorderSize = 0;
            this.buttonArama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonArama.ForeColor = System.Drawing.Color.Gold;
            this.buttonArama.Location = new System.Drawing.Point(436, 533);
            this.buttonArama.Margin = new System.Windows.Forms.Padding(0);
            this.buttonArama.Name = "buttonArama";
            this.buttonArama.Size = new System.Drawing.Size(123, 62);
            this.buttonArama.TabIndex = 31;
            this.buttonArama.Text = "Ara";
            this.buttonArama.UseVisualStyleBackColor = false;
            this.buttonArama.Click += new System.EventHandler(this.buttonArama_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(13, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Öğretmen ID\'si";
            // 
            // textAraID
            // 
            this.textAraID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAraID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.textAraID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAraID.ForeColor = System.Drawing.SystemColors.Info;
            this.textAraID.Location = new System.Drawing.Point(12, 557);
            this.textAraID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAraID.Name = "textAraID";
            this.textAraID.Size = new System.Drawing.Size(421, 15);
            this.textAraID.TabIndex = 29;
            // 
            // OgretmenGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(701, 606);
            this.Controls.Add(this.buttonSecileniGoruntule);
            this.Controls.Add(this.buttonArama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAraID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewOgretmenler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenGoruntule";
            this.Text = "OgretmenGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgretmenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewOgretmenler;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonSecileniGoruntule;
        public System.Windows.Forms.Button buttonArama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAraID;
    }
}