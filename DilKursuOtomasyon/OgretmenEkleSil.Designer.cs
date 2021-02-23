namespace DilKursuOtomasyon
{
    partial class OgretmenEkleSil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBosSaatEkle = new System.Windows.Forms.Button();
            this.listBoxBosSaatler = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerIseBasla = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewDiller = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSubeler = new System.Windows.Forms.DataGridView();
            this.textEvTelefonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCepTelefonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOgretmenEkle = new System.Windows.Forms.Button();
            this.textAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSilID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonOgretmenSil = new System.Windows.Forms.Button();
            this.labelDurumBilgisi = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubeler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Ekle/Sil";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.buttonBosSaatEkle);
            this.panel1.Controls.Add(this.listBoxBosSaatler);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePickerIseBasla);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dataGridViewDiller);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dataGridViewSubeler);
            this.panel1.Controls.Add(this.textEvTelefonu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textCepTelefonu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonOgretmenEkle);
            this.panel1.Controls.Add(this.textAd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 451);
            this.panel1.TabIndex = 2;
            // 
            // buttonBosSaatEkle
            // 
            this.buttonBosSaatEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBosSaatEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.buttonBosSaatEkle.FlatAppearance.BorderSize = 0;
            this.buttonBosSaatEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBosSaatEkle.ForeColor = System.Drawing.Color.Gold;
            this.buttonBosSaatEkle.Location = new System.Drawing.Point(21, 387);
            this.buttonBosSaatEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBosSaatEkle.Name = "buttonBosSaatEkle";
            this.buttonBosSaatEkle.Size = new System.Drawing.Size(214, 46);
            this.buttonBosSaatEkle.TabIndex = 11;
            this.buttonBosSaatEkle.Text = "Pazartesi Günü İçin\r\nBoş Saatleri Seç\r\n";
            this.buttonBosSaatEkle.UseVisualStyleBackColor = false;
            this.buttonBosSaatEkle.Click += new System.EventHandler(this.buttonBosSaatEkle_Click);
            // 
            // listBoxBosSaatler
            // 
            this.listBoxBosSaatler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxBosSaatler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.listBoxBosSaatler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxBosSaatler.ForeColor = System.Drawing.Color.Gold;
            this.listBoxBosSaatler.FormattingEnabled = true;
            this.listBoxBosSaatler.ItemHeight = 16;
            this.listBoxBosSaatler.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00"});
            this.listBoxBosSaatler.Location = new System.Drawing.Point(21, 152);
            this.listBoxBosSaatler.Name = "listBoxBosSaatler";
            this.listBoxBosSaatler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxBosSaatler.Size = new System.Drawing.Size(214, 224);
            this.listBoxBosSaatler.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(17, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Boş Saatler:";
            // 
            // dateTimePickerIseBasla
            // 
            this.dateTimePickerIseBasla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerIseBasla.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dateTimePickerIseBasla.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.dateTimePickerIseBasla.Location = new System.Drawing.Point(385, 82);
            this.dateTimePickerIseBasla.Name = "dateTimePickerIseBasla";
            this.dateTimePickerIseBasla.Size = new System.Drawing.Size(304, 22);
            this.dateTimePickerIseBasla.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gold;
            this.label8.Location = new System.Drawing.Point(381, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "İşe Başladığı Tarih:";
            // 
            // dataGridViewDiller
            // 
            this.dataGridViewDiller.AllowUserToAddRows = false;
            this.dataGridViewDiller.AllowUserToDeleteRows = false;
            this.dataGridViewDiller.AllowUserToOrderColumns = true;
            this.dataGridViewDiller.AllowUserToResizeColumns = false;
            this.dataGridViewDiller.AllowUserToResizeRows = false;
            this.dataGridViewDiller.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewDiller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiller.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.dataGridViewDiller.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDiller.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDiller.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDiller.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDiller.ColumnHeadersHeight = 30;
            this.dataGridViewDiller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiller.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDiller.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewDiller.Location = new System.Drawing.Point(515, 152);
            this.dataGridViewDiller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDiller.Name = "dataGridViewDiller";
            this.dataGridViewDiller.ReadOnly = true;
            this.dataGridViewDiller.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewDiller.RowHeadersVisible = false;
            this.dataGridViewDiller.RowHeadersWidth = 51;
            this.dataGridViewDiller.RowTemplate.Height = 30;
            this.dataGridViewDiller.RowTemplate.ReadOnly = true;
            this.dataGridViewDiller.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiller.Size = new System.Drawing.Size(174, 228);
            this.dataGridViewDiller.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(237, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 43);
            this.label6.TabIndex = 27;
            this.label6.Text = "Öğretmenin Ders\r\nVerebileceği Şubeler:";
            // 
            // dataGridViewSubeler
            // 
            this.dataGridViewSubeler.AllowUserToAddRows = false;
            this.dataGridViewSubeler.AllowUserToDeleteRows = false;
            this.dataGridViewSubeler.AllowUserToOrderColumns = true;
            this.dataGridViewSubeler.AllowUserToResizeColumns = false;
            this.dataGridViewSubeler.AllowUserToResizeRows = false;
            this.dataGridViewSubeler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSubeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubeler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.dataGridViewSubeler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSubeler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewSubeler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubeler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSubeler.ColumnHeadersHeight = 30;
            this.dataGridViewSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubeler.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSubeler.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridViewSubeler.Location = new System.Drawing.Point(241, 152);
            this.dataGridViewSubeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSubeler.Name = "dataGridViewSubeler";
            this.dataGridViewSubeler.ReadOnly = true;
            this.dataGridViewSubeler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSubeler.RowHeadersVisible = false;
            this.dataGridViewSubeler.RowHeadersWidth = 51;
            this.dataGridViewSubeler.RowTemplate.Height = 30;
            this.dataGridViewSubeler.RowTemplate.ReadOnly = true;
            this.dataGridViewSubeler.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubeler.Size = new System.Drawing.Size(268, 281);
            this.dataGridViewSubeler.TabIndex = 12;
            // 
            // textEvTelefonu
            // 
            this.textEvTelefonu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textEvTelefonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textEvTelefonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEvTelefonu.ForeColor = System.Drawing.SystemColors.Info;
            this.textEvTelefonu.Location = new System.Drawing.Point(21, 81);
            this.textEvTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEvTelefonu.Name = "textEvTelefonu";
            this.textEvTelefonu.Size = new System.Drawing.Size(318, 15);
            this.textEvTelefonu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(17, 57);
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
            this.textCepTelefonu.Location = new System.Drawing.Point(385, 30);
            this.textCepTelefonu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCepTelefonu.Name = "textCepTelefonu";
            this.textCepTelefonu.Size = new System.Drawing.Size(304, 15);
            this.textCepTelefonu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(381, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cep Telefonu:";
            // 
            // buttonOgretmenEkle
            // 
            this.buttonOgretmenEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOgretmenEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.buttonOgretmenEkle.FlatAppearance.BorderSize = 0;
            this.buttonOgretmenEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOgretmenEkle.ForeColor = System.Drawing.Color.Gold;
            this.buttonOgretmenEkle.Location = new System.Drawing.Point(515, 387);
            this.buttonOgretmenEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOgretmenEkle.Name = "buttonOgretmenEkle";
            this.buttonOgretmenEkle.Size = new System.Drawing.Size(174, 46);
            this.buttonOgretmenEkle.TabIndex = 14;
            this.buttonOgretmenEkle.Text = "Öğretmen Ekle";
            this.buttonOgretmenEkle.UseVisualStyleBackColor = false;
            this.buttonOgretmenEkle.Click += new System.EventHandler(this.buttonOgretmenEkle_Click);
            // 
            // textAd
            // 
            this.textAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.textAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAd.ForeColor = System.Drawing.SystemColors.Info;
            this.textAd.Location = new System.Drawing.Point(21, 30);
            this.textAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(318, 15);
            this.textAd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(515, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Öğretmenin \r\nVerebileceği Diller:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmen Adı:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.panel2.Controls.Add(this.textBoxSilID);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.buttonOgretmenSil);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 100);
            this.panel2.TabIndex = 3;
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
            this.textBoxSilID.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(17, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Öğretmen ID\'si:";
            // 
            // buttonOgretmenSil
            // 
            this.buttonOgretmenSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOgretmenSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(23)))));
            this.buttonOgretmenSil.FlatAppearance.BorderSize = 0;
            this.buttonOgretmenSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOgretmenSil.ForeColor = System.Drawing.Color.Gold;
            this.buttonOgretmenSil.Location = new System.Drawing.Point(485, 32);
            this.buttonOgretmenSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOgretmenSil.Name = "buttonOgretmenSil";
            this.buttonOgretmenSil.Size = new System.Drawing.Size(204, 46);
            this.buttonOgretmenSil.TabIndex = 32;
            this.buttonOgretmenSil.Text = "Öğretmen Sil";
            this.buttonOgretmenSil.UseVisualStyleBackColor = false;
            this.buttonOgretmenSil.Click += new System.EventHandler(this.buttonOgretmenSil_Click);
            // 
            // labelDurumBilgisi
            // 
            this.labelDurumBilgisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDurumBilgisi.AutoSize = true;
            this.labelDurumBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurumBilgisi.ForeColor = System.Drawing.Color.Gold;
            this.labelDurumBilgisi.Location = new System.Drawing.Point(16, 478);
            this.labelDurumBilgisi.Name = "labelDurumBilgisi";
            this.labelDurumBilgisi.Size = new System.Drawing.Size(155, 25);
            this.labelDurumBilgisi.TabIndex = 4;
            this.labelDurumBilgisi.Text = "Durum Bilgisi Gir";
            // 
            // OgretmenEkleSil
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
            this.Name = "OgretmenEkleSil";
            this.Text = "OgretmenEkleSil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubeler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonOgretmenEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridViewSubeler;
        public System.Windows.Forms.DataGridView dataGridViewDiller;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSilID;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button buttonOgretmenSil;
        public System.Windows.Forms.Label labelDurumBilgisi;
        private System.Windows.Forms.DateTimePicker dateTimePickerIseBasla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button buttonBosSaatEkle;
        public System.Windows.Forms.TextBox textEvTelefonu;
        public System.Windows.Forms.TextBox textAd;
        public System.Windows.Forms.TextBox textCepTelefonu;
        public System.Windows.Forms.ListBox listBoxBosSaatler;
    }
}