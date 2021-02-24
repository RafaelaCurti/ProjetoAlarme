using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.ViewModels
{
    public class AlarmeViewModel
    {
        public Guid Id { get; set; }
        public String Descricao { get; set; }
        public ClassificacaoAlarme ClassificacaoAlarme { get; set; }
        public virtual EquipamentoViewModel EquipamentoViewModel { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<AlarmeAtuadoViewModel> AlarmeAtuados { get; set; }
    }

    public enum ClassificacaoAlarme
    {
        Alto = 0,
        Medio,
        Baixo
    }
    public enum StatusAlarme
    {
        Off = 0,
        On
    }
}

