//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Es.Udc.DotNet.MaDPractica.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Credit_card
    {
        public string credit_card_number_int { get; set; }
        public string tipo { get; set; }
        public decimal cvs { get; set; }
        public System.DateTime date_pf_expiry { get; set; }
        public decimal custumer_id { get; set; }
    
        public virtual Custumer Custumer { get; set; }
    }
}
