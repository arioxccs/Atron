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
    public partial class FrmConsultadePedidos1 : Form
    {
        public FrmConsultadePedidos1()
        {
            InitializeComponent();
        }

        private void FrmConsultadePedidos1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FrmConsultadePedidos2 TelaAberta = new FrmConsultadePedidos2();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }
    }
}
