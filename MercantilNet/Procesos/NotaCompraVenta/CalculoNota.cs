using ercantilNet.EntidadesBase.Interfaces;
using MercantilNet.EntidadesBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.Procesos.NotaCompraVenta
{
    public class CalculoNota
    {
        private ICompraVentaMaestro _nota;

        public CalculoNota(ICompraVentaMaestro  nota)
        {
            _nota = nota;
        }

        public static  ICompraVentaDetalle RecalculoLinea(ICompraVentaDetalle detalle)
        {


        }



    }
}
