//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIS_IS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pago_servicio
    {
        public int pk_id_pago_servicio { get; set; }
        public int fk_id_tipo_servicio { get; set; }
        public int fk_id_cuenta_bancaria { get; set; }
        public double cantidad { get; set; }
        public string no_documento { get; set; }
        public string no_autorizacion { get; set; }
        public System.DateTime fecha_realizo { get; set; }
        public string cuenta_debitada { get; set; }
        public double total_pagar { get; set; }
    }
}
