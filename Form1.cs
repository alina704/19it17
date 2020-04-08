using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Flag;

        public double a, b; // сохранить a-первый аргумент, b-второй 

       

        private void one_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1"; //клавиша 1
        }

        private void two_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2"; //клавиша 2
        }

        private void chree_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3"; //клавиша 3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4"; //клавиша 4
        }

        private void five_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5"; //клавиша 5
        }

        private void six_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6"; //клавиша 6
        }

        private void seven_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7"; //клавиша 7
        }

        private void eight_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8"; //клавиша 8
        }

        private void nine_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9"; //клавиша 9
        }

        private void nul_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0"; //клавиша 0
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Flag = 0;
            label1.Text = "+";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "+"; //сложение
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

        private void cos_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Cos(Convert.ToDouble(tb.Text)).ToString();
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
            tb.Text = (1 / Math.Tan(Convert.ToDouble(tb.Text))).ToString();
        }

        private void stepen_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Pow(Convert.ToDouble(3), Convert.ToDouble(2)).ToString();
        }

        private void exponenta_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Exp(Convert.ToDouble(tb.Text)).ToString();
        }

        private void log_Click(object sender, EventArgs e)
        {
            tb.Text = Math.Log(Convert.ToDouble(tb.Text)).ToString();
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

        private void lb3_Click(object sender, EventArgs e)
        {

        }

        private void lb4_Click(object sender, EventArgs e)
        {

        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            string text = tb1.Text;


            text = tb1.Text.Substring(7); // извлечение подстроки


            tb2.Text = text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            string a = tb2.Text.Length.ToString();
            lb1.Text = $"Длина строки: {a}";

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            // Ошибки в строке


            string text = tb1.Text;


            string[] tr = new string[] { "стеклянный", "оловянный", "деревянный", "Ростов", "Ростислав", "росток", "ростовщик", "отрасль", "жи", "ши", "ча", "ща", "чу", "щу" };


            string[] fal = new string[] { "стекляный", "оловяный", "деревяный", "Растов", "Растислав", "расток", "растовщик", "отросль", "жы", "шы", "чя", "щя", "чю", "щю" };


            for (int i = 0; i < tb1.Text.Length; i++)


            {


                for (int j = 0; j < fal.Length; j++) // перебирание ошибок


                {


                    try


                    {


                        if (tb1.Text.Contains(fal[j]))


                            text = tb1.Text.Replace(fal[j], tr[j]); // заменяем ошибки


                        tb1.Text = text;


                    }


                    catch (FormatException)


                    {


                        MessageBox.Show("Строка не может быть пустой!");


                    }





                }


            }


        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            tb.Text = tb1.Text.Replace("!", "?");


            tb2.Text = tb1.Text;

        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            string a = tb2.Text.ToUpper().ToString();


            tb1.Text = a;

        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            {


                int c = 0;


                int d = 0;


                Char[] vowels = new char[] { 'у', 'е', 'ы', 'а', 'о', 'э', 'я', 'и', 'ё', 'ю', 'Е', 'А', 'Е', 'Ы', 'И', 'О', 'У', 'Э', 'Ю', 'Я' };


                Char[] consonants = new char[] { 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п',


                'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б', 'К', 'М', 'Б', 'Г', 'Ш', 'Щ', 'Х', 'Ф', 'З', 'В', 'П',


                'Р', 'Л', 'Ж', 'Д', 'С', 'Ч', 'Ц', 'Т', 'Н'};


                foreach (char s in tb2.Text)


                {


                    if (vowels.Contains(s))


                    {


                        c++;


                    }


                    if (consonants.Contains(s))


                    {


                        d++;


                    }


                }


                string input = tb1.Text;


                int a = 0;


                int b = 0;


                for (int i = 0; i < input.Length; i++)


                {





                    if (char.IsLetter(input[i]))


                        a++;


                    if (char.IsDigit(input[i]))


                        b++;


                }


                lb5.Text = ("Букв : " + a.ToString());


                lb1.Text = ("Цифр : " + b.ToString());


                lb3.Text = ("Строк : " + tb1.Lines.Length);


                lb7.Text = ("Гласных : " + c.ToString());


                lb7.Text = ("Согласных : " + d.ToString());
            }



        }

        private void minus_Click(object sender, EventArgs e)
        {
            Flag = 1;
            label1.Text = "-";
            a = Convert.ToDouble(tb.Text);
            tb.Text = "-"; //вычитание

        }
    }
}
