using TestWebApi.Data.Interface;
using TestWebApi.Data.Repository;

namespace TestWebApi.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TestDbContext _context;

        public IRepository<Model.User> UserRepository { get; }
        public IRepository<Model.Subscription> SubscriptionRepository { get; }

        public UnitOfWork()
        {
            _context = new TestDbContext();
            UserRepository = new UserRepository(_context);
            SubscriptionRepository = new SubscriptionRepository(_context);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}