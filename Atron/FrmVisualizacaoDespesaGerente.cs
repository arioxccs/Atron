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
    public partial class FrmVisualizacaoDespesaGerente : Form
    {
        public FrmVisualizacaoDespesaGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDespesasGerente TelaAberta = new FrmDespesasGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void btn_PagoDespesa_Click(object sender, EventArgs e)
        {
            FrmDespesasGerente TelaAberta = new FrmDespesasGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }
    }
}
