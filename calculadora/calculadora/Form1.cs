using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";

            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

            textBox2.Text = "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

            textBox2.Text = "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultado = true;

            textBox2.Text += "=";

            if(adicao == true)
            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) + calculo);

                textBox2.Text += textBox1.Text;
            }
            if (subtracao == true)
            {
                textBox1.Text = Convert.ToString(calculo - Convert.ToDecimal(textBox1.Text));

                textBox2.Text += textBox1.Text;
            }
            if (multiplicacao == true)
            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) * calculo);

                textBox2.Text += textBox1.Text;
            }
            if (divisao == true)
            {
                textBox1.Text = Convert.ToString(calculo / Convert.ToDecimal(textBox1.Text));

                textBox2.Text += textBox1.Text;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(textBox2.Text);

            textBox2.Text += "+";

            textBox1.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(textBox2.Text);

            textBox2.Text += "-";

            textBox1.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(textBox2.Text);

            textBox2.Text += "x";

            textBox1.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (subtracao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;

                textBox1.Text = Convert.ToString(valor1 - (percentual * valor1));

                textBox2.Text += "% =";
                textBox2.Text += "textBox1.Text";
            }
            else if (adicao == true)
            {
                double valor1 = Convert.ToDouble(calculo);
                double percentual = Convert.ToDouble(textBox1.Text) / 100;

                textBox1.Text = Convert.ToString(valor1 + (percentual * valor1));

                textBox2.Text += "% =";
                textBox2.Text += "textBox1.Text";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = textBox1.Text;

                apagar = apagar.Remove(apagar.Length - 1);

                textBox1.Text = apagar;

                textBox2.Text = apagar;

            }
            catch (Exception)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculo = decimal.Parse(textBox2.Text);

            textBox2.Text += "/";

            textBox1.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

            textBox2.Text = "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";

            textBox2.Text = ",";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                if(x < 0)
                {
                    MessageBox.Show("Valor invalido, tente novamente!");
                }
                else
                {
                    x = Math.Sqrt(x);
                    textBox1.Text = x.ToString();

                    textBox2.Text += "V =";
                    textBox2.Text += x.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
