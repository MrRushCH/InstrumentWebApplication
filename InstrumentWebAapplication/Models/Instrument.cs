using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace InstrumentWebAapplication.Models
{
    public abstract class Instrument
    {
        [Key]
        public int Id { get; set; }
        public string DiscriminatorValue
        {
            get
            {
                return this.GetType().Name;
            }
        }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
