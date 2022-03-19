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

    public partial class frmMediaP : Form
    {
        double valor1 = 0, valor2 = 0, valor3 = 0;
        double valorR = 0;
        double peso = 0;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtValor3.Text = String.Empty;
            txtResultado.Text = String.Empty;
            txtPeso.Text = String.Empty;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal objPrincipal = new frmPrincipal();
            objPrincipal.Show();
        }

        public frmMediaP()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            valor3 = double.Parse(txtValor3.Text);
            peso = double.Parse(txtPeso.Text);
            valorR = (valor1*peso + valor2*peso + valor3*peso) / peso;
            txtValor1.Text = String.Empty;
            txtValor2.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtValor3.Text = String.Empty;
            txtResultado.Text = valorR.ToString();
        }
    }
}
