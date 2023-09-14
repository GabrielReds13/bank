using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Classes
{
    public class Historico
    {
        // - Atributos -
        public int Id { get; set; }
        public DateTime Data { get; set; }

        // Transacao
        public string TitularRemetente { get; set; }
        public int ContaRemetente { get; set; }
        public Agencias AgenciaRemetente { get; set; }

        // Destinatario
        public string TitularDestinatario { get; set; }
        public int ContaDestinatario { get; set; }
        public Agencias AgenciaDestinatario { get; set; }

        // Dados Transacao
        public double Valor { get; set; }
        public bool Pago { get; set; }

        // - Metodos -

    }
}
