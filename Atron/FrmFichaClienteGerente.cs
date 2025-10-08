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
    public partial class FrmFichaClienteGerente : Form
    {
        public FrmFichaClienteGerente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FrmClientesGerente TelaAberta = new FrmClientesGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }
    }
}
