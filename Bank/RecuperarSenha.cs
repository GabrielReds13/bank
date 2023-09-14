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
    public partial class form_recuperarSenha : Form
    {
        // - Metodos -
        public form_recuperarSenha()
        {
            InitializeComponent();
        }

        // Cancelar recuperacao
        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            form_login login = new form_login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            bool validar = BankAcademic.AlterarSenha(int.Parse(txt_conta.Text), txt_cpf.Text, txt_novaSenha.Text);
            if (validar != false)
            {
                this.Visible = false;
                form_login login = new form_login();
                login.ShowDialog();
                this.Close();
            }
            else { }
        }
    }
}
