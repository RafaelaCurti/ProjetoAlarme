using ProjetoAlarme.Domain.Entities;
using ProjetoAlarme.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Domain.Service
{
    public class AlarmeService : ServiceBase<Alarme>, IAlarmeService
    {
        //public AlarmeService() /*: base()*/
        //{

        //}

        public void Ativar(StatusAlarme statusAlarme)
        {

        }
        public void Desativar(StatusAlarme statusAlarme)
        {

        }

        public IEnumerable<AlarmeAtuado> ObterAlarmesAtuados()
        {
            return null;
        }
    }
}

