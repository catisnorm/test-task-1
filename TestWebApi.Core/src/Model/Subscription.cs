using System;
using System.Collections.Generic;

namespace TestWebApi.Core.Model
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float PriceIncVatAmount { get; set; }
        public int CallMinutes { get; set; }
        public ICollection<User> Users { get; set; }
    }
}