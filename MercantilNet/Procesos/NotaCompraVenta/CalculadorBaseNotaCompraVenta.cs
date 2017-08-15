using MercantilNet.Configuraciones;
using MercantilNet.EntidadesBase.Interfaces;
using MercantilNet.Procesos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.Procesos.NotaCompraVenta
{
    public class CalculadorBaseNotaCompraVenta 
        : ICalculadorNotaCompraVenta<ICompraVentaMaestro,ICompraVentaDetalle>
    {
        private ICompraVentaMaestro _nota;
        private IConfiguracionNotaCompraVenta _configuracion;

        /// <summary>
        ///  
        /// </summary>
        /// <param name="nota"></param>
        /// <param name="configuracion"></param>
        public CalculadorBaseNotaCompraVenta(ICompraVentaMaestro  nota, IConfiguracionNotaCompraVenta configuracion)
        {
            _nota = nota;
            _configuracion = configuracion;
        }

        public void RecalculaBases(ICompraVentaMaestro maestro)
        {
            throw new NotImplementedException();
        }

        public void RecalculaDetalle(ICompraVentaDetalle detalle)
        {
            throw new NotImplementedException();
        }

        public void RecalculaNotaCompra(ICompraVentaMaestro maestro, bool recalculaDetalles = false)
        {
            throw new NotImplementedException();
        }

        public void RecalculoLinea(ICompraVentaDetalle detalle)
        {
            
               
        }



    }
}
