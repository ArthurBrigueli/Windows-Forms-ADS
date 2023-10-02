
using artApp.classes;
using artApp.clientes;
using artApp.pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artApp
{
    public partial class ListaCliente : Form
    {
        public ListaCliente(DataTable clienteTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = clienteTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //a

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apagar dado da tabela

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index) + 1;

                PessoaDAL.ExcluirCliente(rowIndex);
                MessageBox.Show("Cliente excluido com sucesso");

                this.Close();


                try
                {
                    DataTable clientesTable = PessoaDAL.GetClientes();
                    ListaCliente listacliente = new ListaCliente(clientesTable);
                    listacliente.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um cliente para excluir");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //editar cliente

            if (dataGridView1.SelectedRows.Count > 0)
            {



                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index);
                
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                


                int id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string endereco = selectedRow.Cells["endereco"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string numero = selectedRow.Cells["numero"].Value.ToString();


                EditarCliente editarcliente = new EditarCliente(id, nome, endereco, email, numero);
                editarcliente.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Selecione pelo menos um cliente para editar");
            }
        }

        private void botaosearch_Click(object sender, EventArgs e)
        {
            



        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
