using InstrumentWebAapplication.Data;
using InstrumentWebAapplication.Models;
using System;
using System.Linq;

namespace InstrumentWebAapplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InstrumentWebAapplicationContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.AcousticGuitar.Any())
            {
                return;   // DB has been seeded
            }

            var acousticGuitars = new AcousticGuitar[]
            {
                new AcousticGuitar{CapoPosition=0, NumberOfFrets=20, InTuneLevel=10, NumberOfStrings=6, Name="AcousticGuitar1", Price=500},
                new AcousticGuitar{CapoPosition=2, NumberOfFrets=21, InTuneLevel=7, NumberOfStrings=6, Name="AcousticGuitar2", Price=200},
                new AcousticGuitar{CapoPosition=0, NumberOfFrets=19, InTuneLevel=5, NumberOfStrings=6, Name="AcousticGuitar3", Price=350},
            };

            context.AcousticGuitar.AddRange(acousticGuitars);
            context.SaveChanges();

            var acousticPianos = new AcousticPiano[]
            {
                new AcousticPiano{HasPedal=true, NumberOfKeys=88, InTuneLevel=10, Name="AcousticPiano1", Price=2500},
                new AcousticPiano{HasPedal=false, NumberOfKeys=76, InTuneLevel=4, Name="AcousticPiano2", Price=750},
                new AcousticPiano{HasPedal=true, NumberOfKeys=88, InTuneLevel=9, Name="AcousticPiano3", Price=800},
            };

            context.AcousticPiano.AddRange(acousticPianos);
            context.SaveChanges();

            var digitalPianos = new DigitalPiano[]
            {
                new DigitalPiano{HasPedal=false, NumberOfKeys=88, VolumeSetting=10, Name="DigitalPiano1", Price=1000},
                new DigitalPiano{HasPedal=true, NumberOfKeys=76, VolumeSetting=6, Name="DigitalPiano2", Price=1300},
                new DigitalPiano{HasPedal=false, NumberOfKeys=76, VolumeSetting=9, Name="DigitalPiano3", Price=650},
            };

            context.DigitalPiano.AddRange(digitalPianos);
            context.SaveChanges();

            var electricGuitars = new ElectricGuitar[]
                {
                    new ElectricGuitar{InTuneLevel=10, NumberOfStrings=6, NumberOfFrets=22, VolumeSetting=10, Name="ElectricGuitar1", Price=1250},
                    new ElectricGuitar{InTuneLevel=6, NumberOfStrings=6, NumberOfFrets=22, VolumeSetting=8, Name="ElectricGuitar2", Price=750},
                    new ElectricGuitar{InTuneLevel=7, NumberOfStrings=12, NumberOfFrets=22, VolumeSetting=10, Name="ElectricGuitar3", Price=4800},
                };

            context.ElectricGuitar.AddRange(electricGuitars);
            context.SaveChanges();

        }
    }
}