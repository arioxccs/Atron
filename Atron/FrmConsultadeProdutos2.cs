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
    public partial class FrmConsultadeProdutos2 : Form
    {
        public FrmConsultadeProdutos2()
        {
            InitializeComponent();
        }

        private void FrmConsultadeProdutos2_Load(object sender, EventArgs e)
        {

        }

        private void FrmConsultadeProdutos2_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            FrmConsultadeProdutos3 TelaAberta = new FrmConsultadeProdutos3();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }
    }
}
