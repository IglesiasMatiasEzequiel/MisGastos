using System.Collections.Generic;
using MisGastosRepository.Repository;

namespace MisGastosRepository.Business
{
    public class BaseBusiness<T> where T : class
    {
        protected BaseRepository<T> _repository;

        public BaseBusiness(BaseRepository<T> repository)
        {
            _repository = repository;
        }

        public List<T> Listar()
        {
            return _repository.Listar();
        }

        public void Guardar(T entity)
        {
            _repository.Guardar(entity);
        }
    }
}
