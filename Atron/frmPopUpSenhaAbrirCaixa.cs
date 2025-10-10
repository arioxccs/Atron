using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atron
{
    public partial class frmPopUpSenhaAbrirCaixa : Form
    {
        public frmPopUpSenhaAbrirCaixa()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int char1 = int.Parse(txtCaractere1.Text);
            if (char1== 1)
            {
                frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
                frmMenuFecharCaixa.ShowDialog();
            }
            else
            {
                frmAvisoSenhaIncorreta frmAvisoSenhaIncorreta = new frmAvisoSenhaIncorreta();
                frmAvisoSenhaIncorreta.Show();
            }
        }
    }
}
