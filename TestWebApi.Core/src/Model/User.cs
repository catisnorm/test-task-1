using System.Collections.Generic;

namespace TestWebApi.Core.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public float TotalPriceIncVatAmount { get; set; }
        public int TotalCallMinutes { get; set; }
    }
}