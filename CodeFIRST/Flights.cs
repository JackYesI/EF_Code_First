using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFIRST
{
    public class Flights
        {
            public Flights()
            {
                Clients = new HashSet<Clients>();
            }
            [Key]
            public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int AirlaineId { get; set; }
        public Airplanes Airplanes { get; set; }
        public ICollection<Clients> Clients { get; set;}
        public DateTime Date_Up { get; set; }
        public DateTime Date_Down { get; set;}
        public string Place_Up { get; set; }
        public string Place_Down { get; set;}
        
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}