using ProjetoAlarme.Application.ViewModels;
using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Application.Interface
{
   public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(TEntity obj);
        void Dispose();
        //void Add(Equipamento equipamentoDomain);
        //void Add(Alarme alarmeDomain);
        //void Update(AlarmeViewModel equipamentoDomain);
    }
}
