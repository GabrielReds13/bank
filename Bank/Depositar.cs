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
        public Depositar() 
        { 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Visible = true;
            Depositar depositar = new Depositar();
            depositar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            string senha = textBox2.Text;
            BankAcademic.Depositar(valor, senha);
        }
    }
}
