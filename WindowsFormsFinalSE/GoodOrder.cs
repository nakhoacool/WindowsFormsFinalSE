//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsFinalSE
{
    using System;
    using System.Collections.Generic;
    
    public partial class GoodOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoodOrder()
        {
            this.Deliveries = new HashSet<Delivery>();
        }
    
        public string OID { get; set; }
        public string AID { get; set; }
        public string GID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> TotalPrice { get; set; }
        public string PaymentMethod { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual Good Good { get; set; }
    }
}
