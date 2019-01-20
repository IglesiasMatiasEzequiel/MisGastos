using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace MisGastosRepository.Repository
{
    public abstract class BaseRepository<T> where T : class
    {
        protected MisGastosEntities _context;

        protected BaseRepository()
        {
            _context = new MisGastosEntities();
        }

        protected abstract DbSet<T> GetDbSet();

        public List<T> Listar()
        {
            return GetDbSet().ToList();
        }

        public void Guardar(T model)
        {
            GetDbSet().Add(model);
            _context.SaveChanges();
        }
    }
}
