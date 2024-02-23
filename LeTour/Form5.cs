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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota = 0;
            if (radioButton3.Checked == true) nota++;
            if (radioButton4.Checked == true) nota++;
            if (radioButton10.Checked == true) nota++;
            if (radioButton18.Checked == true) nota++;
            if (radioButton21.Checked == true) nota++;
            if (radioButton26.Checked == true) nota++;
            if (radioButton13.Checked == true) nota++;
            if (radioButton29.Checked == true) nota++;
            if (radioButton34.Checked == true) nota++;
            if (nota == 9) MessageBox.Show("Felicitări! Ai obținut scorul maxim!");
            else if (nota >= 5) MessageBox.Show("Bravo! Ai obținut " + nota.ToString() + " puncte!");
            else MessageBox.Show("Scorul tău este " + nota.ToString() + " puncte. Mai citește!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
