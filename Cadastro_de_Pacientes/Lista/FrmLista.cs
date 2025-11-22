using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cadastro_de_Pacientes.Lista
{
    public partial class FrmLista : Form
    {
        public FrmLista()
        {
            InitializeComponent();
        }

        private void FrmLista_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            try
            {
                using (SqlConnection conn = Conexao.Conectar())
                {
                    string query = "SELECT * FROM Produto";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProdutos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista: " + ex.Message);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
