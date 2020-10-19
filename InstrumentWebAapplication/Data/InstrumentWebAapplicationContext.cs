using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InstrumentWebAapplication.Models;

namespace InstrumentWebAapplication.Data
{
    public class InstrumentWebAapplicationContext : DbContext
    {
        public InstrumentWebAapplicationContext (DbContextOptions<InstrumentWebAapplicationContext> options)
            : base(options)
        {
        }

        public DbSet<InstrumentWebAapplication.Models.Instrument> Instrument { get; set; }
        public DbSet<InstrumentWebAapplication.Models.AcousticGuitar> AcousticGuitar { get; set; }
        public DbSet<InstrumentWebAapplication.Models.ElectricGuitar> ElectricGuitar { get; set; }
        public DbSet<InstrumentWebAapplication.Models.AcousticPiano> AcousticPiano { get; set; }
        public DbSet<InstrumentWebAapplication.Models.DigitalPiano> DigitalPiano { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.Entity<Instrument>().ToTable("Instrument");
        }
    }
}
