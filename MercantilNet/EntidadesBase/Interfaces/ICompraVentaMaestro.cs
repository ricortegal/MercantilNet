using MercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface ICompraVentaMaestro
    {
        DateTime Fecha { get; set; }
        IEnumerable<IImpuesto> Impuestos { get; set; }
        IEnumerable<IRecargo> Recargos { get; set; }
        IEnumerable<IDescuentoPorcentaje> Descuentos { get; set; }
        IEnumerable<ICompraVentaDetalle> Detalles { get; set; }
    }
}
