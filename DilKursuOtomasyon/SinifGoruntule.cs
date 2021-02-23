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
    public partial class SinifGoruntule : Form
    {
        public string komut { get; set; }
        public bool hataVar { get; set; }
        public SinifGoruntule()
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

        private void SinifGoruntule_Load(object sender, EventArgs e)
        {

        }

        private void button_SinifSil_Click(object sender, EventArgs e)
        {
            hataVar = true;
            komut = $"DELETE FROM Derslik WHERE derslikID = {textBox_SinifID.Text}";
        }

        private void button_Duzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
