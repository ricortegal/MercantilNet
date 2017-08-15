using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface ICompraVentaDetalle
    {
        int Id { get; set; }
        IEnumerable<IImpuesto> Impuestos { get; set; }
        IEnumerable<IRecargo> Recargos { get; set; }
        IDescuentoUnidad DescuentoUnidad { get; set; }
        IEnumerable<IDescuentoPorcentaje> Descuentos { get; set; }
        IProductoServicio Producto { get; set; }
        int Unidades { get; set; }
        decimal PrecioBrutoUnidad { get; set; }
        string DenoUnidad { get; set; }
        string DenoProducto { get; set; }
        string DescripcionLinea { get; set; }
        decimal TotalBruto { get; set; }
        decimal TotalImpuestos { get; set; }
        decimal TotalDescuentos { get; set; }
        decimal TotalBaseImponible { get; set; }
        decimal TotalImporte { get; set; }
    }
}
