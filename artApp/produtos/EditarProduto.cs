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

namespace artApp.produtos
{
    public partial class EditarProduto : Form
    {
        int id;
        string nome;
        string descricao;
        float preco;
        int quantidade;

        public EditarProduto(int id, string nome, string descricao, float preco, int quantidade)
        {
            InitializeComponent();
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            textnome.Text = nome;
            textdescricao.Text = descricao;
            textpreco.Text = preco.ToString();
            textquantidade.Text = quantidade.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            produtosDAL.EditarProduto(id, textnome.Text, textdescricao.Text, float.Parse(textpreco.Text), int.Parse(textquantidade.Text));
            MessageBox.Show("Atualizado");
            this.Close();
        }
    }
}
