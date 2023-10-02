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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace artApp
{
    public partial class CadastrarPedido : Form
    {
        public CadastrarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validar pedido
            int id_cliente = int.Parse(textidcliente.Text);
            string nome_cliente = PessoaDAL.ObterNomeCliente(id_cliente);
            textnomecliente.Text = nome_cliente;

            int id_produto = int.Parse(textidproduto.Text);
            string nome_produto = produtosDAL.ObterNomeProduto(id_produto);
            textnomeproduto.Text = nome_produto;

            string valor_produto = produtosDAL.ObterValorProduto(id_produto);
            textvalorpedido.Text = valor_produto;
            

            
        }

        private void textidcliente_TextChanged(object sender, EventArgs e)
        {
            //id cliente
        }

        private void textnomecliente_TextChanged(object sender, EventArgs e)
        {
            //nome cliente
        }

        private void textidpedido_TextChanged(object sender, EventArgs e)
        {
            //id produto
        }

        private void textnomeproduto_TextChanged(object sender, EventArgs e)
        {
            //nome produto
        }

        private void textvalorpedido_TextChanged(object sender, EventArgs e)
        {
            //valor produto

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cadastrar pedido

            DateTime dataagora = DateTime.Now;
            string dat = dataagora.ToString();
            int status = 1;

            Pedido pedido = new Pedido(pedidosDAL.GetPedido().Rows.Count + 1, dat, int.Parse(textidcliente.Text), textnomeproduto.Text, float.Parse(textvalorpedido.Text), status);


            pedidosDAL.AddPedido(pedido.id, pedido.datha, pedido.id_cliente, pedido.valor, pedido.nome_produto, pedido.status);
            MessageBox.Show($"Pedido {pedido.id} gerado com sucesso");
            this.Close();

        }

        private void CadastrarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
