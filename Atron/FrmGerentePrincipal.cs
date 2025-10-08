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
    public partial class FrmGerentePrincipal : Form
    {

        public FrmGerentePrincipal()
        {
            InitializeComponent();
        }

        private Form frmAtivo;

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in panel_MenuGerente.Controls)
                ctrl.BackColor = Color.FromArgb(255, 179, 92);

            frmAtivo.BackColor = Color.FromArgb(137, 81, 41);
        }

        private void FrmGerentePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_VendasMenuGerente_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_VendasMenuGerente);
            FormShow(new FrmResumoVendas());
        }

        private void btn_EstoqueMenuGerente_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_EstoqueMenuGerente);
            FormShow(new FrmEstoqueGerente());
        }

        private void btn_FuncionariosMenuGerente_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_FuncionariosMenuGerente);
            FormShow(new FrmFuncionarioGerente());
        }

        private void btn_DespesasMenuGerente_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_DespesasMenuGerente);
            FormShow(new FrmDespesasGerente());
        }

        private void btn_pedidosMenuGerente_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_pedidosMenuGerente);
            FormShow(new FrmPedidoGerente());
        }
    }
}
