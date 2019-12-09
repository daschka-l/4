using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);

                parabola c = new parabola(a, b);
                label1.Text = (c.Kor()).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат!");
            }
        }
    }
    class parabola
    {
        private double x;
        private double y;

        public double x1
        {
            get { return x; }
            set { x = value; }
        }
        public double y1
        {
            get { return y; }
            set { y = value; }
        }
        public parabola(double x, double y)
        {
            x = x1;
            y = y1;
        }
        ~parabola()
        {
            MessageBox.Show("Объект удалён");
        }
        public string Kor()
        {
            if (y<=2 && y<=-2 && x>-1.5 || x <= 1.5)
            {
                return "лежит";
            }
            else
            {
                return "не лежит";
            }
        }
    }
}
