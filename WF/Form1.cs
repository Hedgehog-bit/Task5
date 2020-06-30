using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        textBox4.Text += "y(" + i.ToString() + ")= " + F(i).ToString() + Environment.NewLine;
                    }
                    catch
                    {
                        textBox4.Text += "y(" + i.ToString() + ")=error" + Environment.NewLine;
                    }
            }
            catch (FormatException)
            {
                textBox4.Text = "Неверный формат ввода данных";
            }
            catch
            {
                textBox4.Text = "Неизвестная ошибка";
            }
        }
        static double F(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == -1) throw new Exception();
                else return (x + 4 / x * x - 2) + Math.Sqrt(x * x * x - 1);
            }
            catch
            {
                throw;
            }
        }
    }
}
