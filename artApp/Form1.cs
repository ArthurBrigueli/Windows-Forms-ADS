using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artApp
{
    public partial class Form1 : Form
    {
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Intervalo em milissegundos (1 segundo)
            timer.Tick += txtrelogio_Click;
            timer.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastrar
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void txtrelogio_Click(object sender, EventArgs e)
        {

            
            txtrelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
