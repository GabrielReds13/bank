using Bank.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Home : Form
    {
        // - Atributos -
        private Contas contaLogada { get; set; }

        // - Metodo Construtor -
        public Home(Contas conta)
        {
            InitializeComponent();
            // Pegar usuario 
            contaLogada = conta;

            // Setar forms
            lb_titular.Text = $"{contaLogada.Titular.Split(char.Parse(" "))[0]} {contaLogada.Titular.Split(char.Parse(" "))[1]}";
            lb_saldo.Text = contaLogada.Saldo.ToString("C2");
            lb_limite.Text = contaLogada.Limite.ToString("C2");
        }

        // - Metodos -
    }
}
