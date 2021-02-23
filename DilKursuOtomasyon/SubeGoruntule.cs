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
    public partial class SubeGoruntule : Form
    {
        public bool hataVarMı { get; set; }
        public bool hataVar { get; set; }
        public string komut { get; set; }
        public int secilenSubeIndis { get; set; }
        public string secilenSubeAd { get; set; }
        public SubeGoruntule()
        {
            InitializeComponent();
            hataVar = false;

            komut = $"SELECT şubeID, ad FROM Şube";
        }
        ~SubeGoruntule()
        {
            Console.WriteLine("Şube görüntüleme için yok edici çağrıldı");
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
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



        private void dataGridView_Subeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSecileniGoruntule_Click_1(object sender, EventArgs e)
        {
            secilenSubeIndis = Int32.Parse(dataGridView_Subeler.CurrentRow.Cells[0].Value.ToString());
            komut = $"select * from Şube where şubeID = {secilenSubeIndis};";
            Console.WriteLine(komut);
            return;
        }

        private void buttonArama_Click_1(object sender, EventArgs e)
        {
            if (textAraAd.Text.Length == 0)
            {
                hataGoster("Aranacak şube adı boş bırakılamaz!");
                hataVar = true;
                return;
            }
            secilenSubeAd = textAraAd.Text;
            hataVar = false;
            komut = $"SELECT * FROM Şube WHERE ad = '{secilenSubeAd}';";
            Console.WriteLine(komut);

        }
    }
}
