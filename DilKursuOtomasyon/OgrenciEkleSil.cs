using System;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class OgrenciEkleSil : Form
    {

        public string komut { get; set; }
        public bool hataVarMı { get; set; }

        public OgrenciEkleSil()
        {
            InitializeComponent();
            labelDurumBilgisi.Text = "";
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

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            komut = $"INSERT INTO Öğrenci (isim, evTelefonu, cepTelefonu, ödemeBilgileri) " +
                $"VALUES ('{textAd.Text}','{textEvTelefonu.Text}','{textCepTelefonu.Text}','{richTextBoxOdemeBilgileri.Text}');";
            textAd.Text = "";
            textEvTelefonu.Text = "";
            textCepTelefonu.Text = "";
            richTextBoxOdemeBilgileri.Text = "";
        }
        public void buttonOgrenciSil_Click_1(object sender, EventArgs e)
        {
            hataVarMı = true;
            if (textBoxSilID.TextLength == 0)
            {
                hataGoster("Silinecek öğrencinin ID'si boş bırakılamaz!");
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
            hataVarMı = false;
            //DELETE FROM table_name WHERE condition;
            komut = $"DELETE FROM Öğrenci WHERE öğrenciID = {silinecekID};";
            textBoxSilID.Text = "";
        }
    }
}
