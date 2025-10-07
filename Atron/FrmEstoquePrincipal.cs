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
    public partial class FrmEstoquePrincipal : Form
    {
        private Form frmAtivo;
        public FrmEstoquePrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelGerente.Controls.Add(frm);
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
            foreach (Control ctrl in panel_MenuEstoque.Controls)
                ctrl.BackColor = Color.FromArgb(255, 151, 54);

            frmAtivo.BackColor = Color.FromArgb(137, 81, 41);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarMenu_Click(object sender, EventArgs e)
        {
            ActiveButton(btn_RegistrarMenuEstoque);
            FormShow(new FrmGerenciamentoRegistros());
        }

        private void Teste_Click(object sender, EventArgs e)
        {

        }

        private void FrmEstoquePrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
