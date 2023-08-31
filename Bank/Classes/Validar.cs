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
                if (cpfChar.Length != 11)
                {
                    MessageBox.Show($"CPF inválido.");
                    return false;
                }
                else
                {
                    // Calcular numeros
                    for (int i = 0, j = 10; i < (cpfChar.Length - 2); i++, j--) num1 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                    num1 = num1 % 11;

                    // Verificar num1
                    if (num1 >= 2) num1 = 11 - num1;
                    else if (num1 == 0) { }
                    else
                    {
                        MessageBox.Show($"CPF inválido.");
                        return false;
                    }

                    // Validar num1
                    if (num1 == Convert.ToInt32(cpfChar[9].ToString()))
                    {
                        // Calcular numeros
                        for (int i = 0, j = 11; i < (cpfChar.Length - 1); i++, j--) num2 += (Convert.ToInt32(cpfChar[i].ToString()) * j);
                        num2 = num2 % 11;

                        // Verificar num1
                        if (num2 >= 2) num2 = 11 - num2;
                        else if (num2 == 0) { }
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }

                        // Validar num2
                        if (num2 == Convert.ToInt32(cpfChar[10].ToString())) return true;
                        else
                        {
                            MessageBox.Show($"CPF inválido.");
                            return false;
                        }
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar CPF.");
                return false;
            }
        }

        public static bool VerificarTelefone(string telefone)
        {
            try
            {
                // Formatar telefone
                telefone = telefone.Replace("(", "").Replace(")", "").Replace("_", "").Replace("-", "").Replace(" ", "");
                char[] telChar = telefone.ToCharArray();

                // Verificar
                if (telChar.Length == 11) return true;
                else
                {
                    MessageBox.Show($"Telefone inválido.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar telefone.");
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
                else
                {
                    MessageBox.Show($"Cidade ou agência inválidos.");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar cidade e agência.");
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
                }

                // Validar
                if(digitosValidos == idadeChar.Length) return true;
                else
                {
                    MessageBox.Show($"Idade inválida.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar idade.");
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
                DateTime data = DateTime.Now.Date;

                // Validar
                
                // Verificar data
                if (splitDataNasc[0].ToCharArray().Length == 2 && splitDataNasc[1].ToCharArray().Length == 2 && splitDataNasc[2].ToCharArray().Length == 4)
                {
                    // Verificar data
                    if (
                        int.Parse(splitDataNasc[0]) > 0 && int.Parse(splitDataNasc[0]) <= 31 &&
                        int.Parse(splitDataNasc[1]) > 0 && int.Parse(splitDataNasc[1]) <= 12 &&
                        int.Parse(splitDataNasc[2]) > 1950 && int.Parse(splitDataNasc[2]) <= int.Parse($"{data.Year + 1}")
                    ) return true;
                    else
                    {
                        MessageBox.Show($"Data inválida.");
                        return false;
                    }
                }
                else 
                { 
                    MessageBox.Show($"Data inválida.");
                    return false; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar data de nascimento.\nConfira se suas informações estão corretas.");
                return false;
            }
        }

        public static bool VerificarNome(string nome)
        {
            try
            {
                // Formatar
                nome = nome.Replace(" ", "");
                char[] nomeChar = nome.ToCharArray();
                int digitosValidos = 0;

                // Verificar
                foreach (char caractere in nomeChar)
                {
                    if (caractere >= 65 && caractere <= 90 || caractere >= 97 && caractere <= 122) digitosValidos++;
                }

                // Validar
                if (digitosValidos == nome.Length) return true;
                else
                {
                    MessageBox.Show($"Nome pode possuir apenas letras.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar nome.");
                return false;
            }
        }

        public static bool VerificarLogin(string numConta)
        {
            try
            {
                // Formatar
                char[] contaChar = numConta.ToCharArray();
                int digitosValidos = 0;

                // Verificar 1
                if(contaChar.Length == 5) 
                { 
                    // Verificar 2
                    foreach (char caractere in contaChar)
                    {
                        if (caractere >= 48 && caractere <= 57) digitosValidos++;
                    }

                    // Validar
                    if (digitosValidos == contaChar.Length) return true;
                    else
                    {
                        MessageBox.Show($"Conta pode possuir apenas números.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show($"Conta inválida.");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro. Tente novamente mais tarde.");
                return false;
            }
        }
    }
}
