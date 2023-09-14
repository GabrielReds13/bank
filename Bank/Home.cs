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
    public partial class Home : Form
    {
        // - Atributos -
        private Contas contaLogada { get; set; }

        // - Metodo Construtor -
        public Home(int numConta, string senha)
        {
            InitializeComponent();
            // Pegar usuario 
            contaLogada = BankAcademic.Login(numConta, senha);

            // Variaveis
            string[] nome = contaLogada.Titular.Split(char.Parse(" "));

            // Setar forms
            lb_titular.Text = $"Olá, {nome[0]}";
            lb_saldo.Refresh();
            lb_saldo.Text = contaLogada.Saldo.ToString("C2");
            lb_limite.Refresh();
            lb_limite.Text = contaLogada.Limite.ToString("C2");

            // Historico
            /* try
            {
                List<Historico> transacoes = BankAcademic.PegarHistorico(contaLogada.Conta, contaLogada.Agencia.Agencia);

                // Validar historico
                if(transacoes != null)
                {
                    // Formatar lista
                    for(int i = 0; i < transacoes.Count; i++)
                    {   
                        // - Transferencias
                        for(int j = 0; j < transacoes.Count; j++)
                        {
                            // Variavies
                            string[] remetente = transacoes[i].TitularRemetente.Split();
                            string valorTransf;

                            // Codigo
                            if (transacoes[i].Pago != false) valorTransf = $"+ {transacoes[i].Valor.ToString("C2")}";
                            else valorTransf = $"- {transacoes[i].Valor.ToString("C2")}";

                            // Saida
                            lst_historico.Items.Add($"{remetente[0]} {remetente[remetente.Length - 1]} - ( {valorTransf} )");
                        }

                        // Divider
                        lst_historico.Items.Add("");
                    }

                }
                else { }
            }
            catch(Exception ex)
            {
                string msg = "Erro ao consultar histórico.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);
            } */
        }

        // - Metodos  -
        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form_login login = new form_login();
            login.ShowDialog();
            this.Close();
        }

        private void btn_transferir_Click(object sender, EventArgs e)
        {
            this.Close(); this.Visible = false;
            Transferir transferir = new Transferir(contaLogada);
            transferir.ShowDialog();
            this.Close();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            this.Close(); this.Visible = false;
            Depositar depositar = new Depositar(contaLogada);
            depositar.ShowDialog();
            this.Close();
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            this.Close(); this.Visible = false;
            Sacar sacar = new Sacar(contaLogada);
            sacar.ShowDialog();
            this.Close();
        }

        // - Metodos Irrelevantes -
        private void btn_recarregar_Click(object sender, EventArgs e)
        {
        }

    }
}
