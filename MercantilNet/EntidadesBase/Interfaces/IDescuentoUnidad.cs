using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface IDescuentoUnidad
    {
        int Id { get; }

        /// <summary>
        /// Valor en unidades monetarias por unidad
        /// </summary>
        decimal Valor { get; set; }

        string Descripcion { get; set; }
    }
}
