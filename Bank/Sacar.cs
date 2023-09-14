using Bank.Classes;
using Newtonsoft.Json;
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
    public partial class Sacar : Form
    {
        //conta logada
        private Contas contaLogada { get; set; }
        //metodo construtor
        public Sacar(Contas contas)
        {
            contaLogada = contas;
            InitializeComponent();
        }
        public Sacar()
        {
            InitializeComponent();
        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sacar_Load(object sender, EventArgs e)
        {

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
            BankAcademic.Sacar(valor, senha);
        }
    }
}
