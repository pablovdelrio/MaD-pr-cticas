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
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Producto_por_pedido = new HashSet<Producto_por_pedido>();
        }
    
        public decimal order_id { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public string direccion { get; set; }
        public decimal total_price { get; set; }
        public string descripcion { get; set; }
        public decimal custumer_id { get; set; }
    
        public virtual Custumer Custumer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto_por_pedido> Producto_por_pedido { get; set; }
    }
}
