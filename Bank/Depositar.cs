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
        private Contas contaLogada { get; set; }
        public Depositar(Contas contas)
        {
            contaLogada = contas;
            InitializeComponent();
        }
        public Depositar() 
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home home = new Home();

            home.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            string senha = textBox2.Text;
            BankAcademic.Depositar(valor, senha);
        }
    }
}
