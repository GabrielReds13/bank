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
        private static string[] arquivos = {"Contas.json", "Agencias.json", "Historico.json"};

        // - Metodos -
        public static void SalvarConta(Contas conta)
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
                var contasJson = JsonConvert.SerializeObject(contas);
                File.WriteAllText(arquivo, contasJson);
            } catch (Exception ex) 
            { 
                MessageBox.Show("Ocorreu um erro ao criar a conta.\n Tente novamente.");
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
            
            // Criar lista
            var agencias = JsonConvert.DeserializeObject<List<Agencias>>(buscarArquivo);
            string[] lista = new string[agencias.Count];
            for (int i = 0; i < agencias.Count; i++) lista[i] = $"{agencias[i].Cidade}, Agência {agencias[i].Agencia}";

            return agencias;
        }
    }
}
