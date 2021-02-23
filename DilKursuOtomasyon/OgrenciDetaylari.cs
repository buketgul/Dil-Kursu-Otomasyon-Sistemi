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
    public partial class OgrenciDetaylari : Form
    {
    public int ogrID { get; set; }
        public string komut { get; set; }
        public OgrenciDetaylari(int ogrID)
        {
            InitializeComponent();
            this.ogrID = ogrID;
        }

        private void buttonOdemeYap_Click(object sender, EventArgs e)
        {
            int taksit = Int32.Parse(dataGridViewTaksitler.CurrentRow.Cells[1].Value.ToString());
            int borç = Int32.Parse(dataGridViewTaksitler.CurrentRow.Cells[2].Value.ToString());
            komut = $"UPDATE dersKaydı SET borç = {borç-borç/taksit}, taksitSayısı = {--taksit} WHERE dersID = {dataGridViewTaksitler.CurrentRow.Cells[0].Value.ToString()} AND öğrenciID = {ogrID};";
        }
    }
}
