using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Karatsuba_Multiplication
{
    public partial class Form1 : Form
    {
        Karatsuba k;
        Stopwatch sw;
        public Form1()
        {
            InitializeComponent();
        }

      
        public void setLabel(Label mylabel, string text, Color color)
        {
            mylabel.Text = text;
            mylabel.ForeColor = color;
        }

        private void karatsubaMultiply_Click(object sender, EventArgs e)
        {
            long x, y, answer;
            if (long.TryParse(textBox1.Text, out x) && long.TryParse(textBox2.Text, out y))
            {
                k = new Karatsuba();
                sw = new Stopwatch();
                sw.Start();
                answer = k.multiply(long.Parse(textBox1.Text), long.Parse(textBox2.Text));
                sw.Stop();
                setLabel(outputLabel, answer.ToString(), Color.Black);
                setLabel(karatsubaTimeLabel, sw.Elapsed.ToString(), Color.Black);
            }
            else
            {
                setLabel(outputLabel, "Error", Color.Red);
            }
        }

        private void normalMultiplyButton_Click(object sender, EventArgs e)
        {
            long x, y, answer;
            if (long.TryParse(textBox1.Text, out x) && long.TryParse(textBox2.Text, out y))
            {
                sw = new Stopwatch();
                sw.Start();
                answer = long.Parse(textBox1.Text) *  long.Parse(textBox2.Text);
                sw.Stop();
                setLabel(outputLabel, answer.ToString(), Color.Black);
                setLabel(normalTimeLabel, sw.Elapsed.ToString(), Color.Black);
            }
            else
            {
                setLabel(outputLabel, "Error", Color.Red);
            }
        }

    }

   
}
