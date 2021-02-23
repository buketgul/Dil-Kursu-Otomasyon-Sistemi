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
    public partial class DersEkleSil : Form
    {
        
        public int ogretmenIndis { get; internal set; }
        public int dilIndis { get; internal set; }
        public int subeIndis { get; internal set; }

        public int secilenGun { get; private set; }
        public int derslik { get; private set; }
        public bool hataVar { get; private set; }
        public List<int> saatler { get; private set; }
        public string ogrBosGunSaat { get; set; }
        public int ucret { get; set; }

        public DersEkleSil()
        {
            InitializeComponent();
            buttonDersiEkle.Enabled = false;
            buttonOgretmenSec.Enabled = false;
            buttonGün.Enabled = false;
            buttonSaat.Enabled = false;
            buttonDerslikSec.Enabled = false;
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


        private void buttonSubeSec_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (dataGridViewSubeler.SelectedRows.Count == 0)
            {
                hataGoster("Herhangi bir seçim yapmadınız");
                return;
            }
            hataVar = false;
            buttonOgretmenSec.Enabled = true;
            buttonGün.Enabled = false;
            buttonSaat.Enabled = false;
            buttonDerslikSec.Enabled = false;
            buttonDersiEkle.Enabled = false;
            subeIndis = Int32.Parse(dataGridViewSubeler.CurrentRow.Cells[0].Value.ToString());
        }

        private void buttonOgretmenSec_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (dataGridViewDiller.SelectedRows.Count == 0)
            {
                hataGoster("Herhangi bir seçim yapmadınız");
                return;
            }
            hataVar = false;
            buttonGün.Enabled = true;
            buttonSaat.Enabled = false;
            buttonDerslikSec.Enabled = false;
            buttonDersiEkle.Enabled = false;
            dilIndis = Int32.Parse(dataGridViewDiller.CurrentRow.Cells[0].Value.ToString());
            ogretmenIndis = Int32.Parse(dataGridViewDiller.CurrentRow.Cells[2].Value.ToString());
        }

        private void buttonGün_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (listBoxGunler.SelectedItems.Count != 1)
            {
                hataGoster("Bir adet seçim yapmalısınız");
                return;
            }
            listBoxBosSaatler.Items.Clear();
            buttonSaat.Enabled = true;
            buttonDerslikSec.Enabled = false;
            buttonDersiEkle.Enabled = false;
            secilenGun = listBoxGunler.SelectedIndex;
            hataVar = false;
        }

        private void buttonSaat_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if(listBoxBosSaatler.SelectedItems.Count ==0)
            {
                hataGoster("Hiçbir seçim yapmadınız!");
                return;
            }
            if (listBoxBosSaatler.SelectedItems.Count > 3)
            {
                hataGoster("Ders saati üçten fazla olamaz!");
                return;
            }
            buttonDerslikSec.Enabled = true;
            buttonDersiEkle.Enabled = false;
            hataVar = false;
            saatler = new List<int>();
            foreach (int item in listBoxBosSaatler.SelectedIndices)
            {
                saatler.Add(Int32.Parse(listBoxBosSaatler.Items[item].ToString()));
            }
            foreach (var item in saatler)
            {
                Console.WriteLine(item);
            }
        }

        private void buttonDerslikSec_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (dataGridViewDerslikler.SelectedRows.Count == 0)
            {
                hataGoster("Herhangi bir seçim yapmadınız");
                return;
            }
            buttonDersiEkle.Enabled = true;
            derslik = Int32.Parse(dataGridViewDerslikler.CurrentRow.Cells[0].Value.ToString());
            hataVar = false;
        }

        private void buttonDersiEkle_Click(object sender, EventArgs e)
        {
            hataVar = true;
            if (textBoxDersUcreti.TextLength == 0 || textKurAdi.TextLength == 0)
            {
                hataGoster("Boş alan bırakmayınız");
                return;
            }
            int ucret2;
            if(!Int32.TryParse(textBoxDersUcreti.Text,out ucret2))
            {
                hataGoster("Ücret kısmına tamsayı değerler giriniz");
                return;
            }
            this.ucret = ucret2;
            hataVar = false;
            buttonDersiEkle.Enabled = false;
            buttonOgretmenSec.Enabled = false;
            buttonGün.Enabled = false;
            buttonSaat.Enabled = false;
            buttonDerslikSec.Enabled = false;
        }
    }
}
