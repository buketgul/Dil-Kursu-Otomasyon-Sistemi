using System;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class DersGoruntule : Form
    {
        public string komut { get; set; }
        public int secilenDersIndis { get; private set; }
        public bool hataVar { get; set; }
        public string komutOgrenciler { get; private set; }

        public DersGoruntule()
        {
            InitializeComponent();
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

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonArama_Click(object sender, EventArgs e)
        {
            if (textAraID.TextLength == 0)
            {
                hataGoster("Lütfen boş bırakmayınız");
                hataVar = true;
                return;
            }
            secilenDersIndis = Int32.Parse(textAraID.Text);
            hataVar = false;
            komut = $"SELECT ders.dersID, dil.dilAdı, ders.kur, ders.dersÜcreti, öğr.ad, ders.günlerSaatler, derslik.ad, derslik.derslikID, öğr.öğretmenID " +
                $"FROM Ders ders, Dil dil, Öğretmen öğr, Derslik derslik " +
                $"WHERE ders.dersID = {textAraID.Text} AND dil.dilID = ders.dilID AND öğr.öğretmenID = ders.öğretmenID " +
                $"AND derslik.derslikID = ders.derslikID;";
            komutOgrenciler = $"SELECT öğr.öğrenciID, öğr.isim FROM Ders ders, DersKaydı dk, Öğrenci öğr " +
                $"WHERE ders.dersID = {textAraID.Text} AND ders.dersID = dk.dersID AND dk.öğrenciID = öğr.öğrenciID; ";
        }

        private void buttonSecileniGoruntule_Click(object sender, EventArgs e)
        {
            hataVar = false;
            secilenDersIndis = Int32.Parse(dataGridViewDersler.CurrentRow.Cells[0].Value.ToString());
            komut = $"SELECT ders.dersID, dil.dilAdı, ders.kur, ders.dersÜcreti, öğr.ad, ders.günlerSaatler, derslik.ad, derslik.derslikID, öğr.öğretmenID " +
                $"FROM Ders ders, Dil dil, Öğretmen öğr, Derslik derslik " +
                $"WHERE ders.dersID = {dataGridViewDersler.CurrentRow.Cells[0].Value} AND dil.dilID = ders.dilID AND öğr.öğretmenID = ders.öğretmenID " +
                $"AND derslik.derslikID = ders.derslikID;";
            komutOgrenciler = $"SELECT öğr.öğrenciID, öğr.isim FROM Ders ders, DersKaydı dk, Öğrenci öğr " +
                $"WHERE ders.dersID = {dataGridViewDersler.CurrentRow.Cells[0].Value} AND ders.dersID = dk.dersID AND dk.öğrenciID = öğr.öğrenciID; ";
        }
    }
}
