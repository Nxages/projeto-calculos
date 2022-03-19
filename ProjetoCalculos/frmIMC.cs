using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjetoCalculos
{
    public partial class frmIMC : Form
    {
        float peso = 0;
        float altura = 0;
        float result = 0;

        public frmIMC()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            peso = float.Parse(txtPeso.Text, CultureInfo.InvariantCulture);
            altura = float.Parse(txtAltura.Text, CultureInfo.InvariantCulture);
            result = (peso /(altura*altura));
            txtResult.Text = result.ToString();
            if (result <= 18.5)
            {
                lblSituacao.Text = "Baixo Peso";
            }
            else if (result <= 24.99)
            {
                lblSituacao.Text = "Normal";
            }
            else if (result <= 29.99)
            {
                lblSituacao.Text = "Sobrepeso";
            }
            else if (result > 30)
            {
                lblSituacao.Text = "Obesidade";
            }

        }

        private void frmIMC_Load(object sender, EventArgs e)
        {

        }

        private void txtVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal objPrincipal = new frmPrincipal();
            objPrincipal.Show();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtAltura.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtResult.Text = String.Empty;
            lblSituacao.Text = String.Empty;
        }
    }
}
