//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Neckhozhin_Cursach.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paint()
        {
            this.Order_ = new HashSet<Order_>();
            this.Paint_Warehouse = new HashSet<Paint_Warehouse>();
            this.Supply_Paint = new HashSet<Supply_Paint>();
        }
    
        public int id_P { get; set; }
        public string Name_Color_P { get; set; }
        public string ISO_P { get; set; }
        public string Manufacter { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_> Order_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paint_Warehouse> Paint_Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Paint> Supply_Paint { get; set; }
    }
}
