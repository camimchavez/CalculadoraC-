using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        double Valor1, Valor2;
        string Op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(txtPantalla.Text == "")
            {
                txtPantalla.Text = "1";
            }
            else 
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "2";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "3";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "4";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "5";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "6";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "7";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "8";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "9";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Valor1 = 0;
            Valor2 = 0;
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(txtPantalla.Text);
            Op = "/";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(txtPantalla.Text);
            Op = "+";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(txtPantalla.Text);
            Op = "-";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Valor1 = Convert.ToDouble(txtPantalla.Text);
            Op = "*";
            txtPantalla.Clear();
            txtPantalla.Focus();

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Valor2 = Convert.ToDouble(txtPantalla.Text);
            switch(Op)
            {
                case "+": txtPantalla.Text = Convert.ToString(Valor1 + Valor2); break;
                case "-": txtPantalla.Text = Convert.ToString(Valor1 - Valor2); break;
                case "*": txtPantalla.Text = Convert.ToString(Valor1 * Valor2); break;
                case "/": txtPantalla.Text = Convert.ToString(Valor1 / Valor2); break;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = ".";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + ".";
            }
        }
    }
}
