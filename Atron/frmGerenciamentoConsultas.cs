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
    public partial class frmGerenciamentoConsultas : Form
    {
        public frmGerenciamentoConsultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmConsultadeProdutos2 TelaAberta = new FrmConsultadeProdutos2();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmConsultadePedidos1 TelaAberta = new FrmConsultadePedidos1();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }
    }
}
