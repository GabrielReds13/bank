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
        public static void CriarConta(Contas conta)
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
