using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface IDescuentoPorcentaje
    {
        int Id { get; }

        /// <summary>
        /// Valor en tanto por uno del descuento a aplicar
        /// </summary>
        decimal Valor { get; set; }

        /// <summary>
        /// Establece o Obtiene si el descuento es por
        /// pronto pago
        /// </summary>
        bool ProntoPago { get; set; }

        /// <summary>
        /// Dias a los que vence el pronto pago
        /// </summary>
        int DiasDescuentoProntoPago { get; set; }
        /// <summary>
        /// Si es fijo se aplica a la base imponible 
        /// sin tener en cuenta el plazo. Si es nulo
        /// se tiene en cuentas los días trascurridos
        /// desde la fecha de factura hasta el pago.
        /// El descuento es cero cuando realiza el pago
        /// en el día del vencimiento 
        /// </summary>
        bool Fijo { get; set; }

        string Descripcion { get; set; }
    }
}
