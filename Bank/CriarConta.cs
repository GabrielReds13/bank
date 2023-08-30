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
using static System.Net.Mime.MediaTypeNames;

namespace Bank
{
    public partial class form_criarConta : Form
    {
        // - Atributos -
        List<Agencias> listaAgencias = BankAcademic.ListarAgencias();
        string[] textoDeInput = {"Nome completo", "CPF", "Idade"};

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

        // Criar conta
        private void btn_criar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar
                if (
                    // Condicoes
                    txt_nomeCompleto.Text == "" || Validar.VerificarNome(txt_nomeCompleto.Text) ||
                    txt_cpf.Text == "" || Validar.VerificarCPF(txt_cpf.Text) == false ||
                    txt_idade.Text == "" || Validar.VerificarIdade(txt_idade.Text) == false ||
                    txt_dataNasc.Text == "" || Validar.VerificarDataNasc(txt_dataNasc.Text) == false ||
                    txt_telefone.Text == "" || Validar.VerificarTelefone(txt_telefone.Text) == false ||
                    txt_endereco.Text == "" ||
                    select_cidade_agencia.Text == "" ||
                    txt_agencia.Text == "" || Validar.VerificarAgencia(select_cidade_agencia.Text, txt_agencia.Text) == false ||
                    txt_senha.Text == ""
                ) MessageBox.Show("Verifique se as informações estão corretas.");
                else 
                {
                    // Criar conta
                    Agencias a = listaAgencias.Find(Agencias => Agencias.Agencia == txt_agencia.Text);
                    Contas novaConta = BankAcademic.CriarConta(
                        txt_nomeCompleto.Text,
                        txt_cpf.Text,
                        byte.Parse(txt_idade.Text), 
                        Convert.ToDateTime(txt_dataNasc.Text).Date,
                        txt_telefone.Text, 
                        txt_endereco.Text,
                        a,
                        txt_senha.Text
                    );

                    BankAcademic.SalvarConta(novaConta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar sua conta.\nTente novamente mais tarde.");
            }
        }

        // - Ignore features -
        private void select_cidade_agencia_DropDownClosed(object sender, EventArgs e) { }
        private void select_cidade_agencia_TextUpdate(object sender, EventArgs e) { }
        private void txt_dataNasc_TextChanged(object sender, EventArgs e) { }
    }
}
