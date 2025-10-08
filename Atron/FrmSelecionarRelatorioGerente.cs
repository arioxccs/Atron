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
    public partial class FrmSelecionarRelatorioGerente : Form
    {
        public FrmSelecionarRelatorioGerente()
        {
            InitializeComponent();
        }

        private void bt_OpcaoRelatorio_Click(object sender, EventArgs e)
        {
            FrmImprimirRelatorioGerente TelaAberta = new FrmImprimirRelatorioGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void lbl_Relatorio_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
