namespace CarShop.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShopDBModel : DbContext
    {
        public ShopDBModel()
            : base("name=ShopDBEntities")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
