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
    public partial class Depositar : Form
    {
        // - Atributos -
        private Contas contaLogada { get; set; }

        public Depositar(Contas conta)
        {
            InitializeComponent(); 
            contaLogada = conta;
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            // Verificar
            bool verificar = BankAcademic.Depositar(contaLogada.Conta, double.Parse(txt_valorDeposito.Text));
            if (verificar != false)
            {
                this.Visible = false;
                Home home = new Home(contaLogada.Conta, contaLogada.Senha);
                home.ShowDialog();
                this.Close();
            }
            else { }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close(); this.Visible = false;
            Home home = new Home(contaLogada.Conta, contaLogada.Senha);
            home.ShowDialog();
            this.Close();
        }
    }
}
