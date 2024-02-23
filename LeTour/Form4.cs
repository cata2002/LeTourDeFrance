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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Etape.rtf");
            richTextBox2.LoadFile("Detalii_etape.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();//paris
            f7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();//tourmalet
            f8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();//mont_v
            f9.ShowDialog();
        }
    }
}
