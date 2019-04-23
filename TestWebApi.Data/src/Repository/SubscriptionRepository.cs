namespace TestWebApi.Data.Repository
{
    public class SubscriptionRepository : Repository<Model.Subscription>
    {
        public SubscriptionRepository(TestDbContext context) : base(context) { }
    }
}