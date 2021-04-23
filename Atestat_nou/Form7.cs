using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_nou
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            //webBrowser1.Navigate("https://www.google.ro/maps/dir/Luz+Ardiden,+Fran%C5%A3a/Tourmalet,+Fran%C5%A3a/64000+Pau,+Fran%C5%A3a/@43.0891823,-0.3499936,10z/data=!3m1!4b1!4m20!4m19!1m5!1m1!1s0x12a81fc86dcd67d5:0x406f69c2f3d7b90!2m2!1d-0.002869!2d42.873542!1m5!1m1!1s0x12a8232c2337291f:0xa8f743ee7c738c44!2m2!1d0.1862736!2d42.9148946!1m5!1m1!1s0xd564885b45c7ae9:0x4066517481394b0!2m2!1d-0.370797!2d43.2951!3e1");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
