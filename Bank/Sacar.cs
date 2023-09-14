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

            Home home = new Home();
            home.Visible = true;
            Sacar sacar = new Sacar();
            sacar.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            string senha = textBox2.Text;
            BankAcademic.Sacar(valor, senha);
        }
    }
}
