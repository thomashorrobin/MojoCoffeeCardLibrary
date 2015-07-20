namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Individual")]
    public partial class Individual
    {
        public Individual()
        {
            IndividualCards = new HashSet<IndividualCard>();
        }

        public int IndividualId { get; set; }

        public override int OrganisationalId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public virtual ICollection<IndividualCard> IndividualCards { get; set; }

        public virtual XeroCustomer XeroCustomer { get; set; }
    }
}
