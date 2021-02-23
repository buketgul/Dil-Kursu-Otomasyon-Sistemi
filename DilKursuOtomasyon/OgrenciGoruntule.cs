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
    public partial class OgrenciGoruntule : Form
    {

        public string komut { get; private set; }
        public int secilenOgrenciIndis { get; private set; }

        public OgrenciGoruntule()
        {
            InitializeComponent();
        }

        private void buttonSecileniGoruntule_Click(object sender, EventArgs e)
        {
            
            secilenOgrenciIndis = Int32.Parse(dataGridViewOgrenciler.CurrentRow.Cells[0].Value.ToString());
            komut = $"SELECT isim, evTelefonu, cepTelefonu, ödemeBilgileri FROM Öğrenci where öğrenciID = {secilenOgrenciIndis};";
            return;
        }

        public void buttonArama_Click(object sender, EventArgs e)
        {
            secilenOgrenciIndis = Int32.Parse(textAraID.Text);
            komut = $"SELECT isim, evTelefonu, cepTelefonu, ödemeBilgileri FROM Öğrenci where öğrenciID = {secilenOgrenciIndis};";
            return;
        }
    }

}
