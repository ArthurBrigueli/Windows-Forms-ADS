    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artApp
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set;}

        public string numero { get; set; }

        public Pessoa(int id, string nome, string endereco, string email, string numero)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.numero = numero;
        }

        
    }
}
