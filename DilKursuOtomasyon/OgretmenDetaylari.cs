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
    public partial class OgretmenDetaylari : Form
    {

        public int ogrID { get; set; }
        public string komutSil { get; private set; }

        public OgretmenDetaylari()
        {
            InitializeComponent();
        }

        private void buttonOgretmenSil_Click(object sender, EventArgs e)
        {
            komutSil = $"DELETE FROM Öğretmen WHERE öğretmenID = {ogrID}";
        }
    }
}
