using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using artApp.classes;
using System.Windows.Forms;

namespace artApp.pedidos
{
    internal class pedidosDAL
    {
        public static void AddPedido(int id, string data, int id_cliente, float valor, string nome_produto, int status)
        {


            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO pedidos (id, data, id_cliente, valor, nome_produto, status) VALUES (@id, @data, @id_cliente, @valor, @nome_produto, @status)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data", data);
                    cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
                    cmd.Parameters.AddWithValue("@status", status);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable GetPedidoFechado()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pedidofechado";
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

        public static DataTable GetPedido()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pedidos";
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


        public static void ExcluirPedido(int pedidoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM pedidos WHERE id = @pedidoID";
                cmd.Parameters.AddWithValue("@pedidoID", pedidoID);
                cmd.ExecuteNonQuery();


            }
        }

        public static void ExcluirPedidoFechado(int pedidoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM pedidofechado WHERE id = @pedidoID";
                cmd.Parameters.AddWithValue("@pedidoID", pedidoID);
                cmd.ExecuteNonQuery();


            }
        }

        public static void FecharPedido(int pedidoID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE pedidos SET status = false WHERE id = @pedidoID";
                cmd.Parameters.AddWithValue("@pedidoID", pedidoID);
                cmd.ExecuteNonQuery();
            }


        }


        

        public static void TransferirPedidoFechado(int id, string data, int id_cliente, string nome_produto, float valor, int status)
        {

            using(var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "INSERT INTO PedidoFechado (id, data, id_cliente, nome_produto, valor, status) VALUES (@id, @data, @id_cliente, @nome_produto, @valor, @status)";
                //definir os valores que vão ser substituídos pelos parâmetros
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
                cmd.Parameters.AddWithValue("@valor", valor);
                cmd.Parameters.AddWithValue("@status", status);
                //executar a query sql
                cmd.ExecuteNonQuery();
            }


 


        }
    }
}
