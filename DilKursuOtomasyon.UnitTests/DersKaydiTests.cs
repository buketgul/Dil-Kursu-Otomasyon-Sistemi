﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace DilKursuOtomasyon.UnitTests
{
    /// <summary>
    /// 

    

/*
 * 
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Şube", typeof(int));
            dt1.Columns.Add("ad", typeof(string));
            dt1.Rows.Add(1, "Şube");
            oes.dataGridViewSubeler.DataSource = dt1;
*/
    /// DersKaydiTests için kısa açıklama
    /// </summary>
    [TestClass]
    public class DersKaydiTests
    {
        private DersKaydi dersKaydi;
        [SetUp]
        public void Setup()
        {
            dersKaydi = new DersKaydi();
        }
        [TearDown]
        public void TearDown()
        {
            dersKaydi.Dispose();
            dersKaydi = null;
        }

        [Test]
        public void GunSec_Secilmeyen()
        {
            dersKaydi.buttonGunSec.Enabled = true;
            dersKaydi.dilID = "1";
            dersKaydi.buttonGunSec_Click(null, null);
            Assert.AreEqual("", dersKaydi.komut);
        }
        [Test]
        public void SaatSec_Secilmeyen()
        {
            dersKaydi.buttonSaatSec.Enabled = true;
            dersKaydi.buttonSaatSec_Click(null, null);
            Assert.AreEqual("", dersKaydi.komut);
        }
        [TestCase(0, 12)]
        [TestCase(1, 9)]
        [TestCase(2, 6)]
        [TestCase(3, 3)]
        [TestCase(4, 0)]

        public void taksitHesapla(int index, int expected)
        {
            dersKaydi.groupBoxTaksitler.Controls[index].Select();
            int sonuc = dersKaydi.taksitHesapla();
            Assert.AreEqual(expected, sonuc);
        }
        /*
        [TestCase("admin", "admin", true, true)]
        [TestCase("admin", "admin", false, false)]
        [TestCase("invalid", "admin", true, false)]
        [TestCase("admin", "invalid", true, false)]
        public void GirisYapma_AdminMi(string subeAdi, string sifre, bool check, bool expected)
        {
            anasayfa.giris.textBoxSifre.Text = sifre;
            anasayfa.giris.textBoxSubeAdi.Text = subeAdi;
            anasayfa.giris.checkBoxYonetici.Checked = check;
            anasayfa.girisYapma(null, null);
            Assert.AreEqual(expected, anasayfa.adminMi);
        }*/

    }
}
