using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface IProductoServicio
    {
        decimal Precio { get; set; }
        string Deno { get; set; }
        int UnidadDeMedida { get; set; }
        bool IsServicio { get; set; }
    }
}
