using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class OgretmenEkleSil : Form
    {
        public bool hataVar { get; private set; }
        public List<int> subeler { get; set; }
        public List<int> diller { get; set; }
        public string bosGunlerVeSaatler { get; private set; }
        public int simdikiGun;
        public string komut { get; private set; }

        public OgretmenEkleSil()
        {
            InitializeComponent();
            subeler = new List<int>();
            diller = new List<int>();
            simdikiGun = 0;
            buttonOgretmenEkle.Enabled = false;
            bosGunlerVeSaatler = "";
            labelDurumBilgisi.Text = "";
            buttonBosSaatEkle.Text = "Pazartesi günü için\nboş saatleri seç";
        }
        private void hataGoster(string hataMesaji)
        {
            HataMenusu hata = new HataMenusu();
            Size hataPenceresi = hata.Size;
            Size mesajBoyutu = hata.labelMesaj.Size;
            hata.StartPosition = FormStartPosition.CenterScreen;
            hata.labelMesaj.Text = hataMesaji;
            hata.ShowDialog();
        }

        public void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (textAd.TextLength == 0)
            {
                hataGoster("Öğretmen adı boş bırakılamaz");
                //simdikiGun = 0;
                //bosGunlerVeSaatler = "";
                return;
            }
            else if (textAd.TextLength > 64)
            {
                hataGoster("Öğr. adı en fazla 64 karakter olabilir");
                //simdikiGun = 0;
                //bosGunlerVeSaatler = "";
                return;
            }
            else if (textCepTelefonu.TextLength == 0 || textEvTelefonu.TextLength == 0)
            {
                hataGoster("Telefon bilgileri boş bırakılamaz");
                //simdikiGun = 0;
                //bosGunlerVeSaatler = "";
                return;
            }
            else if(textCepTelefonu.TextLength > 12 || textEvTelefonu.TextLength > 12)
            {
                hataGoster("Telefonlar maksimum 12 karakter olabilir");
                //simdikiGun = 0;
                //bosGunlerVeSaatler = "";
                return;
            }
            else if(dataGridViewDiller.SelectedRows.Count == 0)
            {
                hataGoster("Herhangi bir dil seçmediniz");
                return;
            }
            else if(dataGridViewSubeler.SelectedRows.Count == 0)
            {
                hataGoster("Herhangi bir şube seçmediniz");
                return;
            }
            hataVar = false;
            //INSERT INTO table_name (column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            Console.WriteLine(dateTimePickerIseBasla.Value.Date);
            komut = $"INSERT INTO Öğretmen (ad, evTelefonu, cepTelefonu, boşGünveSaatler, başlangıçTarihi) VALUES ('{textAd.Text}', '{textEvTelefonu.Text}', '{textCepTelefonu.Text}','{bosGunlerVeSaatler}',convert(datetime,'{dateTimePickerIseBasla.Value.Date}',104))";
            Console.WriteLine(komut);
            for (int i = 0; i < dataGridViewDiller.Rows.Count; i++)
            {
                if (dataGridViewDiller.Rows[i].Selected == true)
                    diller.Add(Int32.Parse(dataGridViewDiller.Rows[i].Cells[0].Value.ToString()));
            }
            for (int i = 0; i < dataGridViewSubeler.Rows.Count; i++)
            {
                if (dataGridViewSubeler.Rows[i].Selected == true)
                    subeler.Add(Int32.Parse(dataGridViewSubeler.Rows[i].Cells[0].Value.ToString()));
            }

            textAd.Text = "";
            textCepTelefonu.Text = "";
            textEvTelefonu.Text = "";
            bosGunlerVeSaatler = "";
            buttonBosSaatEkle.Enabled = true;
            buttonBosSaatEkle.Text = "Pazartesi günü için\nboş saatleri seç";
            bosGunlerVeSaatler = "";
            buttonOgretmenEkle.Enabled = false;
        }

        private void buttonOgretmenSil_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (textBoxSilID.TextLength == 0)
            {
                hataGoster("Silinecek ID kısmı boş bırakılamaz!");
                return;
            }
            int silinecekID;
            try
            {
                silinecekID = Int32.Parse(textBoxSilID.Text);
            }
            catch (System.FormatException)
            {
                hataGoster("Tamsayı değer giriniz.");
                return;
            }
            hataVar = false;
            komut = $"DELETE FROM öğretmen WHERE öğretmenID = {silinecekID};";
            textBoxSilID.Text = "";
        }

        public void buttonBosSaatEkle_Click(object sender, EventArgs e)
        {
            string[] Gunler = { "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar", "Pazartesi" };
            buttonBosSaatEkle.Text = $"{Gunler[simdikiGun]} günü için\nboş saatleri seç";
            List<int> saatler = new List<int>();

            foreach (int item in listBoxBosSaatler.SelectedIndices)
            {
                saatler.Add(item + 8);
            }
            bosGunlerVeSaatler += simdikiGun + "(";
            for (int i = 0; i < saatler.Count - 1; i++)
            {
                bosGunlerVeSaatler += saatler[i] + ",";
            }
            if (saatler.Count > 0)
                bosGunlerVeSaatler += saatler[saatler.Count - 1].ToString();
            bosGunlerVeSaatler += ")";
            listBoxBosSaatler.ClearSelected();
            Console.WriteLine(bosGunlerVeSaatler);
            simdikiGun++;
            if (simdikiGun == 7)
            {
                buttonBosSaatEkle.Text = "Tüm günleri doldurdunuz";
                buttonBosSaatEkle.Enabled = false;
                buttonOgretmenEkle.Enabled = true;
            }

        }
    }
}
