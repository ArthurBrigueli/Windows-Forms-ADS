using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artApp.pedidos
{
    public partial class PedidosFechados : Form
    {
        public PedidosFechados(DataTable pedidoTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = pedidoTable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = (dataGridView1.SelectedRows[0].Index) + 1;

                pedidosDAL.ExcluirPedidoFechado(rowIndex);
                MessageBox.Show("Pedido excluido com sucesso");
                this.Close();


            }
            else
            {
                MessageBox.Show("Selecione pelo menos um pedido para excluir");
            }
        }
    }
}
