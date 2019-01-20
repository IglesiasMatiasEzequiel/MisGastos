using System.Collections.Generic;
using MisGastosRepository.Repository;

namespace MisGastosRepository.Business
{
    public class IngresosBusiness : BaseBusiness<Ingreso>
    {
        private readonly IngresosRepository _ingresosRepository;

        public IngresosBusiness() : base(new IngresosRepository())
        {
            _ingresosRepository = _repository as IngresosRepository;
        }

        public List<Ingreso> ObtenerIngresosPorUsuario(int idUsuario)
        {
            return _ingresosRepository.ObtenerIngresosPorUsuario(idUsuario);
        }
    }
}
