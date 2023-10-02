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
    public partial class Produtos : Form
    {
        private Timer timer;
        public Produtos()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Intervalo em milissegundos (1 segundo)
            timer.Tick += txtrelogio_Click;
            timer.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //lista produtos
            try
            {
                DataTable produtosTable = produtosDAL.GetProdutos();
                ListaProduto produtolista = new ListaProduto(produtosTable);
                produtolista.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastrarproduto = new CadastroProduto();
            cadastrarproduto.Show();
        }

        private void txtrelogio_Click(object sender, EventArgs e)
        {
            txtrelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
