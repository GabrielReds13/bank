using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Classes
{
    public static class Validar
    {
        // - Metodos -
        public static bool VerificarCPF(string cpf)
        {
            try
            {
                // Variaveis
                int num1 = 0, num2 = 0;

                // Formatar cpf
                cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");
                char[] cpfChar = cpf.ToCharArray();

                // Validar tamanho
                if (cpfChar.Length != 11) return false;
                else
                {
                    // Calcular numeros
                    for (int i = 0, j = 10; i < (cpfChar.Length - 2); i++, j--) num1 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                    num1 = num1 % 11;

                    // Verificar num1
                    if (num1 >= 2) num1 = 11 - num1;
                    else if (num1 == 0) { }
                    else return false;

                    // Validar num1
                    if (num1 == Convert.ToInt32(cpfChar[9].ToString()))
                    {
                        // Calcular numeros
                        for (int i = 0, j = 11; i < (cpfChar.Length - 1); i++, j--) num2 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                        num2 = num2 % 11;

                        // Verificar num1
                        if (num2 >= 2) num2 = 11 - num2;
                        else if (num2 == 0) { }
                        else return false;

                        // Validar num2
                        if (num2 == Convert.ToInt32(cpfChar[10].ToString())) return true;
                        else return false;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credências.");
                return false;
            }
        }

        public static bool VerificarTelefone(string telefone)
        {
            try
            {
                // Formatar telefone
                telefone = telefone.Replace("(", "").Replace(")", "").Replace("-", "");
                char[] telChar = telefone.ToCharArray();

                // Verificar
                if (telChar.Length == 11 || telChar.Length == 9) 
                {
                    int digitosValidos = 0;

                    // Verificar caracteres
                    foreach (char caractere in telChar) 
                    {
                        if (caractere >= 48 && caractere <= 57) digitosValidos++;
                        else { }
                    }

                    // Validar
                    if (digitosValidos == telChar.Length) return true;
                    else return false;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credências.");
                return false;
            }
        }

        public static bool VerificarAgencia(string cidade, string agencia)
        {
            try 
            {
                // Buscar agencias
                List<Agencias> listaAgencias = BankAcademic.ListarAgencias();
                Agencias a = listaAgencias.Find(Agencias => Agencias.Agencia == agencia);

                // Validar
                if (a.Cidade == cidade) return true;
                else return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credências.");
                return false;
            }
        }
        
        public static bool VerificarIdade(string idade)
        {
            try 
            {
                // Formatar
                char[] idadeChar = idade.ToCharArray();
                byte idadeByte = byte.Parse(idade);
                int digitosValidos = 0;

                // Verificar
                foreach (char caractere in idadeChar)
                {
                    if (caractere >= 48 && caractere <= 57) digitosValidos++;
                    else { }
                }

                // Validar
                if(digitosValidos == idadeChar.Length) return true;
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credências.");
                return false;
            }
        }

        public static bool VerificarDataNasc(string dataNascimento)
        {
            try
            {
                // Formatar
                string formDataNasc = dataNascimento.Replace("_", "").Replace("/", "");
                string[] splitDataNasc = $"{dataNascimento.Replace("_", "")}".Split(char.Parse("/"));
                char[] dataNascChar = formDataNasc.ToCharArray();
                DateTime data = DateTime.Now.Date;
                int digitosValidos = 0;

                // Verificar
                foreach (char caractere in dataNascChar)
                {
                    if (caractere >= 48 && caractere <= 57) digitosValidos++;
                    else { }
                }

                // Validar
                if (digitosValidos == dataNascChar.Length && splitDataNasc.Length == 3)
                {
                    // Verificar formato de data
                    if (splitDataNasc[0].ToCharArray().Length == 2 && splitDataNasc[1].ToCharArray().Length == 2 && splitDataNasc[2].ToCharArray().Length == 4)
                    {
                        // Verificar data 1
                        if (
                            int.Parse(splitDataNasc[0]) > 0 && int.Parse(splitDataNasc[0]) <= 31 &&
                            int.Parse(splitDataNasc[1]) > 0 && int.Parse(splitDataNasc[1]) <= 12 &&
                            int.Parse(splitDataNasc[2]) > 1950 && int.Parse(splitDataNasc[2]) <= int.Parse($"{data.Year + 1}")
                        ) return true;
                        else return false;
                    }    
                    else if (splitDataNasc[0].ToCharArray().Length == 4 && splitDataNasc[1].ToCharArray().Length == 2 && splitDataNasc[2].ToCharArray().Length == 2)
                    {
                        // Verificar data 2
                        if (
                            int.Parse(splitDataNasc[2]) > 0 && int.Parse(splitDataNasc[0]) <= 31 &&
                            int.Parse(splitDataNasc[1]) > 0 && int.Parse(splitDataNasc[1]) <= 12 &&
                            int.Parse(splitDataNasc[0]) > 1950 && int.Parse(splitDataNasc[2]) <= int.Parse($"{data.Year + 1}")
                        ) return true;
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credências.");
                return false;
            }
        }
    }
}
