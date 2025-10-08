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
    public partial class FrmImprimirRelatorioGerente : Form
    {
        public FrmImprimirRelatorioGerente()
        {
            InitializeComponent();
        }

        private void btn_CertoRelatorio_Click(object sender, EventArgs e)
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
