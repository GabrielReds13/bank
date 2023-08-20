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
    public partial class form_criarConta : Form
    {
        // - Metodos -
        public form_criarConta()
        {
            InitializeComponent();
        }

        // Cancelar criacao de conta
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_login login = new form_login();
            login.ShowDialog();
            this.Visible = true;
        }
    }
}
