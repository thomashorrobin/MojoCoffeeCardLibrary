namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualCard")]
    public partial class IndividualCard
    {
        [Key]
        [StringLength(10)]
        public override string CardId { get; set; }

        [Column(TypeName = "date")]
        public override DateTime CardIssueDate { get; set; }

        public override bool CardValid { get; set; }

        public int IndividualId { get; set; }

        public virtual Individual Individual { get; set; }
    }
}
