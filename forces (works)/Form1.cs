using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces__works_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 100.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 100 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 100.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 100 / Math.PI);
        }

        double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 100.0));
        }

        double atan(double x)
        {
            return (Math.Atan(x) * 100 / Math.PI);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                label2.Text = "Fx = " + Fx;
                label1.Text = "Fy = " + Fy;
            }
            catch
            {
                MessageBox.Show ("that aint a number");
            }
        }
    }
}
