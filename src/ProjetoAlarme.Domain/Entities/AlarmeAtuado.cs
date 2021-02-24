using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Domain.Entities
{
    public class AlarmeAtuado
    {
        public Guid Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public StatusAlarme StatusAlarme { get; set; }
    }
}
