                                    Sistema de Gerenciamento de Produtos
Objetivo do Projeto
 O objetivo deste projeto foi desenvolver um sistema simples de gerenciamento de produtos utilizando Windows Forms, C# e SQL Server.
 O sistema permite:


Cadastrar produtos


Listar produtos em um DataGridView


Salvar e consultar informações no banco de dados SQL Server


Ferramentas Utilizadas


Visual Studio Community


SQL Server Express


SQL Server Management Studio (SSMS)


Banco de Dados
 Foi criado o banco SistemaSimples com a tabela Produto.


Script SQL da tabela Produto:
 CREATE DATABASE SistemaSimples;
 GO
USE SistemaSimples;
 GO
CREATE TABLE Produto (
 ProdutoId INT PRIMARY KEY IDENTITY,
 Nome NVARCHAR(100),
 Descricao NVARCHAR(200),
 Preco DECIMAL(10,2),
 Quantidade INT
 );
Estrutura do Projeto em C#


4.1 Classe de Conexão (Conexao.cs)
 using System.Data.SqlClient;
 namespace GerenciamentoProduto.Dados
 {
 public class Conexao
 {
 private static string conexaoString =
 @"Server=DESKTOP-CPGN9I6\SQLEXPRESS;Database=SistemaSimples;Trusted_Connection=True;";
   public static SqlConnection Conectar()
    {
        return new SqlConnection(conexaoString);
    }
}

}
4.2 Formulário de Cadastro (FrmCadastro.cs)
 Componentes: txtNome, txtDescricao, txtPreco, txtQuantidade, btnSalvar, btnListar
btnSalvar_Click:
 using (SqlConnection conn = Conexao.Conectar())
 {
 string query = @"INSERT INTO Produto (Nome, Descricao, Preco, Quantidade) VALUES (@Nome, @Descricao, @Preco, @Quantidade)";
 SqlCommand cmd = new SqlCommand(query, conn);

 cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
 cmd.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
 cmd.Parameters.AddWithValue("@Preco", decimal.Parse(txtPreco.Text));
 cmd.Parameters.AddWithValue("@Quantidade", int.Parse(txtQuantidade.Text));

 conn.Open();
 cmd.ExecuteNonQuery();
 MessageBox.Show("Produto cadastrado com sucesso!");
 }


btnListar_Click:
 FrmLista lista = new FrmLista();
 lista.ShowDialog();


4.3 Formulário de Listagem (FrmLista.cs)
 Componentes: dgvProdutos, btnVoltar
FrmLista_Load:
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


btnVoltar_Click:
 this.Close();


4.4 Program.cs
 using GerenciamentoProduto.Telas;
 using System;
 using System.Windows.Forms;
namespace GerenciamentoProduto
 {
 internal static class Program
 {
 [STAThread]
 static void Main()
 {
 Application.EnableVisualStyles();
 Application.SetCompatibleTextRenderingDefault(false);
 Application.Run(new FrmCadastro());
 }
 }
 }



Criação do banco de dados e tabela Produto no SSMS.


Configuração da classe de conexão com o SQL Server (Conexao.cs).


Criação do formulário de cadastro (FrmCadastro) com campos e botões.


Implementação do botão Salvar que insere dados no banco.


Criação do formulário de listagem (FrmLista) com DataGridView.


Implementação do botão Listar que abre a tela de listagem e carrega os produtos.


Adição do botão Voltar na tela de listagem que retorna para o cadastro.


Testes com produtos reais (ex: Arroz 1kg, Preço 7,50, Quantidade 20) e verificação no DataGridView.


Resultado Final
 Tela de Cadastro:



| Cadastro de Produto – Gerenciamento |
Nome: [                       ]
Descrição:[                  ]
 Preço: [___________]
 Quantidade: [              ]
[Salvar] [Listar Produtos]
Tela de Listagem:
| ID | Nome | Descrição | Preço | Quantidade |
| 1 | Arroz | 1 kg | 7,50 | 20 |
[Voltar]
Conclusão
 Consegui atingir os objetivos propostos, permitindo cadastrar e listar produtos em um sistema simples com C# Windows Forms e SQL Server.




