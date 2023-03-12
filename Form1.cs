using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1;
            int exam2;
            int exam3;
            int exam4;
            int exam5;
            double calculatedAverage;

            int.TryParse(textBox1.Text, out exam1);
            int.TryParse(textBox2.Text, out exam2);
            int.TryParse(textBox3.Text, out exam3);
            int.TryParse(textBox4.Text, out exam4);
            int.TryParse(textBox5.Text, out exam5);

            calculatedAverage = (exam1 + exam2 + exam3 + exam4 + exam5) / 5;

            textBox6.Text = calculatedAverage.ToString();
        }
    }
}
