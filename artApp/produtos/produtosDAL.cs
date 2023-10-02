using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artApp
{
    internal class produtosDAL
    {

        public static void AddProduto(int id, string nome, string descricao, float preco, int quantidade)
        {


            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO Produtos (id, nome, descricao, preco, quantidade) VALUES (@id, @nome, @descricao, @preco, @quantidade)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable GetProdutos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Produtos";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoDAL.DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex);
                throw;
            }
        }

        public static string ObterNomeProduto(int produtoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {

                cmd.CommandText = "SELECT nome FROM Produtos WHERE id = @produtoID";
                cmd.Parameters.AddWithValue("@produtoID", produtoID);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "produto não encontrado";


            }

        }

        public static string ObterValorProduto(int produtoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {

                cmd.CommandText = "SELECT preco FROM Produtos WHERE id = @produtoID";
                cmd.Parameters.AddWithValue("@produtoID", produtoID);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "valor não encontrado";


            }

        }

        public static void ExcluirProduto(int produtoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Produtos WHERE id = @produtoID";
                cmd.Parameters.AddWithValue("@produtoID", produtoID);
                cmd.ExecuteNonQuery();


            }
        }

        public static void EditarProduto(int Novoid, string Novonome, string Novodescricao, float Novopreco, int Novoquantidade)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE Produtos SET nome=@Novonome, descricao=@Novodescricao, preco = @Novopreco, quantidade = @Novoquantidade WHERE id = @Novoid";


                cmd.Parameters.AddWithValue("@Novoid", Novoid);
                cmd.Parameters.AddWithValue("@Novonome", Novonome);
                cmd.Parameters.AddWithValue("@Novodescricao", Novodescricao);
                cmd.Parameters.AddWithValue("@Novopreco", Novopreco);
                cmd.Parameters.AddWithValue("@Novoquantidade", Novoquantidade);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
