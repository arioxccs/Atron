namespace Atron
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_CodigoLogin.Text == "1")
            {
                FrmGerentePrincipal frmGerentePrincipal = new FrmGerentePrincipal();
                frmGerentePrincipal.Show();
            }
            else if (txt_CodigoLogin.Text == "2")
            {
                FrmEstoquePrincipal frmEstoquePrincipal = new FrmEstoquePrincipal();
                frmEstoquePrincipal.Show();
            }
            else if (txt_CodigoLogin.Text == "3")
            {
                FrmVendaPrincipal frmVendaPrincipal = new FrmVendaPrincipal();
                frmVendaPrincipal.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_SenhaLogin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
