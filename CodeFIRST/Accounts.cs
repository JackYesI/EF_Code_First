using System.ComponentModel.DataAnnotations;

namespace CodeFIRST
{
    public class Accounts
        {

        [Key]
            public int Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public virtual Clients Clients { get; set; }
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}