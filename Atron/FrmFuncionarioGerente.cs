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
    public partial class FrmFuncionarioGerente : Form
    {
        public FrmFuncionarioGerente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_CadastrarFuncionario_Click(object sender, EventArgs e)
        {

            // Cria a nova tela
            FrmCadastroFuncionario frmCadastroFuncionario = new FrmCadastroFuncionario();

            // Pega o formulário principal (FrmGerentePrincipal)
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;

            // Limpa o painel e adiciona a nova tela
            frmPrincipal.Controls["panel2"].Controls.Clear();

            frmCadastroFuncionario.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(frmCadastroFuncionario);
            frmCadastroFuncionario.Show();


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void lbl_Funcionario_Click(object sender, EventArgs e)
        {
            FrmFuncionarioGerente frmFuncionarioGerente = new FrmFuncionarioGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            frmFuncionarioGerente.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(frmFuncionarioGerente);
            frmFuncionarioGerente.Show();
        }
    }
}
