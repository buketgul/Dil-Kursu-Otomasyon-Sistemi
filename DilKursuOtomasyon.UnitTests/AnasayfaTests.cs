using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DilKursuOtomasyon;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using Moq;
using Castle.Components.DictionaryAdapter.Xml;
using System.Diagnostics;
using System.Windows.Forms;
using Telerik.JustMock;

namespace DilKursuOtomasyon.UnitTests
{
    /// <summary>
    /// UnitTest1 için kısa açıklama
    /// </summary>
    [TestFixture]
    public class AnasayfaTests
    {
        private Anasayfa anasayfa;
        [SetUp]
        public void Setup()
        {
            anasayfa = new Anasayfa();
        }
        [TearDown]
        public void TearDown()
        {
            anasayfa.Dispose();
            anasayfa = null;
        }

        [Test]
        public void GirisYapma_BosAlan()
        {
            anasayfa.giris.textBoxSifre.Text = "";
            anasayfa.giris.textBoxSubeAdi.Text = "";
            anasayfa.girisYapma(null, null);
            Assert.AreEqual(false, anasayfa.adminMi);
        }

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
        }
        [Test]
        public void GirisYapma_AdminGirisi_YoneticiEkrani()
        {
            anasayfa.giris.textBoxSifre.Text = "admin";
            anasayfa.giris.textBoxSubeAdi.Text = "admin";
            anasayfa.giris.checkBoxYonetici.Checked = true;
            anasayfa.girisYapma(null, null);
            Assert.AreEqual("Dil Kursu Otomasyon Sistemi (YÖNETİCİ)", anasayfa.labelDilKursuOtomasyonSistemi.Text);
        }

        [Test]
        public void GirisYapma_Admin_DersEklemeMenusu()
        {
            anasayfa.giris.textBoxSifre.Text = "admin";
            anasayfa.giris.textBoxSubeAdi.Text = "admin";
            anasayfa.giris.checkBoxYonetici.Checked = true;
            anasayfa.girisYapma(null, null);
            Assert.IsFalse(anasayfa.buttonDersEkleSil.Visible);
        }

        [Test]
        public void GirisYapma_Admin_SubeEkleMenusu()
        {
            anasayfa.giris.textBoxSifre.Text = "admin";
            anasayfa.giris.textBoxSubeAdi.Text = "admin";
            anasayfa.giris.checkBoxYonetici.Checked = true;
            anasayfa.girisYapma(null, null);
            Assert.IsFalse(anasayfa.buttonSubeEkleSil.Visible);
        }
    }
}