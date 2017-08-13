using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    interface ITotales
    {
        decimal TotalBruto { get; set; }
        decimal TotalDescuentos { get; set; }
        decimal TotalBaseImponible { get; set; }
        decimal TotalImporte { get; set; }
    }
}
