using System.Data.Entity;

namespace TestWebApi.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext() : base("testdb")
        {
        }

        public DbSet<Model.User> Users { get; set; }
        public DbSet<Model.Subscription> Subscriptions { get; set; }
    }
}