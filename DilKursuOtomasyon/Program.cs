using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DilKursuOtomasyon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Anasayfa anasayfa = new Anasayfa();
         
            Application.Run(anasayfa);
        }
    }
}
