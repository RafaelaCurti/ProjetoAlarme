using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.ViewModels
{
    public class AlarmeAtuadoViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public StatusAlarme StatusAlarme { get; set; }
    }
}
