using Cadastro_de_Pacientes;
using Cadastro_de_Pacientes.Lista;
using Cadastro_de_Pacientes;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerenciamentoProduto.Telas
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexao.Conectar())
            {
                string query = @"INSERT INTO Produto 
                                 (Nome, Descricao, Preco, Quantidade) 
                                 VALUES (@Nome, @Descricao, @Preco, @Quantidade)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
                cmd.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));

                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmLista lista = new FrmLista();
            lista.ShowDialog();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
