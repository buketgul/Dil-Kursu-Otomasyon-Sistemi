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
    public partial class SubeEkleSil : Form
    {
        public bool hataVarMı { get; set; }
        public string komut { get; set; }
        public string subeAdi { get; set; }
        public SubeEkleSil()
        {
            hataVarMı = false;
            InitializeComponent();
        }
        ~SubeEkleSil()
        {
            Console.WriteLine("Sube Ekle/Sil için yok edici çağrıldı");
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
        private void buttonSubeEkle_Click(object sender, EventArgs e)
        {
            if (textAd.TextLength == 0)
            {
                hataGoster("Şube adı alanı boş bırakılamaz.");
                hataVarMı = true;
                return;
            }
            else if(textAd.TextLength > 20)
            {
                hataGoster("Şube adı en fazla 20 karakter olabilir.");
                hataVarMı = true;
                return;
            }
            else if(textAdres.TextLength == 0)
            {
                hataGoster("Şube adresi boş bırakılamaz.");
                hataVarMı = true;
                return;
            }
            else if (textBoxSifre.TextLength == 0)
            {
                hataGoster("Şube şifresi boş bırakılamaz.");
                hataVarMı = true;
                return;
            }
            //INSERT INTO table_name (column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            hataVarMı = false;
            komut = $"INSERT INTO Şube (ad, adres, ulaşım, sosyalOlanaklar, password) VALUES ( '{textAd.Text}', '{textAdres.Text}', '{textUlasim.Text}', '{textSosyalOlanak.Text}', '{textBoxSifre.Text}');";
            textAdres.Text = "";
            textSosyalOlanak.Text = "";
            textUlasim.Text = "";
            textAd.Text = "";
            textBoxSifre.Text = "";
        }

        private void buttonSubeSil_Click(object sender, EventArgs e)
        {
            hataVarMı = true;
            if (textSilAd.TextLength==0)
            {
                hataGoster("Silinecek şubenin adı boş bırakılamaz!");
                return;
            }
            int silinecekID;
            try
            {

            silinecekID = Int32.Parse(textSilAd.Text);
            }
            catch (System.InvalidOperationException)
            {
                hataGoster("Lütfen geçerli bir tamsayı değeri giriniz.");
                return;
            }
            hataVarMı = false;
            //DELETE FROM table_name WHERE condition;
            komut = $"DELETE FROM Şube WHERE ŞubeID = '{silinecekID}';";
            textSilAd.Text = "";
        }

    }
}
