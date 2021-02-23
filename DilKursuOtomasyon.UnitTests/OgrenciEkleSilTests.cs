using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DilKursuOtomasyon;
using System.Runtime.InteropServices;

namespace DilKursuOtomasyon.UnitTests
{
    [TestClass]
    public class OgrenciEkleSilTests
    {
        [TestMethod]
        public void OgrenciSil_IDVerilmeyen()
        {
            OgrenciEkleSil oes = new OgrenciEkleSil();
            oes.textBoxSilID.Text = "";
            oes.buttonOgrenciSil_Click_1(null, null);
            Assert.AreEqual(true, oes.hataVarMı);
        }
        [TestMethod]
        public void OgrenciSil_IDVerilen()
        {
            OgrenciEkleSil oes = new OgrenciEkleSil();
            oes.textBoxSilID.Text = "1";
            oes.buttonOgrenciSil_Click_1(null, null);
            Assert.AreEqual("DELETE FROM Öğrenci WHERE öğrenciID = 1;", oes.komut);
        }
        [TestMethod]
        public void OgrenciSil_IDInvalid()
        {
            OgrenciEkleSil oes = new OgrenciEkleSil();
            oes.textBoxSilID.Text = "invalid";
            oes.buttonOgrenciSil_Click_1(null, null);
            Assert.AreEqual(true, oes.hataVarMı);
        }
        [TestMethod]
        public void OgrenciSil_OlmayanOgrenci()
        {
            Anasayfa ana = new Anasayfa();
            ana.buttonOgrenciEkleSil_Click(null, null);
            ana.ogrenciEkleSil.hataVarMı = false;
            ana.ogrenciEkleSil.komut = "DELETE FROM Öğrenci WHERE öğrenciID = 12;";
            ana.buttonOgrenciSilmek_Click(null, null);
            Assert.AreNotEqual("Başarılı.", ana.ogrenciEkleSil.labelDurumBilgisi.Text);
        }
    }
}