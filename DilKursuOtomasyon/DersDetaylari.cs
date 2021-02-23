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
    public partial class DersDetaylari : Form
    {
        public string gelinenSayfa { get; set; }
        public string dersProgram { get; set; }
        public int ogrID { get; set; }
        public int derslikID { get; set; }

        public DersDetaylari()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



    }
}
