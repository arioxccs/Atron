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
    public partial class FrmDespesasGerente : Form
    {
        public FrmDespesasGerente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_DespesaAtrasadaTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarDespesa_Click(object sender, EventArgs e)
        {
            FrmCadastroDespesaGerente TelaAberta = new FrmCadastroDespesaGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }
    }
}
