using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class SinifEkle : Form
    {
        
        private int subeInd;
        public string komut { get; set; }

        public bool hataVar { get; set; }

        public SinifEkle(int subeIndis)
        {
            InitializeComponent();
            this.subeInd = subeIndis;
            hataVar = false;
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
        // sınıf silinecek.
        private void buttonSinifSil_Click(object sender, EventArgs e)
        {
            if(textSilID.TextLength == 0)
            {
                hataVar = true;
                hataGoster("Silinecek sınıf adını boş bırakmayınız.");
                return;
            }
            hataVar = false;
            komut = $"DELETE FROM Derslik WHERE ad = '{textSilID.Text}' AND şubeID = {subeInd};";
            this.labelDurumBilgisi.Text = $"{subeInd} ID'li şubeden {textSilID.Text} adlı sınıf silindi.";
        }
        private void buttonSinifEkle_Click(object sender, EventArgs e)
        {
            if (textBoxSinifKodu.TextLength == 0)
            {
                hataGoster("Sınıf adı boş bırakılamaz");
                hataVar = true;
                return;
            }
            komut = $"INSERT INTO Derslik (şubeID, ad) VALUES ({subeInd}, '{textBoxSinifKodu.Text}');";
            this.labelDurumBilgisi.Text = $"{subeInd} ID'li şubeye {textBoxSinifKodu.Text} adlı sınıf eklendi.";
            hataVar = false;
        }

        private void labelSinifEkle_Click(object sender, EventArgs e)
        {

        }
    }
}
