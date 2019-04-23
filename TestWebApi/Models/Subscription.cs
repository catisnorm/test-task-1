using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApi.Models
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float PriceIncVatAmount { get; set; }
        public int CallMinutes { get; set; }
    }
}