using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    public class Pessoa
    {
        // - Atributos -
        public string Titular { get; set; }
        public string Cpf { get; set; }
        public byte Idade { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        // - Metodo Construtor -
        public Pessoa(
            string titular,
            string cpf,
            byte idade,
            DateTime dataNascimento,
            string telefone,
            string endereco
        ) 
        {
            this.Titular = titular;
            this.Cpf = cpf;
            this.Idade = idade;
            this.dataNascimento = dataNascimento;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }

        public Pessoa()
        {
        }
    }
}
