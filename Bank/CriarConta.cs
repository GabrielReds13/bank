using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Classes;

namespace Bank
{
    public partial class form_criarConta : Form
    {
        // - Atributos -
        List<Agencias> listaAgencias = BankAcademic.ListarAgencias();

        // - Metodos -
        public form_criarConta()
        {
            InitializeComponent();
            foreach (Agencias a in listaAgencias) select_cidade_agencia.Items.Add(a.Cidade);
        }

        // Cancelar criacao de conta
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_login login = new form_login();
            login.ShowDialog();
            this.Visible = true;
        }

        // Escolher cidade e agencia
        private void select_cidade_agencia_Leave(object sender, EventArgs e)
        {
            Agencias a = listaAgencias.Find(Agencias => Agencias.Cidade == select_cidade_agencia.Text);
            txt_agencia.Text = $"{a.Agencia}";
        }

        // - Ignore features -
        private void select_cidade_agencia_DropDownClosed(object sender, EventArgs e) { }
        private void select_cidade_agencia_TextUpdate(object sender, EventArgs e) { }

    }
}
