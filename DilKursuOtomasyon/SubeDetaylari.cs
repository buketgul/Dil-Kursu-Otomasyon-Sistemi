using System;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class SubeDetaylari : Form
    {
        public int secilenSinifIndis { get; internal set; }
        public int subeInd { get; set; }
        public int secilenDersIndis { get; private set; }
        public bool hataVar { get; private set; }

        public SubeDetaylari()
        {
            InitializeComponent();
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

        private void buttonSinifGoruntule_Click(object sender, EventArgs e)
        {
            if (buttonSinifGoruntule.Text == "Seçilen Sınıfı Görüntüle") 
            {
                if (this.dataGridView_Sınıf.SelectedRows.Count == 0)
                {
                    hataGoster("Herhangi bir sınıf seçmediniz!");
                    hataVar = true;
                    return;
                }
                hataVar = false;
                secilenSinifIndis = Int32.Parse(dataGridView_Sınıf.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void buttonDersiGoruntule_Click(object sender, EventArgs e)
        {
            if(buttonDersiGoruntule.Text == "Seçilen Dersi Görüntüle")
            {
                if (this.dataGridView_Ders.SelectedRows.Count == 0)
                {
                    hataGoster("Herhangi bir ders seçmediniz!");
                    hataVar = true;
                    return;
                }
            secilenDersIndis = Int32.Parse(dataGridView_Ders.CurrentRow.Cells[0].Value.ToString());
            }
            hataVar = false;
        }
    }
}
