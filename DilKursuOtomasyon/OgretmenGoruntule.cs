using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class OgretmenGoruntule : Form
    {
        public int secilenOgrID { get; private set; }
        public bool hataVar { get; set; }
        public string komut { get; private set; }
        public string komutDil { get; private set; }
        public string komutSube { get; private set; }
        public string komutProgram { get; private set; }

        public OgretmenGoruntule()
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
        private void buttonArama_Click(object sender, EventArgs e)
        {
            if (textAraID.Text.Length == 0)
            {
                hataGoster("Aranacak şube adı boş bırakılamaz!");
                hataVar = true;
                return;
            }
            secilenOgrID = Int32.Parse(textAraID.Text);
            hataVar = false;
            komut = $"SELECT öğretmenID, ad, evTelefonu, cepTelefonu, boşGünveSaatler, başlangıçTarihi FROM Öğretmen WHERE öğretmenID = {secilenOgrID};";
            komutDil = $"SELECT di.dilID, di.dilAdı FROM Öğretmen ö, DilÖğretir d, Dil di WHERE ö.öğretmenID = {secilenOgrID} AND ö.öğretmenID = d.öğretmenID AND d.dilID = di.dilID;";
            komutSube = $"SELECT şu.şubeID, şu.ad FROM Öğretmen ö, Şube şu, ŞubedeÇalışır ş WHERE ö.öğretmenID = {secilenOgrID} AND ö.öğretmenID = ş.öğretmenID AND ş.şubeID = şu.şubeID;";
            komutProgram = $"select d.dersID, dil.dilAdı, d.günlerSaatler from ders d, dil dil where d.öğretmenID = {secilenOgrID} AND dil.dilID = d.dilID";
        }

        private void buttonSecileniGoruntule_Click(object sender, EventArgs e)
        {
            secilenOgrID = Int32.Parse(dataGridViewOgretmenler.CurrentRow.Cells[0].Value.ToString());
            komut = $"SELECT öğretmenID, ad, evTelefonu, cepTelefonu, boşGünveSaatler, başlangıçTarihi FROM Öğretmen WHERE öğretmenID = {secilenOgrID};";
            komutDil = $"SELECT di.dilID, di.dilAdı FROM Öğretmen ö, DilÖğretir d, Dil di WHERE ö.öğretmenID = {secilenOgrID} AND ö.öğretmenID = d.öğretmenID AND d.dilID = di.dilID;";
            komutSube = $"SELECT şu.şubeID, şu.ad FROM Öğretmen ö, Şube şu, ŞubedeÇalışır ş WHERE ö.öğretmenID = {secilenOgrID} AND ö.öğretmenID = ş.öğretmenID AND ş.şubeID = şu.şubeID;";
            komutProgram = $"select d.dersID, dil.dilAdı, d.günlerSaatler from ders d, dil dil where d.öğretmenID = {secilenOgrID} AND dil.dilID = d.dilID";
        }
    }
}
