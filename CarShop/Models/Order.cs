namespace CarShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int Id { get; set; }

        [StringLength(80)]
        public string UserName { get; set; }

        public int? CarId { get; set; }

        [StringLength(50)]
        public string UserTel { get; set; }

        [StringLength(10)]
        public string Status { get; set; }
    }
}
