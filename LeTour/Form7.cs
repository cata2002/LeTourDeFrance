using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace Atestat_nou
{
    public partial class Form7 : Form
    {
        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            if (Ch.initializat == 0)
            {
                Cef.Initialize(new CefSettings());
                Ch.initializat = 1;
            }
            browser = new ChromiumWebBrowser("https://www.google.ro/maps/dir/Chatou,+Fran%C5%A3a/Champs-%C3%89lys%C3%A9es,+Paris,+Fran%C5%A3a/@48.894553,2.1996008,13z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x47e66301411d4b17:0x40b82c3688c4260!2m2!1d2.160098!2d48.896391!1m5!1m1!1s0x47e66fc518637631:0x7c6b92d2c2465999!2m2!1d2.3077957!2d48.8662294!3e1");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        public Form7()
        {
            InitializeComponent();
            InitBrowser();
            //webBrowser1.Navigate("https://www.google.ro/maps/dir/Chatou,+Fran%C5%A3a/Champs-%C3%89lys%C3%A9es,+Paris,+Fran%C5%A3a/@48.894553,2.1996008,13z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x47e66301411d4b17:0x40b82c3688c4260!2m2!1d2.160098!2d48.896391!1m5!1m1!1s0x47e66fc518637631:0x7c6b92d2c2465999!2m2!1d2.3077957!2d48.8662294!3e1");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
