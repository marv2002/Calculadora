
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primerNum;
        string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            string s = "0";
            if (textBox1.Text.Length > 1)
            {
                s = textBox1.Text;
                s = s.Substring(0, s.Length - 1);
            }
            textBox1.Text = s;
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            
             textBox1.Text = textBox1.Text + "0";
            
        }

        private void bAdSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.StartsWith("-"))
            {  
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else if (!string.IsNullOrEmpty(textBox1.Text) && decimal.Parse(textBox1.Text) != 0)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
        }


        private void bAd_Click(object sender, EventArgs e)
        {
            primerNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operacion = "+";
        }

        private void bSub_Click(object sender, EventArgs e)
        {
            primerNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operacion = "-";
        }

        private void bMul_Click(object sender, EventArgs e)
        {
            primerNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operacion = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            primerNum = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operacion = "/";
        }
        private void nequal_Click(object sender, EventArgs e)
        {
            double segundoNum;
            double resultado;
            segundoNum = Convert.ToDouble(textBox1.Text);
            if (operacion == "+")
            {
                resultado = primerNum + segundoNum;
                textBox1.Text = Convert.ToString(resultado);
                primerNum = resultado;
            }
            if (operacion == "-")
            {
                resultado = (primerNum - segundoNum);
                textBox1.Text = Convert.ToString(resultado);
                primerNum = resultado;
            }
            if (operacion == "*")
            {
                resultado = (primerNum * segundoNum);
                textBox1.Text = Convert.ToString(resultado);
                primerNum = resultado;
            }
            if (operacion == "/")
            {
                if (segundoNum == 0)
                {
                    textBox1.Text = "ERROR.";
                }
                else
                {
                    resultado = (primerNum / segundoNum);
                    textBox1.Text = Convert.ToString(resultado);
                    primerNum = resultado;
                }
            }
        }
    }
}