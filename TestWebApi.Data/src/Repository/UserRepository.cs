namespace TestWebApi.Data.Repository
{
    public class UserRepository : Repository<Model.User>
    {
        public UserRepository(TestDbContext context) : base(context) { }
    }
}