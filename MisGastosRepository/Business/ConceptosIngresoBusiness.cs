using MisGastosRepository.Repository;

namespace MisGastosRepository.Business
{
    public class ConceptosIngresoBusiness : BaseBusiness<ConceptosIngreso>
    {
        private readonly ConceptosIngresoRepository _conceptosIngresoRepository;

        public ConceptosIngresoBusiness() : base(new ConceptosIngresoRepository())
        {
            _conceptosIngresoRepository = _repository as ConceptosIngresoRepository;
        }
    }
}
