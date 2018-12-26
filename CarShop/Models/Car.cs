namespace CarShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Car")]
    public partial class Car
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(350)]
        public string Description { get; set; }

        [StringLength(350)]
        public string Preview { get; set; }

        [StringLength(950)]
        public string SubPreview { get; set; }

        public int? Count { get; set; }

        public int? Price { get; set; }
    }
}
