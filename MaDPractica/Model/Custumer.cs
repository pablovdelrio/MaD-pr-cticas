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
    
    public partial class Custumer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Custumer()
        {
            this.Comenta = new HashSet<Comenta>();
            this.Credit_card = new HashSet<Credit_card>();
            this.Orders = new HashSet<Orders>();
        }
    
        public decimal custumer_id { get; set; }
        public string custumer_name { get; set; }
        public string custumer_last_name1 { get; set; }
        public string custumer_last_name2 { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string idioma { get; set; }
        public string country { get; set; }
        public string rol { get; set; }
        public string credit_card_default { get; set; }
        public string custumer_login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comenta> Comenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit_card> Credit_card { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}