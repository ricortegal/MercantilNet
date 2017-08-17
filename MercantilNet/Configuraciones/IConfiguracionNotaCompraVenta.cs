using MercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.Configuraciones
{
    public interface IConfiguracionNotaCompraVenta
    {
        bool DescuentoUnidadAnteriorCadenaDescuentos { get; set; }
        bool ImpuestosEnCadedaEnBaseImponible { get; set; }
        bool RecargosEnCadedaEnBaseImponible { get; set; }
        bool DescuentosEnCadenaPrecioBruto { get; set; }
        bool CadenaDeDescuentosAplicadoATotalConImpuestos { get; set; }
        IImpuesto ImpuestoIncluidoPrecioProducto { get; set; }
    }
}
