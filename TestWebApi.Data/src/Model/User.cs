using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApi.Data.Model
{
    [Table("User")]
    public class User
    {
        public User()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}