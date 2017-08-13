using ercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface ICompraVentaDetalle
    {
        int Id { get; set; }
        IEnumerable<IImpuesto> CadenaImpuestos { get; set; }
        IEnumerable<IRecargo> CadenaRecargos { get; set; }
        IDescuentoUnidad DescuentoUnidad { get; set; }
        IEnumerable<IDescuentoPorcentaje> CadenaDescuentos { get; set; }
        int Unidades { get; set; }
        string DenoUnidad { get; set; }
        string DenoProducto { get; set; }
        string DescripcionLinea { get; set; }
        decimal Bruto { get; set; }
        decimal Descuentos { get; set; }
        decimal Total { get; set; }
        decimal Impuestos { get; set; }
    }
}
