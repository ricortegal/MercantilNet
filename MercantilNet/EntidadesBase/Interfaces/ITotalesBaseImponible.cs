using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    interface ITotalesBaseImponible
    {
        IImpuesto Impuesto { get; set; }
        IRecargo Recargo { get; set; }
        decimal TotalBruto { get; set; }
        decimal TotalDescuentos { get; set; }
        decimal TotalBaseImponible { get; set; }
        decimal TotalImporte { get; set; }

    }
}
