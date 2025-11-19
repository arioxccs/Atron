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
    public partial class FrmCadastrarVendas2 : Form
    {
        public FrmCadastrarVendas2()
        {
            InitializeComponent();
        }

        private void lblCadastrodeVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //Uso de um try-catch para fazer a verificação de possíveis erros de conexão com o BD(Caso precise de ajuda me perguntar)
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    //Inicia a consulta que adiciona os doados no BD
                    connection.Open();
                    string cadastro = "INSERT INTO venda (Id_Cliente, Id_Produto, Data_Venda, Valor_Total, Forma_Pgto, Qtde_Parcelas) " +
                                  "VALUES (@Id_Cliente, @Id_Produto, @Data_Venda, @Valor_Total, @Forma_Pgto, @Qtde_Parcelas)";

                    using (MySqlCommand comando = new MySqlCommand(cadastro, connection))
                    {
                        //Campos de texto
                        comando.Parameters.AddWithValue("@Id_Cliente", txtCodCliente.Text);
                        comando.Parameters.AddWithValue("@Id_Produto", txtCodProduto.Text);
                        comando.Parameters.AddWithValue("@Forma_Pgto", txtFormaPgto.Text);

                        comando.Parameters.AddWithValue("@Qtde_Parcelas", txtQtdeParcelas.Text);



                        //Campos de data
                        comando.Parameters.AddWithValue("@Data_Venda", dtpData.Value);

                        //Campos numéricos(e suas conversões)
                        comando.Parameters.AddWithValue("@Valor_Total", Convert.ToDecimal(txtValorTotal.Text));


                        comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Venda cadastrada com sucesso!");
                }
            }
            //Aqui o catch nos mostrará a mensagem de erro ao cadastrar o cliente pega pelo sistema
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a venda: " + ex.Message);
            }
                ;


        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddOutraVenda_Click(object sender, EventArgs e)
        {
            FrmCadastrarVendas frmCadastrarVendas = new FrmCadastrarVendas();
            frmCadastrarVendas.ShowDialog();
        }

        private void FrmCadastrarVendas2_Load(object sender, EventArgs e)
        {

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        { 
         
        
            try
            {
                string query = "SELECT idCliente, Nome FROM Cliente";

                MySqlConnection con = new MySqlConnection("server=localhost;database=SEUBANCO;user=root;password=SUASENHA;");
                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();

                cbxCliente.DataSource = dt;
                cbxCliente.DisplayMember = "Nome";      // O que aparece na lista
                cbxCliente.ValueMember = "idCliente";   // Valor interno (ID)
                cbxCliente.SelectedIndex = -1;          // Começa sem seleção
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }
    }

    }


