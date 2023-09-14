using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Classes
{
    public static class BankAcademic
    {
        // - Atributos -
        private static string[] arquivos = {"Contas.json", "Agencias.json"};

        // - Metodos -

        /*
         * Conta - Comandos
         */
        public static bool SalvarConta(Contas conta)
        {
            try 
            {
                // Buscar json
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                var buscarArquivo = File.ReadAllText(arquivo);

                // Adicionar conta
                var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);
                contas.Add(conta);

                // Salvar conta
                var contasJson = JsonConvert.SerializeObject(contas, Formatting.Indented);
                File.WriteAllText(arquivo, contasJson);
                return true;

                /*
                // Gerar historico
                string titularHistorico = $"{conta.Conta}-{conta.Agencia.Agencia.Replace("-", "")}.json";
                string historico = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\Historicos";
                string caminhoCompleto = Path.Combine(historico, titularHistorico);
                string textoVazio = "[]";

                MessageBox.Show($"{caminhoCompleto}");

                // Criar arquivo
                string novoArquivo = JsonConvert.SerializeObject(textoVazio);
                File.Create(caminhoCompleto);
                File.WriteAllText(caminhoCompleto, textoVazio);
                */
            }
            catch (Exception) 
            { 
                MessageBox.Show("Ocorreu um erro ao criar a conta.\n Tente novamente.");
                return false;
            }
        }

        public static Contas CriarConta(
            // Dados
            string titular,
            string cpf,
            byte idade,
            DateTime dataNascimento,
            string telefone,
            string endereco,
            Agencias agencia,
            string senha
        )
        {
            // Gerar conta
            Random gerarNum = new Random();
            int numConta = gerarNum.Next(10000, 99999);

            // * Verificar
            // Buscar json
            string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
            var buscarArquivo = File.ReadAllText(arquivo);
            var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

            Contas a = contas.Find(Contas => Contas.Conta == numConta);
            
            // Verificar numero de conta existente
            while(true)
            {
                if (a != null) numConta = gerarNum.Next(10000, 99999);
                else break;
            }

            // Criar instancia
            Contas novaConta = new Contas(
                // Pessoa
                titular, 
                cpf, 
                idade, 
                dataNascimento,
                telefone, 
                endereco,

                // Conta
                numConta, 
                agencia, 
                0,
                5000,
                senha
            );
            MessageBox.Show($"Parabéns! O número da sua conta é {numConta}.");
            return novaConta;
        }

        public static List<Agencias> ListarAgencias()
        {
            // Buscar json
            string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[1]}";
            var buscarArquivo = File.ReadAllText(arquivo);
            
            // Converter lista
            var agencias = JsonConvert.DeserializeObject<List<Agencias>>(buscarArquivo);
            return agencias;
        }

        /*
         * Acoes - Sistema
         */
        public static Contas Login(int numConta, string senha)
        {
            try
            {
                // * Verificar
                // Buscar json
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                var buscarArquivo = File.ReadAllText(arquivo);
                var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

                Contas a = contas.Find(Contas => Contas.Conta == numConta);

                // Verificar login
                if (senha == a.Senha) return a;
                else
                {
                    MessageBox.Show($"Conta ou senha incorretos.");
                    return null;
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Erro ao fazer o login.");
                return null;
            }
        }

        /*
         * Historico de Transferencia - Comandos
         */
        public static List<Historico> PegarHistorico(int numConta, string numAgencia)
        {
            try
            {
                // * Verificar

                // Buscar historico
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\Historicos\{numConta}-{numAgencia.Replace("-", "")}.json";
                var buscarArquivo = File.ReadAllText(arquivo);
                var historicoCompleto = JsonConvert.DeserializeObject<List<Historico>>(buscarArquivo);
                
                List<Historico> historico = historicoCompleto;
                
                // Verificar historico
                if (historico != null) return historico;
                else return null;

            }
            catch(Exception ex) 
            {
                string msg = "Erro ao consultar histórico.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);

                return null;
            }
        }

        public static bool AlterarSenha(int numConta, string cpf, string senha)
        {
            try
            {
                // * Verificar
                if(Validar.VerificarCPF(cpf) != false)
                {
                    // Buscar json
                    string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                    var buscarArquivo = File.ReadAllText(arquivo);
                    var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

                    List<Contas> a = contas;
                    Contas encontrarConta = a.Find(Contas => Contas.Conta == numConta && Contas.Cpf == cpf);

                    // Alterar senha
                    encontrarConta.Senha = senha;

                    // Salvar altearcoes
                    var contaJson = JsonConvert.SerializeObject(a, Formatting.Indented);
                    File.WriteAllText(arquivo, contaJson);
                    
                    MessageBox.Show("Senha alterada com êxito.");
                    return true;
                }
                else
                {
                    string msg = "CPF inválido.";
                    MessageBox.Show(msg);
                    return false;
                }

            }
            catch(Exception ex)
            {
                string msg = "Erro ao alterar senha.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);
                return false;
            }

        }
        
        public static bool Sacar(int numConta, double valor)
        {
            try
            {
                // * Verificar
                // Buscar json
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                var buscarArquivo = File.ReadAllText(arquivo);
                var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

                List<Contas> a = contas;
                Contas encontrarConta = a.Find(Contas => Contas.Conta == numConta);

                // Alterar saldo
                if (valor <= encontrarConta.Saldo && valor > 0)
                {
                    encontrarConta.Saldo -= valor;

                    // Salvar altearcoes
                    var contaJson = JsonConvert.SerializeObject(a, Formatting.Indented);
                    File.WriteAllText(arquivo, contaJson);

                    MessageBox.Show("Saque feito com êxito.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    return true;
                }
            }
            catch(Exception ex)
            {
                string msg = "Erro ao sacar.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);
                return false;
            }

        }

        public static bool Depositar(int numConta, double valor)
        {
            try
            {
                // * Verificar
                // Buscar json
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                var buscarArquivo = File.ReadAllText(arquivo);
                var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

                List<Contas> a = contas;
                Contas encontrarConta = a.Find(Contas => Contas.Conta == numConta);

                // Alterar saldo
                if(valor > 0)
                {
                    // Salvar altearcoes
                    encontrarConta.Saldo += valor;
                    var contaJson = JsonConvert.SerializeObject(a, Formatting.Indented);
                    File.WriteAllText(arquivo, contaJson);

                    MessageBox.Show("Depósito feito com êxito.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    return false;
                }

            }
            catch (Exception ex)
            {
                string msg = "Erro ao depositar.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);
                return false;
            }

        }

        public static bool Transferir(int numContaRemetente, int numContaDestinatario, double valor)
        {
            try
            {
                // * Verificar
                // Buscar json
                string arquivo = $@"{AppDomain.CurrentDomain.BaseDirectory}\..\..\Data\{arquivos[0]}";
                var buscarArquivo = File.ReadAllText(arquivo);
                var contas = JsonConvert.DeserializeObject<List<Contas>>(buscarArquivo);

                List<Contas> a = contas;
                Contas contaRemetente = a.Find(Contas => Contas.Conta == numContaRemetente);
                Contas contaDestinatario = a.Find(Contas => Contas.Conta == numContaDestinatario);

                // Alterar saldo
                if(contaRemetente.Limite != 0)
                {
                    if(valor <= contaRemetente.Limite && valor <= contaRemetente.Saldo && valor > 0)
                    {
                        contaRemetente.Saldo -= valor;
                        contaRemetente.Limite -= valor;
                        contaDestinatario.Saldo += valor;

                        // Salvar altearcoes
                        var contaJson = JsonConvert.SerializeObject(a, Formatting.Indented);
                        File.WriteAllText(arquivo, contaJson);

                        MessageBox.Show("Transferência feita com êxito.");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("O valor é inválido.");
                        return false;
                    }
                }
                else 
                {
                    MessageBox.Show("Limite atingido.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                string msg = "Erro ao transferir.";

                // Excessoes
                if (ex is NullReferenceException || ex is ArgumentNullException) MessageBox.Show(msg);
                else MessageBox.Show(msg);
                return false;
            }

        }
    }
}
