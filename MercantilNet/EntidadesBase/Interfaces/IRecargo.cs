using System;
using System.Collections.Generic;
using System.Text;

namespace MercantilNet.EntidadesBase.Interfaces
{
    public interface IRecargo
    {
        int Id { get; }

        /// <summary>
        /// Valor en tanto por uno del descuento a aplicar
        /// </summary>
        decimal Valor { get; set; }

        /// <summary>
        /// Establece si el recargo es de tipo fiscal
        /// si es false es un recargo por retraso en el
        /// pago posterior al vencimiento
        /// </summary>
        bool Fiscal { get; set; }

        /// <summary>
        /// Dias a los que vence el pronto pago
        /// </summary>
        int DiasVencimiento { get; set; }
        /// <summary>
        /// Si es fijo se aplica a la base imponible 
        /// sin tener en cuenta el plazo. Si es nulo
        /// se tiene en cuentas los días trascurridos
        /// desde la fecha de vencimiento.

        /// </summary>
        bool Fijo { get; set; }

        string Descripcion { get; set; }
    }
}
