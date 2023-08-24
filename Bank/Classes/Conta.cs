using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Classes
{
    internal class Conta
    {
        // - Atributos -
        public int Id { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public double LimiteMensal { get; set; }
        public string Senha { get; set; }

        // - Metodo Construtor -


        // - Metodos -
        public void Sacar(double valor)
        {
            try
            {
                // Saque
                if (valor > Saldo || valor < 1) MessageBox.Show("Valor inválido.");
                else Saldo -= valor;
            }
            catch(Exception ex) 
            {
                // Erro
                MessageBox.Show("Erro ao sacar.");
            }
        }

        public void Depositar(double valor)
        {
            try
            {
                // Deposito
                if (valor < 0) MessageBox.Show("Valor inválido.");
                else Saldo += valor;
            }
            catch (Exception ex)
            {
                // Erro
                MessageBox.Show("Erro ao depositar.");
            }
        }

        public void Pix(string chaveRemetente)
        {

        }
    }
}
