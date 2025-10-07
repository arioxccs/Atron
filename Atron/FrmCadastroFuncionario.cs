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
    public partial class FrmCadastroFuncionario : Form
    {
        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FrmFuncionarioGerente frmFuncionarioGerente = new FrmFuncionarioGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelGerente"].Controls.Clear();
            frmFuncionarioGerente.TopLevel = false;
            frmPrincipal.Controls["panelGerente"].Controls.Add(frmFuncionarioGerente);
            frmFuncionarioGerente.Show();
        }
    }
}
