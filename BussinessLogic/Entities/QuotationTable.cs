//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BussinessLogic.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuotationTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuotationTable()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public long ID { get; set; }
        public string ProductOrService { get; set; }
        public string Code { get; set; }
        public Nullable<double> Price { get; set; }
        public string WarrantyPeriod { get; set; }
        public string Brand { get; set; }
        public Nullable<bool> IsProduct { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
