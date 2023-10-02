using artApp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace artApp
{

    public class PessoaDAL
    {


        public static void AddCliente(int id, string nome, string endereco, string email, string numero)
        {


            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    //criar a query (consulta) sql
                    cmd.CommandText = "INSERT INTO pessoas (id, nome, endereco, email, numero) VALUES (@id, @nome, @endereco, @email, @numero)";
                    //definir os valores que vão ser substituídos pelos parâmetros
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    //executar a query sql
                    cmd.ExecuteNonQuery();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public static DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoDAL.DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM pessoas";
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

        



        public static string ObterNomeCliente(int clienteID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {

                cmd.CommandText = "SELECT nome FROM pessoas WHERE id = @ClienteID";
                cmd.Parameters.AddWithValue("@ClienteID", clienteID);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "Cliente não encontrado";


            }

        }

        public static void ExcluirCliente(int clienteID)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM pessoas WHERE id = @clienteID";
                cmd.Parameters.AddWithValue("@clienteID", clienteID);
                cmd.ExecuteNonQuery();
                

            }
        }


        
        

        public static void EditarCliente(int Novoid, string Novonome, string Novoendereco, string Novoemail, string Novonumero)
        {
            using (var cmd = conexaoDAL.DbConnection().CreateCommand())
            {
                cmd.CommandText = "UPDATE pessoas SET nome=@Novonome, endereco=@Novoendereco, email = @Novoemail, numero = @Novonumero WHERE id = @Novoid";


                cmd.Parameters.AddWithValue("@Novoid", Novoid);
                cmd.Parameters.AddWithValue("@Novonome", Novonome);
                cmd.Parameters.AddWithValue("@Novoendereco", Novoendereco);
                cmd.Parameters.AddWithValue("@Novoemail", Novoemail);
                cmd.Parameters.AddWithValue("@Novonumero", Novonumero);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
