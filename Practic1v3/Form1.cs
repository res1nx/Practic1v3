using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic1v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text) *  Math.Pow(10, Convert.ToDouble(textBox4.Text));
            textBox6.Text += "X = " + textBox1.Text + '\r' + '\n';
            double y = Convert.ToDouble(textBox2.Text);
            textBox6.Text += "Y = " + textBox2.Text + '\r' + '\n';
            double z = Convert.ToDouble(textBox3.Text) * Math.Pow(10, Convert.ToDouble(textBox4.Text));
            textBox6.Text += "Z = " + (textBox3.Text) + "\r" + '\n';

            double a = 1 + Math.Pow(Math.Sin(x + y), 2);
            double b = Math.Abs(x - 2 * y / 1 + Math.Pow(x, 2) * Math.Pow(y, 2));
            double d = Math.Pow(x, y);
            double c = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            double u = a / b * d + c;
            textBox6.Text += string.Format(@"Результат U= {0:#.000} ", u) + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text += "Практ.раб N1 Ст.гр. 165 **ИМЯ И ФАМ**";
        }
    }
}
