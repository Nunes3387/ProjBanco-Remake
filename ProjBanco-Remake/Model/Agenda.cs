using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjBanco_Remake.Model
{
    internal class Agenda
    {
        //Cliente
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public string Rua { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }

        //Poupanca
        public string DescricaoContaPoupanca { get; set; }

        public string QtdTempoContaPoupanca { get; set; }

        public double TaxaJuros { get; set; }

        public double SaldoContaPoupanca { get; set; }

        //Corrente

        public string DescricaoContaCorrente { get; set; }

        public double LimiteContaCorrente { get; set; }

        public double SaldoContaCorrente { get; set; }

        //Segmento

        public int IdSegmento { get; set; }
        public string DescricaodoSegmento { get; set; }

        //Moeda
        public int IdMoeda { get; set; }
        public string DescricaoMoeda { get; set; }

        //Bonus
        public int IdBonus { get; set; }
        public string DescricaoBonus { get; set; }
    }
}
