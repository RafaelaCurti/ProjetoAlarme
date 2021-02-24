using ProjetoAlarme.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.Interface
{
    public interface IAlarmeAppService: IAppServiceBase<AlarmeViewModel>
    {
        void Ativar(StatusAlarme statusAlarme);
        void Desativar(StatusAlarme statusAlarme);
        IEnumerable<AlarmeAtuadoViewModel> ObterAlarmesAtuados();
    }
}
