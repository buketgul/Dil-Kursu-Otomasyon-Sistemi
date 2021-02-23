using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System.Data;

namespace DilKursuOtomasyon.UnitTests
{
    /// <summary>
    /// OgretmenEkleSilTests için kısa açıklama
    /// </summary>
    [TestClass]
    public class OgretmenEkleSilTests
    {
        [TestCase(1, "1(13)", 5)]
        [TestCase(6, "6(8)", 0)]
        public void BosSaatEkle(int gun, string bosSaat, int selectedIndex)
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.simdikiGun = gun;
            oes.listBoxBosSaatler.SetSelected(selectedIndex, true);
            oes.buttonBosSaatEkle_Click(null, null);
            if(gun == 6)
            {
                Assert.AreEqual("Tüm günleri doldurdunuz", oes.buttonBosSaatEkle.Text);
            }
            Assert.AreEqual(bosSaat, oes.bosGunlerVeSaatler);
        }
        [TestCase(1, "1(11,13)", 5, 3)]
        [TestCase(6, "6(8,18)", 0, 10)]
        public void BosSaatEkle_BirdenFazla(int gun, string bosSaat, int selectedIndex, int sInd2)
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.simdikiGun = gun;
            oes.listBoxBosSaatler.SetSelected(selectedIndex, true);
            oes.listBoxBosSaatler.SetSelected(sInd2, true);
            oes.buttonBosSaatEkle_Click(null, null);
            if(gun == 6)
            {
                Assert.AreEqual("Tüm günleri doldurdunuz", oes.buttonBosSaatEkle.Text);
            }
            Assert.AreEqual(bosSaat, oes.bosGunlerVeSaatler);
        }

        [TestMethod]
        public void OgretmenEkle_AdiVerilmeyen()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "02124282297";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;

            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_CepTelefonVerilmeyen()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "";
            oes.textEvTelefonu.Text = "02124282297";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_EvTelefonVerilmeyen()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_LongCepTel()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "050514242800000";
            oes.textEvTelefonu.Text = "02124282297";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_LongEvTel()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "021242822973424";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_InvalidEvTel()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "invalid";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_InvalidCepTel()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "invalid";
            oes.textEvTelefonu.Text = "02124282297";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_DilSecilmeyen()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "02124282297";
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;


            oes.dataGridViewSubeler.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
        [TestMethod]
        public void OgretmenEkle_SubeSecilmeyen()
        {
            OgretmenEkleSil oes = new OgretmenEkleSil();
            oes.textAd.Text = "Buket";
            oes.textCepTelefonu.Text = "05051424280";
            oes.textEvTelefonu.Text = "02124282297";

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Dil", typeof(int));
            dt2.Columns.Add("ad", typeof(string));
            dt2.Rows.Add(3, "Dil");
            oes.dataGridViewDiller.DataSource = dt2;
            oes.dataGridViewDiller.Rows[0].Selected = true;
            oes.buttonOgretmenEkle_Click(null, null);
            Assert.AreEqual(true, oes.hataVar);
        }
    }
}
