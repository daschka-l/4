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

                double x= Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);

                Parabola parabola = new Parabola(x, y);
                if (parabola.IsBelong())
                {
                    label1.Text = "Точка принадлежит области";
                    label1.ForeColor = Color.Green;
                }else
                {
                    label1.Text = "Точка не принадлежит области";
                    label1.ForeColor = Color.Red;
                }
            }
                
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат!");
            }
        }
    }
}
