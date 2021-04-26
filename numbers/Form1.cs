using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0..0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0,00E00") + "\n");

            double pi = 3.141592653589793;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("N3") + "\n");
            richTextBox1.AppendText(pi.ToString("N5") + "\n");
            richTextBox1.AppendText(pi.ToString("N15") + "\n");

            double c = 2299792458;
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(c.ToString("N0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000E00") + "\n");
           
            richTextBox1.AppendText(c.ToString("0.00E00") + "\n");

            string s = "3";
            string PI = "3.14159265";
            int i = int.Parse(s);
            double d = double.Parse(PI);
            richTextBox1.AppendText(i.ToString() + "\n");
            richTextBox1.AppendText(d.ToString() + "\n");

            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not an integer");
            }
            string s2 = "3.2;";
            try
            {
                int i2 = int.Parse(s2)

            }
            catch
            {
                MessageBox.Show(s2 + "is not an integer"):
                int i2 = 0;

                  
            }
            string s3 = "pi";
            try
            {
                double d2 = double.Parse(s3);

            }
            catch
            {
                double d2 = 0;
            }
           









        }
    }
}
