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
            browser = new ChromiumWebBrowser("www.google.com");
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
