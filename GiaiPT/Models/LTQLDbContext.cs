using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiaiPT.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext() : base("name = LTQLDbcontext")
        {

        }
        public virtual DbSet<Account> Accounts { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
            .Property(e => e.Username)
            .IsUnicode(false);
        }
    }
}