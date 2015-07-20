namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XeroCustomer
    {
        public XeroCustomer()
        {
            Accounts = new HashSet<Account>();
            Individuals = new HashSet<Individual>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganisationalId { get; set; }

        [Required]
        [StringLength(100)]
        public string OrganisationName { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }

        public virtual ICollection<Individual> Individuals { get; set; }
    }
}
