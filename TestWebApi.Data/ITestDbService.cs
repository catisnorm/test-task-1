using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace TestWebApi.Data
{
    [ServiceContract]
    public interface ITestDbService
    {
        [OperationContract]
        IEnumerable<User> GetUsers();

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        User CreateUser(User user);

        [OperationContract]
        UserResult AddSubscription(int userId, Guid subscriptionId);

        [OperationContract]
        UserResult DeleteUser(int id);


        [OperationContract]
        IEnumerable<Subscription> GetSubscriptions();

        [OperationContract]
        Subscription GetSubscription(Guid id);

        [OperationContract]
        Subscription CreateSubscription(Subscription subscription);

        [OperationContract]
        SubscriptionResult UpdateSubscription(Subscription subscription);

        [OperationContract]
        SubscriptionResult DeleteSubscription(Guid id);
    }

    [DataContract]
    public class UserResult
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    [DataContract]
    public class SubscriptionResult
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public ICollection<Subscription> Subscriptions { get; set; }
    }

    [DataContract]
    public class Subscription
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public float Price { get; set; }

        [DataMember]
        public float PriceIncVatAmount { get; set; }

        [DataMember]
        public int CallMinutes { get; set; }
    }
}
