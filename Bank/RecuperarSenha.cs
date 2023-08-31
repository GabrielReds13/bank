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
            /* Para testes
            form_recuperarSenha recuperarSenha = new form_recuperarSenha();
            recuperarSenha.Close();
            form_login login = new form_login();
            this.Visible = false;
            login.ShowDialog();
            */

            this.Visible = false;
            form_login login = new form_login();
            login.ShowDialog();
            this.Close();
        }
    }
}
