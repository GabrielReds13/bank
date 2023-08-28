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
        public Agencias Agencias { get; set; }
        public double Saldo { get; set; }
        public double LimiteMensal { get; set; }
        public string Senha { get; set; }

        // - Metodo Construtor -


        // - Metodos -
    }
}
