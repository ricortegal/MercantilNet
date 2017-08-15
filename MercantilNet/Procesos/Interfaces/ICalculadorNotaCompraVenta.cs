using MercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.Procesos.Interfaces
{
    public interface ICalculadorNotaCompraVenta<TMaestro,TDetalle> 
        where TMaestro : ICompraVentaMaestro 
        where TDetalle : ICompraVentaDetalle 
    {
        void RecalculaDetalle(TDetalle detalle);
        void RecalculaBases(TMaestro maestro);
        void RecalculaNotaCompra(TMaestro maestro, bool recalculaDetalles = false);
    }
}
