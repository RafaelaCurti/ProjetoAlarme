using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Domain.Interface.Services
{
    public interface IAlarmeService : IServiceBase<Alarme>
    {
        void Ativar(StatusAlarme statusAlarme);
        void Desativar(StatusAlarme statusAlarme);
        IEnumerable<AlarmeAtuado> ObterAlarmesAtuados();
    }
}
