using ProjetoClientes.Domain.Interfaces.Repositories;
using ProjetoClientes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClientes.Domain.Services
{
    /// <summary>
    /// Classe genérica para implementar os métodos de regras de negócio
    /// </summary>
    public class BaseDomainService<T> : IBaseDomainService<T>
        where T : class
    {
        //atributo
        private readonly IBaseRepository<T> _baseRepository;
        //construtor para inicializar o atributo (injeção de dependência)
        public BaseDomainService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual void Create(T obj)
        {
            _baseRepository.Create(obj);
        }

        public virtual void Update(T obj)
        {
            _baseRepository.Update(obj);
        }

        public virtual void Delete(T obj)
        {
            _baseRepository.Delete(obj);
        }

        public virtual List<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public virtual T GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }
    }
}




