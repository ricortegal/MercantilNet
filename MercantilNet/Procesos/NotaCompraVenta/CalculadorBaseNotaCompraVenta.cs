using MercantilNet.Configuraciones;
using MercantilNet.EntidadesBase.Interfaces;
using MercantilNet.Procesos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.Procesos.NotaCompraVenta
{
    public class CalculadorBaseNotaCompraVenta<TMaestro, TDetalle>
        : ICalculadorNotaCompraVenta<TMaestro, TDetalle>
        where TMaestro : ICompraVentaMaestro
        where TDetalle : ICompraVentaDetalle
    {
        private ICompraVentaMaestro _nota;
        private IConfiguracionNotaCompraVenta _configuracion;

        /// <summary>
        ///  
        /// </summary>
        /// <param name="nota"></param>
        /// <param name="configuracion"></param>
        public CalculadorBaseNotaCompraVenta(TMaestro nota, IConfiguracionNotaCompraVenta configuracion)
        {
            _nota = nota;
            _configuracion = configuracion;
        }

        public void RecalculaBases(TMaestro maestro)
        {
            
        }

        public void RecalculaDetalle(TDetalle detalle)
        {
           
        }

        public void RecalculaNotaCompra(TMaestro maestro, bool recalculaDetalles = false)
        {
            
        }

        public void RecalculoLinea(TDetalle detalle)
        {
            
               
        }



    }
}
