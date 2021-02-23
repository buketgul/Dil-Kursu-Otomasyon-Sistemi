using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DilKursuOtomasyon.UnitTests
{
    /// <summary>
    /// UnitTest1 için kısa açıklama
    /// </summary>
    [TestClass]
    public class OgrenciGoruntuleTests
    {
        [TestMethod]
        public void OgrenciArama_Invalid()
        {
            OgrenciGoruntule ogrGor = new OgrenciGoruntule();
            ogrGor.textAraID.Text = "invalid";
            ogrGor.buttonArama_Click(null, null);
            Assert.AreEqual("", ogrGor.komut);
        }
        [TestMethod]
        public void OgrenciArama_True()
        {
            OgrenciGoruntule ogrGor = new OgrenciGoruntule();
            ogrGor.textAraID.Text = "1";
            ogrGor.buttonArama_Click(null, null);
            String expected = "SELECT isim, evTelefonu, cepTelefonu, ödemeBilgileri FROM Öğrenci where öğrenciID = 1;";
            Assert.AreEqual(expected, ogrGor.komut);
        }
    }
}
