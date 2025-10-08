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
    public partial class FrmCadastroFornecedorGerente : Form
    {
        public FrmCadastroFornecedorGerente()
        {
            InitializeComponent();
        }

        private void FrmCadastroFornecedorGerente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            FrmEstoqueGerente TelaAberta = new FrmEstoqueGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }
    }
}
