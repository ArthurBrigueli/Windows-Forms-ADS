using artApp.classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace artApp
{
    public partial class ListaPedidos : Form
    {
        public ListaPedidos(DataTable listapedido)
        {
            InitializeComponent();
            dataGridView1.DataSource = listapedido;
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

                pedidosDAL.ExcluirPedido(rowIndex);
                MessageBox.Show("Pedido excluido com sucesso");
                this.Close();


            }
            else
            {
                MessageBox.Show("Selecione pelo menos um pedido para excluir");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fechar pedido
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                

                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index);
                
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];

                pedidosDAL.FecharPedido(rowIndex + 1);


                int id = int.Parse(selectedRow.Cells["id"].Value.ToString());
                string datha = selectedRow.Cells["data"].Value.ToString();
                int id_cliente = int.Parse(selectedRow.Cells["id_cliente"].Value.ToString());
                string nome_peoduto = selectedRow.Cells["nome_produto"].Value.ToString();
                float valor = float.Parse(selectedRow.Cells["valor"].Value.ToString());
                int status = int.Parse(0.ToString());

                Pedido pedido = new Pedido(id, datha, id_cliente, nome_peoduto, valor, status);

                pedidosDAL.TransferirPedidoFechado(pedidosDAL.GetPedidoFechado().Rows.Count+1, pedido.datha, pedido.id_cliente, pedido.nome_produto, pedido.valor, pedido.status);
                pedidosDAL.ExcluirPedido(pedido.id);
                MessageBox.Show($"{pedido.id} fechado com sucesso");
                this.Close();


            }
            else
            {
                MessageBox.Show("Selecione pelo menos um pedido para excluir");
            }
        }

        private void botaosearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
