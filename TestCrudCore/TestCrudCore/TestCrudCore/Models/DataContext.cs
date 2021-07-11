using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCrudCore.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //add my class to DbContext
        public DbSet<ManutenzioneModel> Manutenzione { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //cambiare datatype con le migrations
           // modelBuilder.Entity<ManutenzioneModel>(x => x.Property(e => e.CodMacchina).HasColumnType("VARCHAR").HasMaxLength(255));
        }


    }











}
