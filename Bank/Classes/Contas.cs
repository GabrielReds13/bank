using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Classes
{
    public class Contas : Pessoa
    {
        // - Atributos -
        public int Conta { get; set; }
        public Agencias Agencia { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }
        public string Senha { get; set; }

        // - Metodo Construtor -
        public Contas(
            // Pessoa
            string titular,
            string cpf,
            byte idade,
            string telefone,
            string endereco,

            // Conta
            int conta, 
            Agencias agencia,
            double saldo,
            double limite,
            string senha
        ) 
        // Construtor base
        : base (
            titular, 
            cpf,
            idade, 
            telefone, 
            endereco
        )
        {
            // Pessoa
            this.Titular = titular;
            this.Cpf = cpf;
            this.Idade = idade;
            this.Telefone = telefone;
            this.Endereco = endereco;

            // Conta
            this.Conta = conta;
            this.Agencia = agencia;
            this.Saldo = saldo;
            this.Limite = limite;
            this.Senha = senha;
        }

        // - Metodos -
    }
}
