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
    public partial class DersKaydi : Form
    {
        public int ogrenciID { get; set; }
        public string komut { get; set; }
        public string dilID { get; set; }
        public string secilenGun { get; set; }
        public int taksitSayisi { get; set; }

        public DersKaydi()
        {
            InitializeComponent();
            buttonDersEkle.Enabled = false;
            buttonGunSec.Enabled = false;
            buttonSaatSec.Enabled = false;
            buttonSubeSec.Enabled = false;
            
        }

        public void buttonDilSec_Click(object sender, EventArgs e)
        {
            dilID = dataGridViewDiller.CurrentRow.Cells[0].Value.ToString();
            buttonGunSec.Enabled = true;
            buttonSaatSec.Enabled = false;
            buttonSubeSec.Enabled = false;
            buttonDersEkle.Enabled = false;
        }

        public void buttonGunSec_Click(object sender, EventArgs e)
        {
            secilenGun = listBoxGunler.SelectedIndex.ToString();
            komut = $"SELECT de.günlerSaatler FROM Ders de WHERE de.dilID = {dilID} AND de.günlerSaatler LIKE'{secilenGun}(%';";
     
            buttonSaatSec.Enabled = true;
            buttonDersEkle.Enabled = false;
            buttonSubeSec.Enabled = false;
        }

        public void buttonSaatSec_Click(object sender, EventArgs e)
        {
            komut = $"SELECT distinct sb.şubeID, sb.ad FROM ders dr, derslik dl, Şube sb WHERE dr.günlerSaatler = '{secilenGun}({listBoxSaatler.SelectedItem.ToString()})' AND dr.derslikID = dl.derslikID AND dl.şubeID = sb.şubeID;";

            buttonDersEkle.Enabled = false;
            buttonSubeSec.Enabled = true;
        }
        public void buttonSubeSec_Click(object sender, EventArgs e)
        {
            komut = $"SELECT dr.dersID, dr.kur, dl.derslikID FROM Derslik dl, Ders dr, Şube sb WHERE sb.şubeID = dl.şubeID AND {dataGridViewSubeler.CurrentRow.Cells[0].Value.ToString()} = sb.şubeID AND dl.derslikID = dr.derslikID AND dr.günlerSaatler = '{secilenGun}({listBoxSaatler.SelectedItem.ToString()})';";
            buttonDersEkle.Enabled = true;
        }

        private void dataGridViewKurSec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            komut = $"SELECT dersÜcreti FROM ders WHERE dersID = {dataGridViewKurSec.CurrentRow.Cells[0].Value.ToString()};";
        }
        public int taksitHesapla()
        {
            int secilenTaksit = 0;
            foreach (var item in groupBoxTaksitler.Controls)
            {
                if (item.ToString().Contains("Checked: True"))
                {
                    return 12 - secilenTaksit * 3;
                }
                secilenTaksit++;
            }
            return 0;
        }
        public void buttonDersEkle_Click(object sender, EventArgs e)
        {
            taksitSayisi = taksitHesapla();
            if(taksitSayisi == 0)
            {
                taksitSayisi = 1;
            }
            komut = $"INSERT INTO DersKaydı (dersID, öğrenciID, borç, taksitSayısı)" +
                $" VALUES ({dataGridViewKurSec.CurrentRow.Cells[0].Value.ToString()},{ogrenciID},{textDersUcreti.Text},{taksitSayisi});";
            Console.WriteLine(komut);
        }

        private void textDersUcreti_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
