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
    public partial class Pedidos : Form
    {
        private Timer timer;
        public Pedidos()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Intervalo em milissegundos (1 segundo)
            timer.Tick += txtrelogio_Click;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPedido cadastrarpedido = new CadastrarPedido();
            cadastrarpedido.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable listasTable = pedidosDAL.GetPedido();
                ListaPedidos listapedidos = new ListaPedidos(listasTable);
                listapedidos.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable pedidoTable = pedidosDAL.GetPedidoFechado();
                PedidosFechados pedidofechado = new PedidosFechados(pedidoTable);
                pedidofechado.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtrelogio_Click(object sender, EventArgs e)
        {
            txtrelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
