using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFIRST
{
    public class Airplanes
        {
            public Airplanes()
            {
                Flights = new HashSet<Flights>();
            }
                [Key]
            public int Id { get; set; }
            [MaxLength(50)]
            public string Model { get; set; }
            public int countOfClient { get; set; }
        public string Country { get; set; }
            public ICollection<Flights> Flights { get; set; }
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}