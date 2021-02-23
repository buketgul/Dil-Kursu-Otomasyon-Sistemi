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
    public partial class HataMenusu : Form
    {
        public HataMenusu()
        {
            InitializeComponent();
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
