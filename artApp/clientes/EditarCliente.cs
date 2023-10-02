using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace artApp.clientes
{
    public partial class EditarCliente : Form
    {

        int id;
        string nome;
        string endereco;
        string email;
        string numero;

        public EditarCliente(int id, string nome, string endereco, string email, string numero)
        {
            InitializeComponent();
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.numero = numero;

        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //atualizar

            PessoaDAL.EditarCliente(id, textnome.Text, textendereco.Text, textemail.Text, textnumero.Text);
            MessageBox.Show("Atualizado");
            this.Close();
            
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            textnome.Text = nome;
            textendereco.Text = endereco;
            textemail.Text = email;
            textnumero.Text = numero;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
