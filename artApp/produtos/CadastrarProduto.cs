using artApp.classes;
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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classes.Produto produto = new classes.Produto(produtosDAL.GetProdutos().Rows.Count + 1, textnome.Text, textdescricao.Text, float.Parse(textpreco.Text), int.Parse(textquantidade.Text));
            produtosDAL.AddProduto(produto.id, produto.nome, produto.descricao, produto.preco, produto.quantidade);
            MessageBox.Show($"{produto.nome} cadastrado");
            this.Close();
        }
    }
}
