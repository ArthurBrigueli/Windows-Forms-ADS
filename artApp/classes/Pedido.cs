using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artApp.classes
{
    public class Pedido
    {
        public int id { get; set; }
        public string datha { get; set; }
        public int id_cliente { get; set; }
        public string nome_produto { get; set; }
        public float valor { get; set; }
        public int status { get; set; }


        public Pedido(int id, string dat, int id_cliente, string nome_produto, float valor, int status)
        {
            this.id = id;
            this.datha = dat;
            this.id_cliente = id_cliente;
            this.nome_produto = nome_produto;
            this.valor = valor;
            this.status = status;
        }
    }
}
