using ProjetoAlarme.Domain.Interface.Repositorys;
using ProjetoAlarme.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlarme.Domain.Service
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositorysBase<TEntity> _repositorysBase;

        public ServiceBase(IRepositorysBase<TEntity> repositorysBase)
        {
            _repositorysBase = repositorysBase;
        }

        public void Add(TEntity obj)
        {
            _repositorysBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _repositorysBase.Delete(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositorysBase.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _repositorysBase.GetById(id);
        }

        public void Update(TEntity obj)
        {
            _repositorysBase.Update(obj);
        }
    }
}
