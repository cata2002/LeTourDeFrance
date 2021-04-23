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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("tour.rtf");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("tour.rtf");
            richTextBox2.LoadFile("format.rtf");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }
    }
}
