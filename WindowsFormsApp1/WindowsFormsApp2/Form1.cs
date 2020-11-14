using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resault;
        string A;
        string B;
        string C;
        double a;
        double b;
        double c;
        double D;
        double x1;
        double x2;
        private void Read()
        {
            A = readA.Text;
            B = readB.Text;
            C = readC.Text;
            a = Convert.ToDouble(A);
            b = Convert.ToDouble(B);
            c = Convert.ToDouble(C);
        }

        private void Count()
        {
            D = (b * b) - 4 * a * c;
            if (D < 0)
                resault = "Нет корней.";
            else
            {
                if (D == 0)
                {
                    x1 = -b / (2 * a);
                    resault = "Корень равен " + x1.ToString() + ".";
                }
                else
                {
                    D = Math.Sqrt(D);
                    x1 = (-b + D) / (2 * a);
                    x2 = (-b - D) / (2 * a);
                    resault = "Первый корень равен " + x1.ToString() + ", второй корень равен " + x2.ToString() + ".";
                }
            }
        }

        private void Write()
        {
            writeX.Text = resault;
        }
        private void count_Click(object sender, EventArgs e)
        {
            Read();
            Count();
            Write();
        }
    }
}
