using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Print(string resa34567ult)
        {
            richTextBox1.Text = resa34567ult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //лыатыдпаыдпдои
            //jnsdlnsldnvlsdknv
            //nbsfkjnsfnlsnfljns
            ////sjflsnlfvsljnv
            ///////sflsflkjdfl
            string resault;
            double D;
            double x1;
            double x2;
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;

            double A = Convert.ToDouble(a);
            double B = Convert.ToDouble(b);
            double C = Convert.ToDouble(c);
             

            D = (B * B) - 4 * A * C;
            A = A * 2;
            if (D < 0)
            {
                resault ="Нет корней";
                Print("Ytn rjhtytwq");  
                Print(resault);
            }

            else
            {
                if (D == 0)
                {
                    x1 = -B / A;
                    resault =" "+x1.ToString();
                }
                else
                {
                    D = Math.Sqrt(D);
                    x1 = (D - B) / A;
                    x2 = (D + B) / A;
                    resault = " " + x1.ToString() + " "+x2.ToString();                   
                }

               
            }
        }
    }
}
