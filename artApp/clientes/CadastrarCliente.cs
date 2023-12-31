﻿using artApp.pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace artApp
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cadastrar
            
            Pessoa cliente = new Pessoa(PessoaDAL.GetClientes().Rows.Count + 1, textnome.Text, textendereco.Text, textemail.Text, textnumero.Text);

            PessoaDAL.AddCliente(cliente.id, cliente.nome, cliente.endereco, cliente.email, cliente.numero);
            MessageBox.Show($"{cliente.id} adicionado com sucesso");
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textnumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
