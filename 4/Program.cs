using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{

    class Parabola 
    {
        private double x;    
        private double y;
        
        public Parabola(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Вернет True, если точка принадлежит области или False в противном случае
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsBelong()
        {
            return (2 - Math.Pow(this.x, 2) - this.y > 0) & (this.y > -2);
        }

        ~Parabola() 
        {
            // MessageBox.Show("Объект удалён");
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
