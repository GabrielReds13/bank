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
            form_login login = new form_login();
            login.Close();
            this.Visible = false;
            form_recuperarSenha recuperarSenha = new form_recuperarSenha();
            recuperarSenha.ShowDialog();
        }
    }
}
