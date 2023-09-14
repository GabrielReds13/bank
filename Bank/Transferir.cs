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
    
    public partial class Transferir : Form
    {
        // - Atributos -
        private Contas contaLogada { get; set; }
        
        // - Metodos -
        public Transferir(Contas conta)
        {
            InitializeComponent();

            contaLogada = conta;
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            // Verificar
            bool verificar = BankAcademic.Transferir(contaLogada.Conta, int.Parse(txt_contaDestinatario.Text), double.Parse(txt_valorTranferencia.Text));
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
            this.Close();this.Visible = false;
            Home home = new Home(contaLogada.Conta, contaLogada.Senha);
            home.ShowDialog();
            this.Close();
        }

        // Itens irrelevanetes
        private void txt_valorTranferencia_TextChanged(object sender, EventArgs e) { }

    }
}
