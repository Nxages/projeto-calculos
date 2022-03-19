using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace ProjetoCalculos
{
    public partial class frmCalculadora : Form
    {
        double valor1 = 0, valor2 = 0;
        string sinal = "";

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal objPrincipal = new frmPrincipal();
            objPrincipal.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtVisor.Text = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "3";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtVisor.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            if (sinal == "SOMA")
            {
                txtVisor.Text = Convert.ToString(valor1 + valor2);
            }
            else if (sinal == "SUB")
            {
                txtVisor.Text = Convert.ToString(valor1 - valor2);
            }
            else if (sinal == "MULT")
            {
                txtVisor.Text = Convert.ToString(valor1 * valor2);
            }
            else if (sinal == "DIV")
            {
                txtVisor.Text = Convert.ToString(valor1 / valor2);
            }
            lblSinal.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            sinal = "SOMA";
            lblSinal.Text = "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            sinal = "SUB";
            lblSinal.Text = "-";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            sinal = "MULT";
            lblSinal.Text = "x";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtVisor.Text, CultureInfo.InvariantCulture);
            txtVisor.Text = "";
            sinal = "DIV";
            lblSinal.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtVisor.Text += ".";
        }
    }
}
