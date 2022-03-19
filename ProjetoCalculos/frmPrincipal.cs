namespace ProjetoCalculos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCalculadora objCalculadora = new frmCalculadora();
            objCalculadora.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedia objMedia = new frmMedia();
            objMedia.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIMC objIMC = new frmIMC();
            objIMC.Show();
        }

        private void btnMediaP_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMediaP objMediaP = new frmMediaP();
            objMediaP.Show();
        }
    }
}