using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApi.Data.Model
{
    [Table("Subscription")]
    public class Subscription
    {
        public Subscription()
        {
            Users = new HashSet<User>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float PriceIncVatAmount { get; set; }
        public int CallMinutes { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}