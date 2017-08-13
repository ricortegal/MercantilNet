using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface IImpuesto
    {
        int Id { get; }
        decimal Valor { get; set; }
        string Descripcion { get; set; }
    }
}
