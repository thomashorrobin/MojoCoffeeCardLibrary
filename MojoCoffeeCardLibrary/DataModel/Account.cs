namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        public Account()
        {
            AccountCards = new HashSet<AccountCard>();
        }

        public int AccountId { get; set; }

        public override int OrganisationalId { get; set; }
         
        [Required]
        [StringLength(100)]
        public string AccountName { get; set; }

        public virtual XeroCustomer XeroCustomer { get; set; }

        public virtual ICollection<AccountCard> AccountCards { get; set; }
    }
}
