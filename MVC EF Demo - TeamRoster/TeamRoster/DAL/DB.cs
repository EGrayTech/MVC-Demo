using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeamRoster.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace TeamRoster.DAL
{
    public class DB : DbContext
    {
        public DB() : base("DB")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}