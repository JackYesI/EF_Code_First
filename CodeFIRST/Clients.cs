using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFIRST
{
    public class Clients
        {
        public Clients() {
            Flights = new HashSet<Flights>();
        }
        public int Id { get; set; }
            public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        [Key, ForeignKey("Accounts")]
        public int AccountId {  get; set; } 
        
            public Accounts Accounts { get; set; }
        public ICollection<Flights> Flights { get; set; }


    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}