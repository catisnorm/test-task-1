using System;

namespace TestWebApi.Data.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Model.User> UserRepository { get; }
        IRepository<Model.Subscription> SubscriptionRepository { get; }

        void Save();
    }
}
