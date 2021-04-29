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
    public partial class Form9 : Form
    {
        public ChromiumWebBrowser browser;

        public void InitBrowser()
        {
            if (Ch.initializat == 0)
            {
                Cef.Initialize(new CefSettings());
                Ch.initializat = 1;
            }
            browser = new ChromiumWebBrowser("https://www.google.ro/maps/dir/Sorgues,+Fran%C5%A3a/Mont+Ventoux,+Mont+Ventoux,+Fran%C5%A3a/Malauc%C3%A8ne,+Fran%C5%A3a/@44.0920974,4.936553,11z/data=!3m1!4b1!4m20!4m19!1m5!1m1!1s0x12b592c1f220a219:0xcf43c973b1e49f2b!2m2!1d4.872757!2d44.008767!1m5!1m1!1s0x12ca6445e355e229:0x5f4f2d8cdf6cfec5!2m2!1d5.2783791!2d44.173993!1m5!1m1!1s0x12ca7982c9c1396f:0x3dc142606e1527c4!2m2!1d5.1320499!2d44.17444!3e1");
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        public Form9()
        {
            InitializeComponent();
            InitBrowser();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
