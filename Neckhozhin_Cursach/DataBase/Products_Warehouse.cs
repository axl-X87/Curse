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
    
    public partial class Products_Warehouse
    {
        public int id_W { get; set; }
        public Nullable<int> Id_ { get; set; }
        public Nullable<int> Reminder_P { get; set; }
    
        public virtual Product Product { get; set; }
    }
}