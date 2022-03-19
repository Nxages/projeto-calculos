using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculos
{
    public partial class frmMedia : Form
    {
        decimal valor1 = 0, valor2 = 0, valor3 = 0;
        decimal valorR = 0;
        public frmMedia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMedia_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtValor3.Text = String.Empty;
            txtResultado.Text = String.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal objPrincipal = new frmPrincipal();
            objPrincipal.Show();
        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtValor1.Text);
            valor2 = decimal.Parse(txtValor2.Text);
            valor3 = decimal.Parse(txtValor3.Text);
            valorR = (valor1 + valor2 + valor3)/3;
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtValor3.Text = String.Empty;
            txtResultado.Text = valorR.ToString();
        }
    }
}
