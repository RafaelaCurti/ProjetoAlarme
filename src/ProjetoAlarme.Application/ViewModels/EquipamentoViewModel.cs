using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.ViewModels
{
    public class EquipamentoViewModel
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public String NumeroSerie { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        public DateTime DataCadastro { get; set; }
    }

    public enum TipoEquipamento
    {
        Tensao = 0,
        Corrente,
        Oleo
    }
}
