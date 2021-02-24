using ProjetoAlarme.Application.Interface;
using ProjetoAlarme.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.Service
{
    public class AlarmeAppService : AppServiceBase<AlarmeViewModel>, IAlarmeAppService
    {
        public AlarmeAppService(): base()
        {

        }

        public void Ativar(StatusAlarme statusAlarme)
        {

        }
        public void Desativar(StatusAlarme statusAlarme)
        {

        }

        public IEnumerable<AlarmeAtuadoViewModel> ObterAlarmesAtuados()
        {
            return null;
        }
    }
}
