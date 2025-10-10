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
    public partial class frmMenuAbrirCaixa : Form
    {
        public frmMenuAbrirCaixa()
        {
            InitializeComponent();
        }

        private void pctAbrirCaixa_Click(object sender, EventArgs e)
        {
            frmPopUpSenhaAbrirCaixa frmPopUpSenhaAbrirCaixa = new frmPopUpSenhaAbrirCaixa();
            frmPopUpSenhaAbrirCaixa.Show();
        }
    }
}
