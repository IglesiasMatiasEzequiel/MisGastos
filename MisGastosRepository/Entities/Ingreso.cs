using System;
using System.ComponentModel.DataAnnotations;

namespace MisGastosRepository
{
    [MetadataType(typeof(IngresoMetadata))]
    public partial class Ingreso
    {
    }

    public class IngresoMetadata
    {
        [Display(Name = "Ingreso")]
        public int IdIngreso { get; set; }

        [Display(Name = "Usuario")]
        public int IdUsuario { get; set; }

        [Display(Name = "Concepto")]
        public int IdConceptoIngreso { get; set; }

        [Display(Name = "Moneda")]
        public int IdMoneda { get; set; }

        [Display(Name = "Importe")]
        public decimal Importe { get; set; }

        [Display(Name = "Fecha")]
        public DateTime FechaIngreso { get; set; }
    }

}
