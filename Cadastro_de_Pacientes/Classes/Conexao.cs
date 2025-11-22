using System.Data.SqlClient;

namespace Cadastro_de_Pacientes
{
    public static class Conexao
    {
        public static SqlConnection Conectar()
        {
            string connString = @"Server=DESKTOP-CPGN9I6\SQLEXPRESS;Database=CadastroDB;Trusted_Connection=True;TrustServerCertificate=True;";


            return new SqlConnection(connString);
        }
    }
}
