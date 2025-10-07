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
            FrmFichaFuncionario novaTela = new FrmFichaFuncionario();

            // Pega o formulário pai (FrmGerentePrincipal)
            FrmGerentePrincipal formPai = (FrmGerentePrincipal)this.ParentForm;

            // Limpa o painel e adiciona a nova tela
            formPai.Controls["panelGerente"].Controls.Clear();

            novaTela.TopLevel = false;
            formPai.Controls["panelGerente"].Controls.Add(novaTela);
            novaTela.Show();
 

    }
}
}
