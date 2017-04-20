namespace PeopleSearchApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PeopleDb : DbContext
    {
        public PeopleDb()
            : base("name=People")
        {
        }

        public virtual DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Interests)
                .IsUnicode(false);
        }
    }
}
