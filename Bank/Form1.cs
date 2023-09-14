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
    public partial class form_login : Form
    {
        // - Metodos -
        public form_login()
        {
            InitializeComponent();
        }

        // Recuperar senha
        private void btn_recuperarSenha_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_recuperarSenha recuperarSenha = new form_recuperarSenha();
            recuperarSenha.ShowDialog();
            this.Close();
        }

        // Criar conta
        private void btn_criarConta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_criarConta criarConta = new form_criarConta();
            criarConta.ShowDialog();
            this.Close();
        }

        // Login
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Verificar
            if (txt_conta.Text == "" || txt_senha.Text == "") MessageBox.Show("Preencha os campos vazios.");
            else
            {
                // Verificar conta
                if(Validar.VerificarLogin(Convert.ToString(txt_conta.Text)) == true)
                {
                    // Validar
                    Contas a = BankAcademic.Login(int.Parse(txt_conta.Text), txt_senha.Text);

                    if (a != null)
                    {
                        // Home
                        this.Visible = false; 
                        Home home = new Home(a.Conta, a.Senha);
                        home.ShowDialog();
                        this.Close();
                    }
                    else MessageBox.Show("Verifique suas informações de login.");
                }
            }
        }
    }
}
