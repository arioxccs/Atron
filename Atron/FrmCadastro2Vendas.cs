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
    public partial class FrmCadastro2Vendas : Form
    {
        public FrmCadastro2Vendas()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmCarrinho frmCarrinho = new frmCarrinho();
            frmCarrinho.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPopUpConfirmarCancelamento frmPopUpConfirmarCancelamento = new frmPopUpConfirmarCancelamento();
            frmPopUpConfirmarCancelamento.Show();
        }
    }
}
