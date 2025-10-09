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
    public partial class frmPopUpSenhaFecharCaixa : Form
    {
        public frmPopUpSenhaFecharCaixa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int char1 = int.Parse(txtCaractere1.Text);
            if(char1 == 1)
            {
                frmMenuAbrirCaixa frmMenuAbrirCaixa = new frmMenuAbrirCaixa();
                frmMenuAbrirCaixa.ShowDialog();
            }
            else
            {
                frmAvisoSenhaIncorreta frmAvisoSenhaIncorreta = new frmAvisoSenhaIncorreta(); 
            }
        }
    }
}
