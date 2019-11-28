using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Функции
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 1 - уровень доступа
        // 2 - тип возвращаемого значения
        // void - не возвращает значения
        // 3 - название функции
        // 4 - параметрЫ
        public int Summa(int a,int b) // в круглых скобках "ингридиенты" функции || параметры
        {
            //int sum = a + b;
            //return sum;
            return a + b;
        }
        public void Multiple(double a, double b)
        {
            richTextBox1.Text = "" + a * b; // (a * b).ToString();
        }
        public double delenie(int a ,int b)
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b);
        }
        public double ost(int c , int d)
        {
            return c % d ;
        }
        public void bolshee(int a, int b)
        {
            if (a > b)
            {
                richTextBox1.Text = "" + a;
            }
            else if (b > a)
            {
                richTextBox1.Text = "" + b;
            }
            else if (a == b)
            {
                richTextBox1.Text = "Числа равны" + "";
            }
        }
        public void mass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                richTextBox1.Text += " " + arr[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 вариант
            int s = Summa(10, 5);
            richTextBox1.Text = s.ToString();

            // 2 ВАРИАНТ
            richTextBox1.Text += "\n" + Summa(10, 3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double chislo1 = 2.5 , chislo2 = 4.6;
            Multiple(chislo1, chislo2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += delenie(14, 5) + "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ost(14, 5) + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = 12, b = 15;
            bolshee(a, b);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(1, 50);
            }
            mass(arr);
        }
    }
}
