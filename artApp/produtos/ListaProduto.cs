using artApp.clientes;
using artApp.pedidos;
using artApp.produtos;
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
    public partial class ListaProduto : Form
    {
        public ListaProduto(DataTable produtotable)
        {
            InitializeComponent();
            dataGridView1.DataSource = produtotable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index) + 1;

                produtosDAL.ExcluirProduto(rowIndex);
                MessageBox.Show("Produto excluido com sucesso");







            }
            else
            {
                MessageBox.Show("Selecione pelo menos algum produto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //editar

            if (dataGridView1.SelectedRows.Count > 0)
            {



                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index);

                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];




                int id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                string nome = selectedRow.Cells["nome"].Value.ToString();
                string descricao = selectedRow.Cells["descricao"].Value.ToString();
                float preco = float.Parse(selectedRow.Cells["preco"].Value.ToString());
                int quantidade = int.Parse(selectedRow.Cells["quantidade"].Value.ToString());


                EditarProduto editarproduto = new EditarProduto(id, nome, descricao, preco, quantidade);
                editarproduto.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Selecione pelo menos um cliente para editar");
            }
        }
    }
}
