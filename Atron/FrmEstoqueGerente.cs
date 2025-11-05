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
    public partial class FrmEstoqueGerente : Form
    {
        public FrmEstoqueGerente()
        {
            InitializeComponent();
        }

        private void lbl_EstoqueTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_GerarRelatorio_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_NivelMaximo_Click(object sender, EventArgs e)
        {

        }

        private void panel_ProdutoEstoque_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new FrmPopupProdutoEstoque().ShowDialog();
        }

        private void btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmCadastrarProdutoGerente TelaAberta = new FrmCadastrarProdutoGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void btn_CadastrarFornecedor_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedorGerente TelaAberta = new FrmCadastroFornecedorGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void btn_EntradaEstoque_Click(object sender, EventArgs e)
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
