using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemGw.Models
{
    public class QuadroServico
    {
        public int Id { get; set; }
        public Pessoa NomeCliente { get; set; }
        public DateTime DataAbertura { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string StatusDoAtendimento { get; set; }
        public string StatusDaMaquina { get; set; }
        public TipoOs TipoOs { get; set; }
        public string SatisfacaoComServico { get; set; }
        public Funcionario NomeMecanico { get; set; }
        public string TempoOsAberta { get; set; }
        public DateTime DataDaRota { get; set; }
        public StatusDoServico StatusDoServico { get; set; }
        public string NumeroOs { get; set; }
        public SetorMecanico SetorMecanico { get; set; }
        public Veiculo Chassi { get; set; }






    }
}
