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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
            frmMenuFecharCaixa.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Uso de um try-catch para fazer a verificação de possíveis erros de conexão com o BD(Caso precise de ajuda me perguntar)
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    //Inicia a consulta que adiciona os dados no BD
                    connection.Open();
                    string salvar = "INSERT INTO cliente(Nome, Cpf, Telefone, Rg,Data_Nascimento, Email, Rua, Numero, Bairro, Cidade, Uf, Cep, Complemento) " +
                                  "VALUES (@Nome, @Cpf, @Telefone, @Rg,@Data_Nascimento, @Email, @Rua, @Numero, @Bairro, @Cidade, @Uf, @Cep, @Complemento)";

                    using (MySqlCommand comando = new MySqlCommand(salvar, connection))
                    {
                        //Campos de texto
                        comando.Parameters.AddWithValue("@Nome", txtNome.Text);
                        comando.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                        comando.Parameters.AddWithValue("@Rg", txtRg.Text);

                        comando.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                        comando.Parameters.AddWithValue("@Email", txtEmail.Text);
                        comando.Parameters.AddWithValue("@Rua", txtRua.Text);

                        comando.Parameters.AddWithValue("@Numero", txtNumero.Text);
                        comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                        comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);

                        comando.Parameters.AddWithValue("@Uf", cmbUf.Text);
                        comando.Parameters.AddWithValue("@Cep", txtCep.Text);
                        comando.Parameters.AddWithValue("@Complemento", txtComplemento.Text);

                        //Campos de data
                        comando.Parameters.AddWithValue("@Data_Nascimento", dtpData.Value);
 
                       comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
            }
            //Aqui o catch nos mostrará a mensagem de erro ao cadastrar o cliente pega pelo sistema
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o cliente: " + ex.Message);
            };


        }

    }
}
