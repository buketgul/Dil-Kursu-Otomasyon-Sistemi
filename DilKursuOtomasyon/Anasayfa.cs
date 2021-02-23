using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    public partial class Anasayfa : Form
    {
        private bool fareBasili = false;
        private Point sonKonum;
        public Form acikForm = null;
        SubeEkleSil subeEkleSil;
        SubeGoruntule subeGoruntule;
        SubeDetaylari detay;
        SinifEkle sinifEkleSil;
        private SinifGoruntule sinifGoruntule;
        private SqlConnection con;
        private OgrenciDetaylari ogrenciDetay;
        private OgretmenDetaylari ogretmenDetaylari;
        SqlCommand komut;
        SqlDataAdapter da;
        DersEkleSil dersEkle;
        public DersKaydi dersKaydi;
        private DersGoruntule dersGoruntule;
        public OgrenciEkleSil ogrenciEkleSil;
        private OgrenciGoruntule ogrenciGoruntule;
        private OgretmenGoruntule ogretmenGoruntule;
        private OgretmenEkleSil ogretmenEkleSil;
        private DersDetaylari dersDetaylari;
        private string komutDersGor;
        private string[] gunler;

        public string komutOgrenciler { get; private set; }

        public GirisEkrani giris;
        string adminAdı = "admin";
        string adminSifresi = "admin";
        public bool adminMi = false;

        public Anasayfa()
        {
            InitializeComponent();
            Ayarlama();
            gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };
            con = new SqlConnection("Data Source=DESKTOP-E3D3I1G\\MS;Initial Catalog=DilKursuOtomasyonSistemi;Integrated Security=True;MultipleActiveResultSets=True");
            con.Open();
        }
        ~Anasayfa()
        {
            Console.WriteLine("Anasayfa yok edicisi cagrildi");
        }
        private void Ayarlama()
        {

            panelDersIslemleri.Visible = false;
            panelOgrenciIslemleri.Visible = false;
            panelSubeIslemleri.Visible = false;
            panelOgretmen.Visible = false;
            giris = new GirisEkrani();
            giris.buttonGirisYap.Click += new System.EventHandler(this.girisYapma);
            FormAc(giris);
            panelYanMenu.Visible = false;
        }

        public void hataGoster(string hataMesaji)
        {
            HataMenusu hata = new HataMenusu();
            Size hataPenceresi = hata.Size;
            Size mesajBoyutu = hata.labelMesaj.Size;
            hata.StartPosition = FormStartPosition.CenterScreen;
            hata.labelMesaj.Text = hataMesaji;
            hata.ShowDialog();
        }
        //Seçilen panelin, anasayfada gösterilmesini sağlayan fonksiyon
        private void FormAc(Form acilacakForm)
        {
            if (acikForm != null)
            {
                acikForm.Close();
            }
            acikForm = acilacakForm;
            acilacakForm.TopLevel = false;
            acilacakForm.FormBorderStyle = FormBorderStyle.None;
            acilacakForm.Dock = DockStyle.Fill;
            panelMenuSecim.Controls.Add(acilacakForm);
            panelMenuSecim.Tag = acilacakForm;
            acilacakForm.BringToFront();
            acilacakForm.Show();
        }
        private void MenuleriGizle()
        {
            if (panelSubeIslemleri.Visible == true)
                panelSubeIslemleri.Visible = false;
            if (panelOgrenciIslemleri.Visible == true)
                panelOgrenciIslemleri.Visible = false;
            if (panelDersIslemleri.Visible == true)
                panelDersIslemleri.Visible = false;
            if (panelOgretmen.Visible == true)
                panelOgretmen.Visible = false;
        }
        //Menülere açma/kapama özelliğinin eklenmesi
        private void MenuTiklama(Panel AcilacakMenu)
        {
            if (AcilacakMenu.Visible == false)
            {
                MenuleriGizle();
                AcilacakMenu.Visible = true;
            }
            else
                AcilacakMenu.Visible = false;
        }
        //----------------------------------------------------------
        //GRUP 1 BAŞI:
        //Bu grupta menüler için açılır kapanır özellikler atanmıştır.
        private void buttonSubeIslemleri_Click(object sender, EventArgs e)
        {
            MenuTiklama(panelSubeIslemleri);
        }

        private void buttonDersIslemleri_Click(object sender, EventArgs e)
        {
            MenuTiklama(panelDersIslemleri);
        }

        private void buttonOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            MenuTiklama(panelOgrenciIslemleri);
        }
        private void buttonOgretmenIslemleri_Click(object sender, EventArgs e)
        {
            MenuTiklama(panelOgretmen);
        }

        //GRUP 1 SONU
        //-----------------------------------------------------------



        //-----------------------------------------------------------
        //GRUP 2.0 BAŞI:
        //Bu grupta, Şube İşlemleri menüsünün altındaki alt menüler için açılacak
        //Paneller açılmıştır.
        //SubeGoruntule menüsü için buton işlevi tanımı
        //SubeGoruntule menüsü oluşturup ek buton işlevleri atanıyor
        private void buttonSubeGoruntule_Click(object sender, EventArgs e)
        {
            subeGoruntule = new SubeGoruntule();
            da = new SqlDataAdapter(subeGoruntule.komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["ad"].ColumnName = "Şube Adı";
            dt.Columns["şubeID"].ColumnName = "Şube ID";
            if (dt.Rows.Count == 0)
                return;
            subeGoruntule.dataGridView_Subeler.DataSource = dt;
            subeGoruntule.buttonSecileniGoruntule.Click += new System.EventHandler(buttonSecileniGoruntule_Click);
            subeGoruntule.buttonArama.Click += new System.EventHandler(buttonSecileniGoruntule_Click);
            //Seçilen şubeyi görüntüle ve şube ara tuşları alınan ID'ye göre aynı aramayı
            //Yaptığı için ikisine de yukarıdaki fonksiyon direkt atandı
            FormAc(subeGoruntule);
        }

        private void buttonSubeEkleSil_Click(object sender, EventArgs e)
        {
            subeEkleSil = new SubeEkleSil();
            subeEkleSil.buttonSubeEkle.Click += new System.EventHandler(subeEklemeSilme);
            subeEkleSil.buttonSubeSil.Click += new System.EventHandler(subeEklemeSilme);
            FormAc(subeEkleSil);
        }
        //GRUP 2.0 SONU
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        //GRUP 2.1 BAŞI
        //Bu grupta ders işlemleri menüsü altındaki menüler için açılacak
        //Paneller açılmıştır.
        private void buttonDersEkleSil_Click(object sender, EventArgs e)
        {
            dersEkle = new DersEkleSil();
            da = new SqlDataAdapter($"SELECT şubeID, ad FROM Şube", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["şubeID"].ColumnName = "Şube ID";
            dt.Columns["ad"].ColumnName = "Şube Adı";
            dersEkle.dataGridViewSubeler.DataSource = dt;
            dersEkle.buttonSubeSec.Click += new System.EventHandler(this.buttonSubeSec_Click);
            dersEkle.buttonOgretmenSec.Click += new System.EventHandler(this.buttonOgretmenSec_Click);
            dersEkle.buttonGün.Click += new System.EventHandler(this.buttonGün_Click);
            dersEkle.buttonSaat.Click += new System.EventHandler(this.buttonSaat_Click);
            dersEkle.buttonDerslikSec.Click += new System.EventHandler(this.buttonDerslikSec_Click);
            dersEkle.buttonDersiEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
            FormAc(dersEkle);
        }
        private void buttonDersGoruntule_Click(object sender, EventArgs e)
        {
            dersGoruntule = new DersGoruntule();
            dersGoruntule.buttonArama.Click += new System.EventHandler(this.dersArama_Click);
            dersGoruntule.buttonSecileniGoruntule.Click += new System.EventHandler(this.dersArama_Click);
            da = new SqlDataAdapter("SELECT ders.dersID, dil.dilAdı, derslik.şubeID, ders.derslikID FROM Derslik derslik, Ders ders, Dil dil WHERE dil.dilID = ders.dilID AND ders.derslikID = derslik.derslikID;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["şubeID"].ColumnName = "Şube ID";
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["derslikID"].ColumnName = "Derslik ID";
            dt.Columns["dilAdı"].ColumnName = "Dil";
            dersGoruntule.dataGridViewDersler.DataSource = dt;
            FormAc(dersGoruntule);
        }

        private void dersArama_Click(object sender, EventArgs e)
        {
            if (dersGoruntule.hataVar)
            {
                return;
            }
            dersDetaylari = new DersDetaylari();
            dersDetaylari.gelinenSayfa = "Ders";
            dersDetaylari.buttonGeriDon.Click += new System.EventHandler(this.dersDetayGeriDon);
            dersDetaylari.buttonDersSil.Click += new System.EventHandler(this.buttonDersSil_Click);
            komut = new SqlCommand(dersGoruntule.komut, con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dersDetaylari.textBoxDersID.Text = dr.GetInt32(0).ToString();
                dersDetaylari.textBoxDersDili.Text = dr.GetString(1);
                dersDetaylari.textBoxDersKuru.Text = dr.GetString(2);
                dersDetaylari.textBoxDersUcreti.Text = dr.GetInt32(3).ToString();
                dersDetaylari.textBoxOgretmen.Text = dr.GetString(4);
                dersDetaylari.dersProgram = dr.GetString(5);
                string takvim = gunler[Int32.Parse(dersDetaylari.dersProgram[0].ToString())];
                takvim += $"\n{dersDetaylari.dersProgram.Substring(2, dersDetaylari.dersProgram.Length - 3)}";
                dersDetaylari.textBoxDersProgrami.Text = takvim;
                dersDetaylari.textBoxDerslik.Text = dr.GetString(6);
                dersDetaylari.derslikID = dr.GetInt32(7);
                dersDetaylari.ogrID = dr.GetInt32(8);
            }

            da = new SqlDataAdapter(dersGoruntule.komutOgrenciler, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["isim"].ColumnName = "Öğrenci Adı";
            dt.Columns["öğrenciID"].ColumnName = "Öğrenci ID";
            dersDetaylari.dataGridViewOgrenciler.DataSource = dt;
            FormAc(dersDetaylari);
        }

        private void buttonDersSil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand($"DELETE FROM Ders WHERE dersID = {dersDetaylari.textBoxDersID.Text}", con);
            komut.ExecuteNonQuery();

            komut = new SqlCommand($"SELECT boşGunveSaatler FROM derslik WHERE derslikID = {dersDetaylari.derslikID}", con);
            SqlDataReader dr = komut.ExecuteReader();
            string bosSaatler = "";
            while (dr.Read())
            {
                bosSaatler = dr.GetString(0);
            }
            int baslangic = bosSaatler.IndexOf(dersDetaylari.dersProgram[0].ToString() + '(') + 2;
            int bitis = bosSaatler.IndexOf(")", baslangic);
            string yeniDerslikBosSaatler = bosSaatler.Substring(0, bitis) + ',' + dersDetaylari.dersProgram.Substring(2, dersDetaylari.dersProgram.Length - 3) + bosSaatler.Substring(bitis);
            komut = new SqlCommand($"UPDATE derslik SET boşGunveSaatler = '{yeniDerslikBosSaatler}' WHERE derslikID = {dersDetaylari.derslikID}", con);
            komut.ExecuteNonQuery();

            komut = new SqlCommand($"SELECT boşGünveSaatler FROM Öğretmen WHERE öğretmenID = {dersDetaylari.ogrID}", con);
            SqlDataReader dr2 = komut.ExecuteReader();
            string bosSaatlerOgr = "";
            int ogrID = dersDetaylari.ogrID;
            while (dr2.Read())
            {
                bosSaatlerOgr = dr2.GetString(0);
            }
            int baslangic2 = bosSaatlerOgr.IndexOf(dersDetaylari.dersProgram[0].ToString() + '(') + 2;
            int bitis2 = bosSaatlerOgr.IndexOf(")", baslangic2);
            string ogretmenBosSaatler = bosSaatlerOgr.Substring(0, bitis2) + ',' + dersDetaylari.dersProgram.Substring(2, dersDetaylari.dersProgram.Length - 3) + bosSaatlerOgr.Substring(bitis2);
            komut = new SqlCommand($"UPDATE öğretmen SET boşGünveSaatler = '{ogretmenBosSaatler}' WHERE öğretmenID = {dersDetaylari.ogrID}", con);
            komut.ExecuteNonQuery();
            // ALP BURAYA BAK

        }


        //GRUP 2.1 SONU
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        //GRUP 2.2 BAŞI
        //Bu grupta öğrenci işlemleri menüsü altındaki menüler için açılacak
        //Paneller açılmıştır.
        private void buttonOgrenciGoruntule_Click(object sender, EventArgs e)
        {
            ogrenciGoruntule = new OgrenciGoruntule();
            ogrenciGoruntule.buttonSecileniGoruntule.Click += new System.EventHandler(this.buttonOgrenciSecileniGoruntule_Click);
            ogrenciGoruntule.buttonArama.Click += new System.EventHandler(this.buttonOgrenciSecileniGoruntule_Click);
            da = new SqlDataAdapter($"SELECT öğrenciID, isim, cepTelefonu FROM Öğrenci;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["öğrenciID"].ColumnName = "Öğrenci ID";
            dt.Columns["isim"].ColumnName = "Ad Soyad";
            dt.Columns["cepTelefonu"].ColumnName = "Cep Telefonu";
            ogrenciGoruntule.dataGridViewOgrenciler.DataSource = dt;
            FormAc(ogrenciGoruntule);
        }


        public void buttonOgrenciEkleSil_Click(object sender, EventArgs e)
        {
            ogrenciEkleSil = new OgrenciEkleSil();
            ogrenciEkleSil.buttonOgrenciEkle.Click += new System.EventHandler(this.buttonOgrenciEklemek_Click);
            ogrenciEkleSil.buttonOgrenciSil.Click += new System.EventHandler(this.buttonOgrenciSilmek_Click);
            FormAc(ogrenciEkleSil);
        }


        //GRUP 2.2 SONU
        //-----------------------------------------------------------


        //-----------------------------------------------------------
        //GRUP 2.3 BAŞI
        //Bu grupta, öğretmen işlemleri menüsü altındaki menüler için açılacak
        //Paneller açılmıştır.
        private void buttonOgretmenGoruntule_Click_1(object sender, EventArgs e)
        {
            ogretmenGoruntule = new OgretmenGoruntule();
            ogretmenGoruntule.buttonArama.Click += new System.EventHandler(this.ogretmenAra_Click);
            ogretmenGoruntule.buttonSecileniGoruntule.Click += new System.EventHandler(this.ogretmenAra_Click);
            da = new SqlDataAdapter("SELECT öğretmenID, ad, cepTelefonu FROM Öğretmen", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["öğretmenID"].ColumnName = "ID";
            dt.Columns["ad"].ColumnName = "Adı";
            dt.Columns["cepTelefonu"].ColumnName = "Cep Telefonu";
            ogretmenGoruntule.dataGridViewOgretmenler.DataSource = dt;
            FormAc(ogretmenGoruntule);
        }

        private void ogretmenAra_Click(object sender, EventArgs e)
        {
            ogretmenDetaylari = new OgretmenDetaylari();
            ogretmenDetaylari.buttonGeriDon.Click += new System.EventHandler(this.ogretmenDetayGeriDon);
            ogretmenDetaylari.buttonDuzenle.Click += new System.EventHandler(this.ogretmenDuzenle_Click);
            ogretmenDetaylari.buttonOgretmenSil.Click += new System.EventHandler(this.ogretmenSil_Click);
            komut = new SqlCommand(ogretmenGoruntule.komut, con);
            SqlDataReader dr = komut.ExecuteReader();
            string bosGun;

            while (dr.Read())
            {
                ogretmenDetaylari.ogrID = dr.GetInt32(0);
                ogretmenDetaylari.textBoxOgretmenAdi.Text = dr.GetString(1);
                ogretmenDetaylari.textBoxEvTelefonu.Text = dr.GetString(2);
                ogretmenDetaylari.textBoxCepTelefonu.Text = dr.GetString(3);
                bosGun = dr.GetString(4);
                ogretmenDetaylari.textBoxIseBaslamaTarihi.Text = dr.GetDateTime(5).ToString();
            }
            //sube
            da = new SqlDataAdapter(ogretmenGoruntule.komutSube, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["şubeID"].ColumnName = "ID";
            dt.Columns["ad"].ColumnName = "Şube Adı";
            ogretmenDetaylari.dataGridViewSubeler.DataSource = dt;
            //dil
            da = new SqlDataAdapter(ogretmenGoruntule.komutDil, con);
            dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dilID"].ColumnName = "Dil ID";
            dt.Columns["dilAdı"].ColumnName = "Dil Adı";
            ogretmenDetaylari.dataGridViewDiller.DataSource = dt;
            //Ders Takvimi
            da = new SqlDataAdapter(ogretmenGoruntule.komutProgram, con);
            dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["günlerSaatler"].ColumnName = "Gün-Saat";
            dt.Columns["dilAdı"].ColumnName = "Dil Adı";
            ogretmenDetaylari.dataGridViewHaftalikDersler.DataSource = dt;
            FormAc(ogretmenDetaylari);
        }

        private void ogretmenSil_Click(object sender, EventArgs e)
        {
            // HATA !!!!
            komut = new SqlCommand(ogretmenDetaylari.komutSil, con);
            komut.ExecuteNonQuery();
            buttonOgretmenGoruntule_Click_1(sender, e);
        }
        private void ogretmenESSil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand(ogretmenEkleSil.komut, con);
            if (komut.ExecuteNonQuery() == 0)
            {
                hataGoster("Böyle bir öğretmen yok.");
                return;
            }
            ogretmenEkleSil.labelDurumBilgisi.Text = "Başarılı";
        }

        private void ogretmenDuzenle_Click(object sender, EventArgs e)
        {
            if (ogretmenDetaylari.buttonDuzenle.Text == "Öğretmen Düzenle")
            {
                ogretmenDetaylari.buttonDuzenle.Text = "Değişiklikleri Kaydet";
                ogretmenDetaylari.buttonGeriDon.Visible = false;
                ogretmenDetaylari.buttonOgretmenSil.Visible = false;
                ogretmenDetaylari.textBoxCepTelefonu.ReadOnly = false;
                ogretmenDetaylari.textBoxCepTelefonu.BackColor = Color.FromArgb(48, 48, 53);
                ogretmenDetaylari.textBoxCepTelefonu.ForeColor = Color.White;
                ogretmenDetaylari.textBoxEvTelefonu.ReadOnly = false;
                ogretmenDetaylari.textBoxEvTelefonu.BackColor = Color.FromArgb(48, 48, 53);
                ogretmenDetaylari.textBoxEvTelefonu.ForeColor = Color.White;
                ogretmenDetaylari.textBoxOgretmenAdi.ReadOnly = false;
                ogretmenDetaylari.textBoxOgretmenAdi.BackColor = Color.FromArgb(48, 48, 53);
                ogretmenDetaylari.textBoxOgretmenAdi.ForeColor = Color.White;
            }
            else
            {
                if (ogretmenDetaylari.textBoxCepTelefonu.TextLength == 0
                    || ogretmenDetaylari.textBoxEvTelefonu.TextLength == 0
                    || ogretmenDetaylari.textBoxOgretmenAdi.TextLength == 0)
                {
                    hataGoster("Boş alan bırakmayınız!");
                    return;
                }
                ogretmenDetaylari.buttonDuzenle.Text = "Öğretmen Düzenle";
                ogretmenDetaylari.buttonGeriDon.Visible = true;
                ogretmenDetaylari.buttonOgretmenSil.Visible = true;
                ogretmenDetaylari.textBoxCepTelefonu.ReadOnly = true;
                ogretmenDetaylari.textBoxCepTelefonu.BackColor = Color.FromArgb(18, 18, 23);
                ogretmenDetaylari.textBoxCepTelefonu.ForeColor = Color.Gold;
                ogretmenDetaylari.textBoxEvTelefonu.ReadOnly = true;
                ogretmenDetaylari.textBoxEvTelefonu.BackColor = Color.FromArgb(18, 18, 23);
                ogretmenDetaylari.textBoxEvTelefonu.ForeColor = Color.Gold;
                ogretmenDetaylari.textBoxOgretmenAdi.ReadOnly = true;
                ogretmenDetaylari.textBoxOgretmenAdi.BackColor = Color.FromArgb(18, 18, 23);
                ogretmenDetaylari.textBoxOgretmenAdi.ForeColor = Color.Gold;

                /*
                UPDATE table_name
                SET column1 = value1, column2 = value2, ...
                WHERE condition;*/
                komut = new SqlCommand($"UPDATE Öğretmen SET ad = '{ogretmenDetaylari.textBoxOgretmenAdi.Text}', evTelefonu = '{ogretmenDetaylari.textBoxEvTelefonu.Text}', cepTelefonu = '{ogretmenDetaylari.textBoxCepTelefonu.Text}' WHERE öğretmenID = {ogretmenDetaylari.ogrID};", con);
                komut.ExecuteNonQuery();
            }
        }

        private void buttonOgretmenEkleSil_Click(object sender, EventArgs e)
        {
            ogretmenEkleSil = new OgretmenEkleSil();
            da = new SqlDataAdapter("SELECT şubeID, ad FROM Şube", con);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            dt1.Columns["şubeID"].ColumnName = "Şube ID";
            dt1.Columns["ad"].ColumnName = "Şube Adı";
            ogretmenEkleSil.dataGridViewSubeler.DataSource = dt1;

            da = new SqlDataAdapter("SELECT dilID, dilAdı FROM Dil", con);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dt2.Columns["dilID"].ColumnName = "Dil ID";
            dt2.Columns["dilAdı"].ColumnName = "Dil";
            ogretmenEkleSil.dataGridViewDiller.DataSource = dt2;

            ogretmenEkleSil.buttonOgretmenEkle.Click += new System.EventHandler(this.buttonOgretmenEklemek_Click);
            ogretmenEkleSil.buttonOgretmenSil.Click += new System.EventHandler(this.ogretmenESSil_Click);
            FormAc(ogretmenEkleSil);
        }


        //GRUP 2.3 SONU
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        //GRUP 3 BAŞI:
        //Bu grupta açılan panellerdeki çeşitli butonlar için işlevsellikler
        //tanımlanmıştır.
        //Bu işlevselliklerin burada tanımlanma nedenleri, panellerin Anasayfa'daki
        //bilgilere erişmesine engel olmaktır.
        private void buttonSecileniGoruntule_Click(object sender, EventArgs e)
        {
            if (subeGoruntule.hataVar)
                return;
            detay = new SubeDetaylari();
            detay.buttonDuzenle.Visible = adminMi;
            komut = new SqlCommand(subeGoruntule.komut, con);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                detay.textBoxSubeID.Text = dr.GetInt32(0).ToString();
                detay.textBoxSubeAdi.Text = dr.GetString(1);
                detay.textAdres.Text = dr.GetString(2);
                detay.textUlasimBilgileri.Text = dr.GetString(3);
                detay.textSosyalOlanak.Text = dr.GetString(4);
            }
            if (detay.textBoxSubeID.TextLength == 0)
            {
                hataGoster("Bu adla bir şube bulunamadı");
                return;
            }
            detay.subeInd = subeGoruntule.secilenSubeIndis;
            //dil öğretir ..

            da = new SqlDataAdapter($"SELECT d.derslikID, d.ad FROM Derslik d, Şube ş WHERE ş.şubeID = {detay.subeInd} AND d.şubeID = ş.şubeID;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["derslikID"].ColumnName = "Sınıf ID";
            dt.Columns["ad"].ColumnName = "Sınıf Adı";
            detay.dataGridView_Sınıf.DataSource = dt;
            //ders
            da = new SqlDataAdapter($"SELECT ders.dersID, derslik.derslikID, derslik.ad, dil.dilAdı, ders.kur FROM Şube şube, Derslik derslik, Ders ders, Dil dil WHERE şube.şubeID = {detay.subeInd} AND şube.şubeID = derslik.şubeID AND derslik.derslikID = ders.derslikID AND ders.dilID = dil.dilID; ", con);
            dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dilAdı"].ColumnName = "Dil";
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["derslikID"].ColumnName = "Derslik ID";
            dt.Columns["kur"].ColumnName = "Kur";
            dt.Columns["ad"].ColumnName = "Sınıf Adı";

            detay.dataGridView_Ders.DataSource = dt;

            detay.buttonDuzenle.Click += new System.EventHandler(this.subeDetayDuzenle_Click);
            detay.buttonSinifGoruntule.Click += new System.EventHandler(this.subeSinifIslemleri_Click);
            detay.buttonDersiGoruntule.Click += new System.EventHandler(this.subeDersIslemleri_Click);
            FormAc(detay);
        }

        private void subeDersIslemleri_Click(object sender, EventArgs e)
        {
            if (detay.buttonDersiGoruntule.Text == "Ders Ekle/Sil")
            {
                dersEkle = new DersEkleSil();
                //burda sıkıntı olabilir ?
                da = new SqlDataAdapter($"SELECT d.dilID,di.dilAdı, ö.öğretmenID, ö.ad FROM Dil di, Şube şub, ŞubedeÇalışır şç, Öğretmen ö, DilÖğretir d " +
                $"WHERE şub.şubeID = {detay.subeInd} AND şub.şubeID = şç.şubeID AND şç.öğretmenID = ö.öğretmenID " +
                $"AND ö.öğretmenID = d.öğretmenID AND d.dilID = di.dilID;", con);
                dersEkle.subeIndis = detay.subeInd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns["dilID"].ColumnName = "Dil ID";
                dt.Columns["dilAdı"].ColumnName = "Dil";
                dt.Columns["öğretmenID"].ColumnName = "ID";
                dt.Columns["ad"].ColumnName = "Ad";
                dersEkle.dataGridViewDiller.DataSource = dt;
                dersEkle.buttonSubeSec.Enabled = false;
                dersEkle.buttonOgretmenSec.Enabled = true;
                dersEkle.buttonOgretmenSec.Click += new System.EventHandler(this.buttonOgretmenSec_Click);
                dersEkle.buttonGün.Click += new System.EventHandler(this.buttonGün_Click);
                dersEkle.buttonSaat.Click += new System.EventHandler(this.buttonSaat_Click);
                dersEkle.buttonDerslikSec.Click += new System.EventHandler(this.buttonDerslikSec_Click);
                dersEkle.buttonDersiEkle.Click += new System.EventHandler(this.buttonDersEkle_Click);
                FormAc(dersEkle);
            }
            else
            {
                dersDetaylari = new DersDetaylari();
                dersDetaylari.buttonDersSil.Visible = adminMi; 
                dersDetaylari.buttonGeriDon.Click += new System.EventHandler(this.dersDetayGeriDon);
                dersDetaylari.buttonDersSil.Click += new System.EventHandler(this.buttonDersSil_Click);
                dersDetaylari.gelinenSayfa = "Şube";
                komutDersGor = $"SELECT ders.dersID, dil.dilAdı, ders.kur, ders.dersÜcreti, öğr.ad, ders.günlerSaatler, derslik.ad " +
                $"FROM Ders ders, Dil dil, Öğretmen öğr, Derslik derslik " +
                $"WHERE ders.dersID = {detay.secilenDersIndis} AND dil.dilID = ders.dilID AND öğr.öğretmenID = ders.öğretmenID " +
                $"AND derslik.derslikID = ders.derslikID;";
                komutOgrenciler = $"SELECT öğr.öğrenciID, öğr.isim FROM Ders ders, DersKaydı dk, Öğrenci öğr " +
                    $"WHERE ders.dersID = {detay.secilenDersIndis} AND ders.dersID = dk.dersID AND dk.öğrenciID = öğr.öğrenciID; ";
                komut = new SqlCommand(komutDersGor, con);
                SqlDataReader dr = komut.ExecuteReader();
                String saatler;
                while (dr.Read())
                {
                    dersDetaylari.textBoxDersID.Text = dr.GetInt32(0).ToString();
                    dersDetaylari.textBoxDersDili.Text = dr.GetString(1);
                    dersDetaylari.textBoxDersKuru.Text = dr.GetString(2);
                    dersDetaylari.textBoxDersUcreti.Text = dr.GetInt32(3).ToString();
                    dersDetaylari.textBoxOgretmen.Text = dr.GetString(4);
                    dersDetaylari.dersProgram = dr.GetString(5);
                    string takvim = gunler[Int32.Parse(dersDetaylari.dersProgram[0].ToString())];
                    takvim += $"\n{dersDetaylari.dersProgram.Substring(2, dersDetaylari.dersProgram.Length - 3)}";
                    dersDetaylari.textBoxDersProgrami.Text = takvim;
                    dersDetaylari.textBoxDerslik.Text = dr.GetString(6);
                }
                // saatler -> ders programı
                da = new SqlDataAdapter(komutOgrenciler, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns["isim"].ColumnName = "Öğrenci Adı";
                dt.Columns["öğrenciID"].ColumnName = "Öğrenci ID";
                dersDetaylari.dataGridViewOgrenciler.DataSource = dt;
                FormAc(dersDetaylari);
            }
        }

        private void subeSinifIslemleri_Click(object sender, EventArgs e)
        {
            if (detay.buttonSinifGoruntule.Text == "Sınıf Ekle/Sil")
            {
                sinifEkleSil = new SinifEkle(detay.subeInd);
                sinifEkleSil.buttonSinifEkle.Click += new System.EventHandler(this.subeSinifEkle_Click);
                sinifEkleSil.buttonGeriDon.Click += new System.EventHandler(this.sinifEkleGeriDon);
                sinifEkleSil.buttonSinifSil.Click += new System.EventHandler(this.subeSinifEkle_Click);
                sinifEkleSil.labelSinifEkle.Text = $"{detay.subeInd} ID'li şube için sınıf ekleme veya silme işlemi";
                FormAc(sinifEkleSil);
            }
            else
            {
                sinifGoruntule = new SinifGoruntule();
                sinifGoruntule.button_SinifSil.Visible = adminMi;
                sinifGoruntule.button_GeriDon.Click += new System.EventHandler(this.sinifGoruntuleGeriDon);
                sinifGoruntule.button_SinifSil.Click += new System.EventHandler(this.buttonSGSinifSilClick);
                sinifGoruntule.button_Duzenle.Click += new System.EventHandler(this.sinifDuzenle_Click);
                komut = new SqlCommand($"SELECT d.derslikID, d.ad FROM Derslik d WHERE d.derslikID = {detay.secilenSinifIndis}", con);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    sinifGoruntule.textBox_SinifID.Text = dr.GetInt32(0).ToString();
                    sinifGoruntule.textBox_SinifAdi.Text = dr.GetString(1);
                }
                da = new SqlDataAdapter($"SELECT dil.dilAdı, ders.kur, ders.günlerSaatler FROM Ders ders, Dil dil WHERE ders.derslikID = {detay.secilenSinifIndis} AND ders.dilID = dil.dilID;", con);
                //ders
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.Columns["dilAdı"].ColumnName = "Dil";
                dt.Columns["kur"].ColumnName = "Kur";
                dt.Columns["günlerSaatler"].ColumnName = "Ders Saatleri";
                sinifGoruntule.dataGridView_Dersler.DataSource = dt;
                FormAc(sinifGoruntule);
            }
        }
        private void buttonSGSinifSilClick(object sender, EventArgs e)
        {
            komut = new SqlCommand(sinifGoruntule.komut, con);
            komut.ExecuteNonQuery();
            buttonSecileniGoruntule_Click(sender, e);
        }
        private void sinifDuzenle_Click(object sender, EventArgs e)
        {
            if (sinifGoruntule.button_Duzenle.Text == "Düzenle")
            {
                sinifGoruntule.button_Duzenle.Text = "Değişiklikleri Kaydet";
                sinifGoruntule.button_GeriDon.Visible = false;
                sinifGoruntule.button_SinifSil.Visible = false;
                sinifGoruntule.textBox_SinifAdi.ReadOnly = false;
                sinifGoruntule.textBox_SinifAdi.BackColor = Color.FromArgb(48, 48, 53);
                sinifGoruntule.textBox_SinifAdi.ForeColor = Color.White;
            }
            else
            {
                if (sinifGoruntule.textBox_SinifAdi.TextLength == 0)
                {
                    hataGoster("Boş alan bırakmayınız!");
                    return;
                }
                sinifGoruntule.button_Duzenle.Text = "Düzenle";
                sinifGoruntule.button_GeriDon.Visible = true;
                sinifGoruntule.button_SinifSil.Visible = true;
                sinifGoruntule.textBox_SinifAdi.ReadOnly = true;
                sinifGoruntule.textBox_SinifAdi.BackColor = Color.FromArgb(18, 18, 23);
                sinifGoruntule.textBox_SinifAdi.ForeColor = Color.Gold;

                /*
                UPDATE table_name
                SET column1 = value1, column2 = value2, ...
                WHERE condition;*/
                komut = new SqlCommand($"UPDATE Derslik SET ad = '{sinifGoruntule.textBox_SinifAdi.Text}' WHERE derslikID = {sinifGoruntule.textBox_SinifID.Text};", con);
                komut.ExecuteNonQuery();
            }
        }
        private void subeSinifEkle_Click(object sender, EventArgs e)
        {
            if (sinifEkleSil.hataVar)
                return;
            komut = new SqlCommand(sinifEkleSil.komut, con);
            komut.ExecuteNonQuery();
            sinifEkleSil.textBoxSinifKodu.Text = "";
            sinifEkleSil.textSilID.Text = "";
        }
        private void subeDetayDuzenle_Click(object sender, EventArgs e)
        {
            if (detay.buttonDuzenle.Text == "Şubeyi Düzenle")
            {
                detay.buttonDuzenle.Text = "Değişiklikleri Kaydet";
                detay.buttonDersiGoruntule.Text = "Ders Ekle/Sil";
                detay.buttonSinifGoruntule.Text = "Sınıf Ekle/Sil";
                detay.textAdres.ReadOnly = false;
                detay.textAdres.ForeColor = Color.White;
                detay.textAdres.BackColor = Color.FromArgb(48, 48, 53);
                detay.textSosyalOlanak.ReadOnly = false;
                detay.textSosyalOlanak.ForeColor = Color.White;
                detay.textSosyalOlanak.BackColor = Color.FromArgb(48, 48, 53);
                detay.textUlasimBilgileri.ReadOnly = false;
                detay.textUlasimBilgileri.ForeColor = Color.White;
                detay.textUlasimBilgileri.BackColor = Color.FromArgb(48, 48, 53);
            }
            else
            {
                if (detay.textBoxSubeAdi.TextLength == 0
                    || detay.textBoxSubeID.TextLength == 0
                    || detay.textSosyalOlanak.TextLength == 0
                    || detay.textAdres.TextLength == 0
                    || detay.textUlasimBilgileri.TextLength == 0)
                {
                    hataGoster("Boş alan bırakmayınız!");
                    return;
                }
                detay.buttonDuzenle.Text = "Şubeyi Düzenle";
                detay.buttonDersiGoruntule.Text = "Seçilen Dersi Görüntüle";
                detay.buttonSinifGoruntule.Text = "Seçilen Sınıfı Görüntüle";
                detay.textBoxSubeAdi.ReadOnly = true;
                detay.textBoxSubeID.ReadOnly = true;
                detay.textAdres.ReadOnly = true;
                detay.textAdres.ForeColor = Color.Gold;
                detay.textAdres.BackColor = Color.FromArgb(18, 18, 23);
                detay.textSosyalOlanak.ReadOnly = true;
                detay.textSosyalOlanak.ForeColor = Color.Gold;
                detay.textSosyalOlanak.BackColor = Color.FromArgb(18, 18, 23);
                detay.textUlasimBilgileri.ReadOnly = true;
                detay.textUlasimBilgileri.ForeColor = Color.Gold;
                detay.textUlasimBilgileri.BackColor = Color.FromArgb(18, 18, 23);

                /*
                UPDATE table_name
                SET column1 = value1, column2 = value2, ...
                WHERE condition;*/
                komut = new SqlCommand($"UPDATE Şube SET adres = '{detay.textAdres.Text}', sosyalOlanaklar = '{detay.textSosyalOlanak.Text}', ulaşım = '{detay.textUlasimBilgileri.Text}' WHERE şubeID = {detay.subeInd} OR ad = '{subeGoruntule.secilenSubeAd}' ;", con);
                komut.ExecuteNonQuery();
            }
        }
        private void subeEklemeSilme(object sender, EventArgs e)
        {
            if (!subeEkleSil.hataVarMı)
            {
                komut = new SqlCommand(subeEkleSil.komut, con);
                try
                {
                    if (komut.ExecuteNonQuery() == 0)
                    {
                        hataGoster("Şube işlenemedi!");
                        return;
                    }
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    hataGoster("Aynı isme sahip bir şube bulunmakta!");
                    return;
                }
                subeEkleSil.labelDurumBilgisi.Text = $"Şube işlendi.";
            }
        }
        private void buttonSubeSec_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter($"SELECT d.dilID, di.dilAdı, ö.öğretmenID, ö.ad FROM Şube şub, ŞubedeÇalışır şç, Öğretmen ö, Dil di, DilÖğretir d " +
                $"WHERE şub.şubeID = {dersEkle.subeIndis} AND şub.şubeID = şç.şubeID AND di.dilID = d.dilID AND şç.öğretmenID = ö.öğretmenID " +
                $"AND ö.öğretmenID = d.öğretmenID;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dilID"].ColumnName = "Dil ID";
            dt.Columns["dilAdı"].ColumnName = "Dil";
            dt.Columns["öğretmenID"].ColumnName = "ID";
            dt.Columns["ad"].ColumnName = "Ad";
            dersEkle.dataGridViewDiller.DataSource = dt;

        }
        private void buttonOgretmenSec_Click(object sender, EventArgs e)
        {


        }
        private void buttonGün_Click(object sender, EventArgs e)
        {
            if (dersEkle.hataVar)
                return;
            komut = new SqlCommand($"SELECT boşGünveSaatler FROM Öğretmen WHERE öğretmenID = {dersEkle.ogretmenIndis}", con);
            SqlDataReader dr = komut.ExecuteReader();
            string bosGun = "";
            while (dr.Read())
                bosGun += dr.GetString(0);
            dersEkle.ogrBosGunSaat = bosGun;
            int baslangic = bosGun.IndexOf(dersEkle.secilenGun + "(") + 2;
            int bitis = bosGun.IndexOf(')', baslangic);
            Console.WriteLine(bosGun.Substring(baslangic, bitis - baslangic));
            string[] saatler = bosGun.Substring(baslangic, bitis - baslangic).Split(',');
            List<int> list = new List<int>();
            foreach (string item in saatler)
            {
                //BUKET BURAYA BAK
                Console.WriteLine(item);
                if(item.Length != 0)
                {
                    list.Add(Int32.Parse(item));
                }
            }
            list.Sort();
            foreach (int item in list)
            {
                dersEkle.listBoxBosSaatler.Items.Add(item.ToString());
            }

        }
        private void buttonSaat_Click(object sender, EventArgs e)
        {
            if (dersEkle.hataVar)
                return;
            komut = new SqlCommand($"SELECT derslikID, boşGunveSaatler FROM derslik WHERE şubeID = {dersEkle.subeIndis}", con);
            SqlDataReader dr = komut.ExecuteReader();
            List<int> uygunDerslikler = new List<int>();
            string bosgun;
            int id;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                bosgun = dr.GetString(1);
                int baslangic = bosgun.IndexOf(dersEkle.secilenGun.ToString() + "(");
                int bitis = bosgun.IndexOf(")", baslangic);
                string secilenGun = bosgun.Substring(baslangic, bitis - baslangic);
                bool eklenecek = true;
                foreach (int item in dersEkle.saatler)
                {
                    if (!secilenGun.Contains(item.ToString()))
                    {
                        eklenecek = false;
                    }
                }
                if (eklenecek)
                {
                    uygunDerslikler.Add(id);
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("Derslik ID");
            foreach (int item in uygunDerslikler)
            {
                DataRow row = dt.NewRow();
                row["Derslik ID"] = item;
                dt.Rows.Add(row);
            }
            dersEkle.dataGridViewDerslikler.DataSource = dt;
        }
        private void buttonDerslikSec_Click(object sender, EventArgs e)
        {
        }
        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            if (dersEkle.hataVar)
                return;
            string gunveSaat = dersEkle.secilenGun + "(";
            for (int i = 0; i < dersEkle.saatler.Count - 1; i++)
            {
                gunveSaat += dersEkle.saatler[i].ToString() + ",";
            }
            if (dersEkle.saatler.Count > 0)
                gunveSaat += dersEkle.saatler[dersEkle.saatler.Count - 1].ToString();
            gunveSaat += ")";
            Console.WriteLine(gunveSaat);
            komut = new SqlCommand($"INSERT INTO Ders (derslikID, dilID, kur, günlerSaatler, dersÜcreti, öğretmenID) " +
                $"VALUES({dersEkle.derslik}, {dersEkle.dilIndis}, '{dersEkle.textKurAdi.Text}', '{gunveSaat}', {dersEkle.ucret}, {dersEkle.ogretmenIndis}); ", con);
            komut.ExecuteNonQuery();
            // derslik boşgünleri düzenlenecek
            string yeniDerslikBosSaatler;
            komut = new SqlCommand($"SELECT boşGunveSaatler FROM derslik where derslikID = {dersEkle.derslik}", con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                string bosgun = dr.GetString(0);
                int baslangic = bosgun.IndexOf(dersEkle.secilenGun.ToString() + "(") + 2;
                int bitis = bosgun.IndexOf(")", baslangic);
                string secilenGun = bosgun.Substring(baslangic, bitis - baslangic);
                yeniDerslikBosSaatler = bosgun.Substring(0, baslangic);
                string[] saat = secilenGun.Split(',');
                for (int i = 0; i < saat.Length - 1; i++)
                {
                    if (!dersEkle.saatler.Contains(Int32.Parse(saat[i])))
                    {
                        yeniDerslikBosSaatler += saat[i] + ",";
                    }
                }
                if (!dersEkle.saatler.Contains(Int32.Parse(saat[saat.Length - 1])))
                {
                    yeniDerslikBosSaatler += saat[saat.Length - 1];
                }
                yeniDerslikBosSaatler += bosgun.Substring(bitis);
                Console.WriteLine(yeniDerslikBosSaatler);
                komut = new SqlCommand($"UPDATE derslik SET boşGunveSaatler = '{yeniDerslikBosSaatler}' WHERE derslikID = {dersEkle.derslik}", con);
                komut.ExecuteNonQuery();
            }

            //Öğretmenin boş gün ve saatleri bişiler yapiliyo

            string bosgunOgr = dersEkle.ogrBosGunSaat;
            Console.WriteLine(bosgunOgr);
            int baslaOgr = bosgunOgr.IndexOf(dersEkle.secilenGun.ToString() + "(") + 2;
            int bitOgr = bosgunOgr.IndexOf(")", baslaOgr);
            string sg = bosgunOgr.Substring(baslaOgr, bitOgr - baslaOgr);
            string ogrBosSaatler = bosgunOgr.Substring(0, baslaOgr);
            string[] ogrSaat = sg.Split(',');
            for (int i = 0; i < ogrSaat.Length - 1; i++)
            {
                if (!dersEkle.saatler.Contains(Int32.Parse(ogrSaat[i])))
                {
                    ogrBosSaatler += ogrSaat[i] + ",";
                }
            }
            if (!dersEkle.saatler.Contains(Int32.Parse(ogrSaat[ogrSaat.Length - 1])))
            {
                ogrBosSaatler += ogrSaat[ogrSaat.Length - 1];
            }
            ogrBosSaatler += bosgunOgr.Substring(bitOgr);
            Console.WriteLine(ogrBosSaatler);



            komut = new SqlCommand($"UPDATE öğretmen SET boşGünveSaatler = '{ogrBosSaatler}' WHERE öğretmenID = {dersEkle.ogretmenIndis}", con);
            komut.ExecuteNonQuery();

            dersEkle.textBoxDersUcreti.Text = "";
            dersEkle.textKurAdi.Text = "";
            dersEkle.ogrBosGunSaat = "";
            dersEkle.listBoxBosSaatler.Items.Clear();
            //datagridler temizlenmedi
        }

        private void buttonOgrenciSecileniGoruntule_Click(object sender, EventArgs e)
        {
            ogrenciDetay = new OgrenciDetaylari(ogrenciGoruntule.secilenOgrenciIndis);
            ogrenciDetay.buttonGeriDon.Click += new System.EventHandler(this.ogrenciDetayGeriDon);
            ogrenciDetay.buttonSil.Click += new System.EventHandler(this.buttonOGRDETOgrenciSil);
            ogrenciDetay.buttonOdemeYap.Click += new System.EventHandler(this.buttonOGRDETOdemeAl);
            ogrenciDetay.buttonDersKayıt.Click += new System.EventHandler(this.buttonOgrenciDersKaydiAc);
            komut = new SqlCommand(ogrenciGoruntule.komut, con);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ogrenciDetay.textBoxOgrenciAdi.Text = dr.GetString(0);
                ogrenciDetay.textBoxEvTelefonu.Text = dr.GetString(1);
                ogrenciDetay.textBoxCepTelefonu.Text = dr.GetString(2);
                ogrenciDetay.richTextBoxOdemeBilgileri.Text = dr.GetString(3);
            }

            da = new SqlDataAdapter($"SELECT dk.dersID,dk.taksitSayısı, dk.borç, dr.dersÜcreti FROM dersKaydı dk, ders dr WHERE dk.borç > 0 AND dk.öğrenciID = {ogrenciDetay.ogrID} AND dk.dersID = dr.dersID;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["taksitSayısı"].ColumnName = "Taksit Sayısı";
            dt.Columns["borç"].ColumnName = "Kalan Borç";
            dt.Columns["dersÜcreti"].ColumnName = "Ders Ücreti";
            ogrenciDetay.dataGridViewTaksitler.DataSource = dt;

            da = new SqlDataAdapter($"select ders.dersID, dil.dilAdı, ders.günlerSaatler from Öğrenci öğr, Dil dil, Ders ders, DersKaydı dk where öğr.öğrenciID = {ogrenciDetay.ogrID} AND öğr.öğrenciID = dk.öğrenciID AND dk.dersID = ders.dersID AND ders.dilID = dil.dilID;", con);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dt2.Columns["dersID"].ColumnName = "Ders ID";
            dt2.Columns["dilAdı"].ColumnName = "Ders";
            dt2.Columns["günlerSaatler"].ColumnName = "Gün ve Saat";

            ogrenciDetay.dataGridViewHaftalikDersler.DataSource = dt2;
            ogrenciDetay.buttonDuzenle.Click += new System.EventHandler(this.ogrenciDetayDuzenle_Click);
            FormAc(ogrenciDetay);
        }

        private void buttonOGRDETOgrenciSil(object sender, EventArgs e)
        {
            komut = new SqlCommand($"DELETE FROM öğrenci WHERE öğrenciID = {ogrenciDetay.ogrID}", con);
            komut.ExecuteNonQuery();
            buttonOgrenciGoruntule_Click(sender, e);
        }

        private void buttonOGRDETOdemeAl(object sender, EventArgs e)
        {
            komut = new SqlCommand(ogrenciDetay.komut, con);
            komut.ExecuteNonQuery();


            da = new SqlDataAdapter($"SELECT dk.dersID,dk.taksitSayısı, dk.borç, dr.dersÜcreti FROM dersKaydı dk, ders dr WHERE dk.borç > 0 AND dk.öğrenciID = {ogrenciDetay.ogrID} AND dk.dersID = dr.dersID;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["taksitSayısı"].ColumnName = "Taksit Sayısı";
            dt.Columns["borç"].ColumnName = "Geçerli Borç";
            dt.Columns["dersÜcreti"].ColumnName = "Dersin Ücreti";
            ogrenciDetay.dataGridViewTaksitler.DataSource = dt;
        }
        public void buttonOgrenciDersKaydiAc(object sender, EventArgs e)
        {
            dersKaydi = new DersKaydi();
            dersKaydi.label1.Text = $"{ogrenciDetay.textBoxOgrenciAdi.Text} için ders kaydı:";
            dersKaydi.buttonGunSec.Click += new System.EventHandler(this.buttonDKGunSec);
            dersKaydi.buttonSaatSec.Click += new System.EventHandler(this.buttonDKSaatSec);
            dersKaydi.buttonDersEkle.Click += new System.EventHandler(this.buttonDKdersEkle);
            dersKaydi.buttonSubeSec.Click += new System.EventHandler(this.buttonDKSubeSec);
            dersKaydi.dataGridViewKurSec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDKKurSec);
            dersKaydi.ogrenciID = ogrenciDetay.ogrID;
            da = new SqlDataAdapter($"select dilID, dilAdı from dil", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dilID"].ColumnName = "Dil ID";
            dt.Columns["dilAdı"].ColumnName = "Dil";
            dersKaydi.dataGridViewDiller.DataSource = dt;
            FormAc(dersKaydi);
        }
        private void buttonDKGunSec(object sender, EventArgs e)
        {
            komut = new SqlCommand(dersKaydi.komut, con);
            SqlDataReader dr = komut.ExecuteReader();
            string bosGunSaat = "";
            List<string> saatler = new List<string>();
            while (dr.Read())
            {
                bosGunSaat = dr.GetString(0);
                string ctrl = bosGunSaat.Substring(2, bosGunSaat.Length - 3);
                if (!saatler.Contains(ctrl))
                    saatler.Add(ctrl);
            }
            foreach (var item in saatler)
            {
                dersKaydi.listBoxSaatler.Items.Add(item);
            }

        }
        private void buttonDKSaatSec(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(dersKaydi.komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dt.Columns["şubeID"].ColumnName = "Şube ID";
            dt.Columns["ad"].ColumnName = "Şube";
            dersKaydi.dataGridViewSubeler.DataSource = dt;
        }
        private void buttonDKSubeSec(object sender, EventArgs e)
        {
            da = new SqlDataAdapter(dersKaydi.komut, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Columns["dersID"].ColumnName = "Ders ID";
            dt.Columns["kur"].ColumnName = "Kur";
            dt.Columns["derslikID"].ColumnName = "Derslik ID";
            dersKaydi.dataGridViewKurSec.DataSource = dt;
        }
        private void dataGridViewDKKurSec(object sender, DataGridViewCellEventArgs e)
        {
            komut = new SqlCommand(dersKaydi.komut, con);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                dersKaydi.textDersUcreti.Text = dr.GetInt32(0).ToString();
            }
        }
        private void buttonDKdersEkle(object sender, EventArgs e)
        {
            komut = new SqlCommand(dersKaydi.komut, con);
            komut.ExecuteNonQuery();
        }
        private void ogrenciDetayDuzenle_Click(object sender, EventArgs e)
        {
            if (ogrenciDetay.buttonDuzenle.Text == "Öğrenciyi Düzenle")
            {
                ogrenciDetay.buttonDuzenle.Text = "Değişiklikleri Kaydet";
                ogrenciDetay.buttonDersKayıt.Visible = false;
                ogrenciDetay.buttonSil.Visible = false;
                ogrenciDetay.textBoxOgrenciAdi.ReadOnly = false;
                ogrenciDetay.textBoxOgrenciAdi.BackColor = Color.FromArgb(48, 48, 53);
                ogrenciDetay.textBoxOgrenciAdi.ForeColor = Color.White;
                ogrenciDetay.textBoxCepTelefonu.ReadOnly = false;
                ogrenciDetay.textBoxCepTelefonu.BackColor = Color.FromArgb(48, 48, 53);
                ogrenciDetay.textBoxCepTelefonu.ForeColor = Color.White;
                ogrenciDetay.textBoxEvTelefonu.ReadOnly = false;
                ogrenciDetay.textBoxEvTelefonu.BackColor = Color.FromArgb(48, 48, 53);
                ogrenciDetay.textBoxEvTelefonu.ForeColor = Color.White;
                ogrenciDetay.richTextBoxOdemeBilgileri.ReadOnly = false;
                ogrenciDetay.richTextBoxOdemeBilgileri.BackColor = Color.FromArgb(48, 48, 53);
                ogrenciDetay.richTextBoxOdemeBilgileri.ForeColor = Color.White;
            }
            else
            {
                if (ogrenciDetay.textBoxOgrenciAdi.TextLength == 0
                    || ogrenciDetay.textBoxCepTelefonu.TextLength == 0
                    || ogrenciDetay.textBoxEvTelefonu.TextLength == 0
                    || ogrenciDetay.richTextBoxOdemeBilgileri.TextLength == 0)
                {
                    hataGoster("Boş alan bırakmayınız!");
                    return;
                }
                ogrenciDetay.buttonDuzenle.Text = "Öğrenciyi Düzenle";
                ogrenciDetay.buttonDersKayıt.Visible = true;
                ogrenciDetay.buttonSil.Visible = true;
                ogrenciDetay.textBoxOgrenciAdi.ReadOnly = true;
                ogrenciDetay.textBoxOgrenciAdi.BackColor = Color.FromArgb(18, 18, 23);
                ogrenciDetay.textBoxOgrenciAdi.ForeColor = Color.Gold;
                ogrenciDetay.textBoxCepTelefonu.ReadOnly = true;
                ogrenciDetay.textBoxCepTelefonu.BackColor = Color.FromArgb(18, 18, 23);
                ogrenciDetay.textBoxCepTelefonu.ForeColor = Color.Gold;
                ogrenciDetay.textBoxEvTelefonu.ReadOnly = true;
                ogrenciDetay.textBoxEvTelefonu.BackColor = Color.FromArgb(18, 18, 23);
                ogrenciDetay.textBoxEvTelefonu.ForeColor = Color.Gold;
                ogrenciDetay.richTextBoxOdemeBilgileri.ReadOnly = true;
                ogrenciDetay.richTextBoxOdemeBilgileri.BackColor = Color.FromArgb(18, 18, 23);
                ogrenciDetay.richTextBoxOdemeBilgileri.ForeColor = Color.Gold;

                /*
                UPDATE table_name
                SET column1 = value1, column2 = value2, ...
                WHERE condition;*/
                komut = new SqlCommand($"UPDATE Öğrenci SET isim = '{ogrenciDetay.textBoxOgrenciAdi.Text}', cepTelefonu = '{ogrenciDetay.textBoxCepTelefonu.Text}', evTelefonu = '{ogrenciDetay.textBoxEvTelefonu.Text}', ödemeBilgileri = '{ogrenciDetay.richTextBoxOdemeBilgileri.Text}' WHERE öğrenciID = {ogrenciGoruntule.secilenOgrenciIndis};", con);
                komut.ExecuteNonQuery();
            }
        }

        public void buttonOgrenciSilmek_Click(object sender, EventArgs e)
        {
            if (!ogrenciEkleSil.hataVarMı)
            {
                komut = new SqlCommand(ogrenciEkleSil.komut, con);
                if (komut.ExecuteNonQuery() == 0)
                {
                    hataGoster("Böyle bir öğrenci yok.");
                    return;
                }
                //aynı isimde bişi için try catch
                ogrenciEkleSil.labelDurumBilgisi.Text = "Başarılı.";
            }
        }

        private void buttonOgrenciEklemek_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand(ogrenciEkleSil.komut, con);
            komut.ExecuteNonQuery();
            ogrenciEkleSil.labelDurumBilgisi.Text = "Başarılı.";
        }
        private void buttonOgretmenEklemek_Click(object sender, EventArgs e)
        {
            if (ogretmenEkleSil.hataVar)
            {
                //ogretmenEkleSil.buttonBosSaatEkle.Enabled = true;
                //ogretmenEkleSil.buttonBosSaatEkle.Text = "Pazartesi günü için\nboş saatleri seç";
                //ogretmenEkleSil.buttonOgretmenEkle.Enabled = false;
                return;
            }
            komut = new SqlCommand(ogretmenEkleSil.komut, con);
            komut.ExecuteNonQuery();

            komut = new SqlCommand("Select max(öğretmenID) from öğretmen", con);

            SqlDataReader dr = komut.ExecuteReader();
            int öğretmenID = -1;
            while (dr.Read())
                öğretmenID = dr.GetInt32(0);
            if (öğretmenID == -1)
            {
                hataGoster("Öğretmen ID'si alınırken hata!");
                return;
            }
            //INSERT INTO table_name(column1, column2, column3, ...)
            //VALUES(value1, value2, value3, ...);
            foreach (int index in ogretmenEkleSil.diller)
            {
                komut = new SqlCommand($"INSERT INTO DilÖğretir (dilID, öğretmenID) VALUES ({index},{öğretmenID});", con);
                komut.ExecuteNonQuery();
                //Console.WriteLine(index + "nolu dil ile " + öğretmenID + " nolu öğretmen arasında bağ kuruldu");
            }
            foreach (int index in ogretmenEkleSil.subeler)
            {
                komut = new SqlCommand($"INSERT INTO ŞubedeÇalışır (öğretmenID, şubeID) VALUES ({öğretmenID},{index});", con);
                komut.ExecuteNonQuery();
                //Console.WriteLine(index + "nolu şube ile " + öğretmenID + " nolu öğretmen arasında bağ kuruldu");
            }
            // komut.
            ogretmenEkleSil.labelDurumBilgisi.Text = "Başarılı.";
        }
        public void girisYapma(object sender, EventArgs e)
        {
            if (giris.textBoxSifre.TextLength == 0 || giris.textBoxSubeAdi.TextLength == 0)
            {
                hataGoster("Boş alan bırakmayınız");
                return;
            }
            if (giris.checkBoxYonetici.Checked)
            {
                if (giris.textBoxSubeAdi.Text == adminAdı && giris.textBoxSifre.Text == adminSifresi)
                {
                    adminMi = true;
                    //giris yapıldı
                    labelDilKursuOtomasyonSistemi.Text = "Dil Kursu Otomasyon Sistemi (YÖNETİCİ)";
                    labelSubeAdi.Text = "";
                    giris.Close();
                    panelYanMenu.Visible = true;
                    buttonDersEkleSil.Visible = true;
                    buttonOgrenciEkleSil.Visible = true;
                    buttonOgretmenEkleSil.Visible = true;
                    buttonSubeEkleSil.Visible = true;
                    //Yönetici Girişi yapıldığında alt menülerin gerekli içeriklerinin görüntülenebileceği şekildeğ
                    panelDersIslemleri.Size = new Size(buttonDersEkleSil.Size.Width, buttonDersEkleSil.Size.Height * 2);
                    panelOgrenciIslemleri.Size = new Size(buttonDersEkleSil.Size.Width, buttonDersEkleSil.Size.Height * 2);
                    panelSubeIslemleri.Size = new Size(buttonDersEkleSil.Size.Width, buttonDersEkleSil.Size.Height * 2);
                    panelOgretmen.Size = new Size(buttonDersEkleSil.Size.Width, buttonDersEkleSil.Size.Height * 2);
                }
                else
                {
                    hataGoster("Böyle bir yönetici hesabı bulunmamakta!");
                    return;
                }
            }
            else
            {
                komut = new SqlCommand($"SELECT * FROM Şube WHERE ad = '{giris.textBoxSubeAdi.Text}' AND password = '{giris.textBoxSifre.Text}';", con);
                labelDilKursuOtomasyonSistemi.Text = "Dil Kursu Otomasyon Sistemi";
                if (komut.ExecuteScalar() != null)
                {
                    adminMi = false;
                    labelSubeAdi.Text = $"Şube Adı : \n{giris.textBoxSubeAdi.Text}";
                    giris.Close();
                    panelYanMenu.Visible = true;
                    buttonDersEkleSil.Visible = false;
                    buttonSubeEkleSil.Visible = false;
                    //Normal kullanıcı girişi yapıldığında, alt menü panellerinin gerekli boyutta gösterilmesi için ayarlama yapılıyor
                    panelDersIslemleri.Size = new Size(buttonDersGoruntule.Size.Width, buttonDersGoruntule.Size.Height);
                    panelOgrenciIslemleri.Size = new Size(buttonDersGoruntule.Size.Width, buttonDersGoruntule.Size.Height * 2);
                    panelSubeIslemleri.Size = new Size(buttonDersGoruntule.Size.Width, buttonDersGoruntule.Size.Height);
                    panelOgretmen.Size = new Size(buttonDersGoruntule.Size.Width, buttonDersGoruntule.Size.Height * 2);
                }
                else
                {
                    hataGoster("Kullanıcı adı ya da şifre yanlış");
                    return;
                }

            }
        }
        //GRUP 3 SONU
        //-----------------------------------------------------------



        //-----------------------------------------------------------
        //GRUP 4 BAŞI:
        //Bu grupta geri dön butonları bulunmaktadır.

        private void dersDetayGeriDon(object sender, EventArgs e)
        {
            if (dersDetaylari.gelinenSayfa == "Şube")
            {
                buttonSecileniGoruntule_Click(sender, e);
            }
            else
            {
                buttonDersGoruntule_Click(sender, e);
            }
        }
        private void ogrenciDetayGeriDon(object sender, EventArgs e)
        {
            buttonOgrenciGoruntule_Click(sender, e);
        }
        private void ogretmenDetayGeriDon(object sender, EventArgs e)
        {
            buttonOgretmenGoruntule_Click_1(sender, e);
        }
        private void sinifGoruntuleGeriDon(object sender, EventArgs e)
        {
            buttonSecileniGoruntule_Click(sender, e);
        }
        private void sinifEkleGeriDon(object sender, EventArgs e)
        {
            buttonSecileniGoruntule_Click(sender, e);
        }
        //GRUP 4 SONU
        //-----------------------------------------------------------




        //-----------------------------------------------------------
        //GRUP 5 BAŞI:
        //Bu grupta, tasarlanan çerçeve için tanımlanan işlevler belirtilmiştir
        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fareBasili = true;
                sonKonum = e.Location;
            }
        }

        private void Anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (fareBasili == true)
            {
                this.Location = new Point((this.Location.X - sonKonum.X) + e.X, (this.Location.Y - sonKonum.Y) + e.Y);
                this.Update();
            }
        }

        private void Anasayfa_MouseUp(object sender, MouseEventArgs e)
        {
            fareBasili = false;
        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            con.Close();
            this.Close();
        }
        private void buttonTamEkran_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonKucult_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void labelDilKursuOtomasyonSistemi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fareBasili = true;
                sonKonum = e.Location;
            }
        }

        private void labelDilKursuOtomasyonSistemi_MouseMove(object sender, MouseEventArgs e)
        {
            if (fareBasili == true)
            {
                this.Location = new Point((this.Location.X - sonKonum.X) + e.X, (this.Location.Y - sonKonum.Y) + e.Y);
                this.Update();
            }
        }

        private void labelDilKursuOtomasyonSistemi_MouseUp(object sender, MouseEventArgs e)
        {

            fareBasili = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayarlama();
        }





        //GRUP 5 SONU
        //--------------------------------------------------------
    }
}
