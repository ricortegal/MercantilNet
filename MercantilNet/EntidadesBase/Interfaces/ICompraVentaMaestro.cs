using MercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface ICompraVentaMaestro
    {
        DateTime Fecha { get; set; }
        IEnumerable<IImpuesto> CadenaImpuestos { get; set; }
        IEnumerable<IRecargo> CadenaRecargos { get; set; }
        IEnumerable<IDescuentoPorcentaje> CadenaDescuentos { get; set; }
        IEnumerable<ICompraVentaDetalle> Detalles { get; set; }
    }
}
