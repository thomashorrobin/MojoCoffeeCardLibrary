namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop
    {
        public int ShopId { get; set; }

        [Required]
        [StringLength(100)]
        public string ShopName { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
