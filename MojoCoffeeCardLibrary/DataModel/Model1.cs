namespace MojoCoffeeCardLibrary.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCard> AccountCards { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<IndividualCard> IndividualCards { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<XeroCustomer> XeroCustomers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.AccountCards)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccountCard>()
                .Property(e => e.CardId)
                .IsUnicode(false);

            modelBuilder.Entity<Individual>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Individual>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Individual>()
                .HasMany(e => e.IndividualCards)
                .WithRequired(e => e.Individual)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IndividualCard>()
                .Property(e => e.CardId)
                .IsUnicode(false);

            modelBuilder.Entity<Shop>()
                .Property(e => e.ShopName)
                .IsUnicode(false);

            modelBuilder.Entity<XeroCustomer>()
                .Property(e => e.OrganisationName)
                .IsUnicode(false);

            modelBuilder.Entity<XeroCustomer>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.XeroCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XeroCustomer>()
                .HasMany(e => e.Individuals)
                .WithRequired(e => e.XeroCustomer)
                .WillCascadeOnDelete(false);
        }
    }
}
