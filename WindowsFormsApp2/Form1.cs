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

        public int Flag;
        
        public double a, b; // сохранить a-первый аргумент, b-второй 
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void minus_Click(object sender, EventArgs e)
        {
            Flag = 1;
            label1.Text = "-";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "-"; //вычитание

        }

        private void umnogenie_Click(object sender, EventArgs e)
        {
            Flag = 2;
            label1.Text = "*";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "*"; //умножение

        }

        private void delenie_Click(object sender, EventArgs e)
        {
            Flag = 3;
            label1.Text = "/";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "/"; //деление

        }

        private void ochstit_Click(object sender, EventArgs e)
        {
            tb.Text = " ";
            a = 0;
            b = 0; //стереть содержимое памяти

        }

        private void one_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1"; //клавиша 1
        }

        private void two_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2";//клавиша 2
        }

        private void chree_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9";
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            try
            {

                b = Convert.ToDouble(tb.Text);


                if (Flag == 0)
                {
                    tb.Text = Convert.ToString(a + b); //действия функций
                }
                if (Flag == 1)
                {
                    tb.Text = Convert.ToString(a - b);
                }
                if (Flag == 2)
                {
                    tb.Text = Convert.ToString(a * b);
                }
                if (Flag == 3)
                {
                    if (b == 3)
                    {
                        label1.Text = "На ноль делить нельзя";
                    }
                    else tb.Text = Convert.ToString(a / b);
                }
            }
            catch (FormatException)
            {
                label1.Text = "Это не число";
            }
            {
                tb.Text = Convert.ToString(a / b);
            }

           
            

        }

        private void nul_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0"; //клавиша 0
        }

        private void cos_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Cos(Convert.ToDouble(tb.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void koren_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Sqrt(Convert.ToDouble(tb.Text)).ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Tan(Convert.ToDouble(tb.Text)).ToString();
        }

        private void sin_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Sin(Convert.ToDouble(tb.Text)).ToString();
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            tb.Text = (1/Math.Tan(Convert.ToDouble(tb.Text))).ToString();
        }

        private void stepen_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Pow(Convert.ToDouble(3),Convert.ToDouble(2)).ToString();
        }

        private void exponenta_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Exp(Convert.ToDouble(tb.Text)).ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Log(Convert.ToDouble(tb.Text)).ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bin_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb.Text);
            tb.Text = Convert.ToString(i, 2);// перевод в 2-систему
        }

        private void oct_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb.Text);
            tb.Text = Convert.ToString(i, 8);// перевод в 8-систему
        }

        private void hex_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb.Text);
            tb.Text = Convert.ToString(i, 16); // перевод в 16-систему
        }

        private void dec_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(tb.Text);
            tb.Text = Convert.ToString(i, 10);// перевод в 10-систему
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Flag = 0;
            label1.Text = "+";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "+";// сложение

        }
    }
}