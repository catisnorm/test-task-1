using AutoMapper;
using System;
using System.Collections.Generic;
using TestWebApi.Core.TestDbServiceReference;

namespace TestWebApi.Core.Logic
{
    public class UserManager : ManagerBase
    {
        public UserManager(IMapper mapper) : base(mapper)
        {
        }

        public Model.User CreateUser(Model.User user)
        {
            try
            {
                using(var service = new TestDbServiceClient())
                {
                    var mappedUser = ManagerMapper.Map<User>(user);
                    var result = service.CreateUser(mappedUser);

                    return result != null ? ManagerMapper.Map<Model.User>(result) : null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Model.User> GetUsers()
        {
            using (var service = new TestDbServiceClient())
            {
                var res = service.GetUsers();

                var mapped = ManagerMapper.Map<IEnumerable<Model.User>>(res);

                return mapped;
            }
        }

        public bool CreateSubscription(int id, Guid subscriptionId)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var res = service.AddSubscription(id, subscriptionId);

                    return res.Code == 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Model.User GetUser(int id)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var res = service.GetUser(id);
                    var mapped = ManagerMapper.Map<Model.User>(res);

                    var totalMin = 0;
                    var totalPrice = 0.0F;
                    foreach (var s in mapped.Subscriptions)
                    {
                        totalMin += s.CallMinutes;
                        totalPrice += s.PriceIncVatAmount;
                    }

                    mapped.TotalCallMinutes = totalMin;
                    mapped.TotalPriceIncVatAmount = totalPrice;

                    return mapped;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var res = service.DeleteUser(id);

                    return res.Code == 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
