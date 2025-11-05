using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   

namespace Atron
{
    public partial class FrmCadastroFuncionario : Form
    {


        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            FrmFuncionarioGerente frmFuncionarioGerente = new FrmFuncionarioGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            frmFuncionarioGerente.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(frmFuncionarioGerente);
            frmFuncionarioGerente.Show();
        }

        private void lbl_CPFT_Click(object sender, EventArgs e)
        {

        }

        private void txt_RG_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SalvarFuncionario_Click(object sender, EventArgs e)
        {
            //Uso de um try-catch para fazer a verificação de possíveis erros de conexão com o BD(Caso precise de ajuda me perguntar)
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    //Inicia a query(consulta) que adiciona os doados no BD
                    connection.Open();
                    string query = "INSERT INTO funcionarios (Nome, Cpf, Rg, Data_Nascimento, Endereco, Contato, Funcao,Salario, Forma_de_Pgto, Horas_Mensais) " +
                                  "VALUES (@Nome, @Cpf, @Rg, @Data_Nascimento, @Endereco, @Contato, @Funcao, @Salario, @Forma_de_Pgto, @Horas_Mensais)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        //Campos de texto
                        cmd.Parameters.AddWithValue("@Nome", txt_NomeFuncionario.Text);
                        cmd.Parameters.AddWithValue("@Cpf", txt_CPF.Text);
                        cmd.Parameters.AddWithValue("@Rg", txt_RG.Text);
                        
                        cmd.Parameters.AddWithValue("@Endereco", txt_Endereco.Text);
                        cmd.Parameters.AddWithValue("@Contato", txt_Contato.Text);
                        cmd.Parameters.AddWithValue("@Funcao", txt_Funcao.Text);
                        
                        cmd.Parameters.AddWithValue("@Forma_de_Pgto", txt_Pagamento.Text);
                        

                        
                        //Campos de data
                        cmd.Parameters.AddWithValue("@Data_Nascimento", dtp_Nascimento.Value);

                        //Campos numéricos(e suas conversões)
                        cmd.Parameters.AddWithValue("@Salario", Convert.ToDecimal(txt_Salario.Text));
                        cmd.Parameters.AddWithValue("@Horas_Mensais", Convert.ToInt32(txt_Horas.Text));

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário cadastrado com sucesso!");
                }
            }
            //Aqui o catch nos mostrará a mensagem de erro ao cadastrar o cliente pega pelo sistema
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o funcionário: " + ex.Message);
            };


        }

        private void btn_CacelarCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmFuncionarioGerente frmFuncionarioGerente = new FrmFuncionarioGerente();
            FrmGerentePrincipal frmPrincipal = (FrmGerentePrincipal)this.ParentForm;
            frmPrincipal.Controls["panel2"].Controls.Clear();
            frmFuncionarioGerente.TopLevel = false;
            frmPrincipal.Controls["panel2"].Controls.Add(frmFuncionarioGerente);
            frmFuncionarioGerente.Show();
        }

        private void dtp_Nascimento_ValueChanged(object sender, EventArgs e)
        {
            dtp_Nascimento.Format = DateTimePickerFormat.Custom;
            dtp_Nascimento.CustomFormat = "dd/MM/yyyy";
        }
    }
}
