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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities_Perfomance_Artist : DbContext
    {
        public Entities_Perfomance_Artist()
            : base("name=Entities_Perfomance_Artist")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Costumables> Costumables { get; set; }
        public virtual DbSet<Costumables_Warehouse> Costumables_Warehouse { get; set; }
        public virtual DbSet<Employers> Employers { get; set; }
        public virtual DbSet<Master_> Master_ { get; set; }
        public virtual DbSet<Order_> Order_ { get; set; }
        public virtual DbSet<OrderbyShift> OrderbyShift { get; set; }
        public virtual DbSet<Paint> Paint { get; set; }
        public virtual DbSet<Paint_Warehouse> Paint_Warehouse { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Products_Warehouse> Products_Warehouse { get; set; }
        public virtual DbSet<Shift_Composition> Shift_Composition { get; set; }
        public virtual DbSet<Shift_Costumables> Shift_Costumables { get; set; }
        public virtual DbSet<Supply_Costumables> Supply_Costumables { get; set; }
        public virtual DbSet<Supply_Details> Supply_Details { get; set; }
        public virtual DbSet<Supply_Paint> Supply_Paint { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User_App> User_App { get; set; }
        public virtual DbSet<Work_Shift> Work_Shift { get; set; }
    }
}
