using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApi.Core.TestDbServiceReference;

namespace TestWebApi.Core.Logic
{
    public class SubscriptionManager : ManagerBase
    {
        public SubscriptionManager(IMapper mapper) : base(mapper)
        {
        }

        public Model.Subscription CreateSubscription(Model.Subscription Subscription)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var mappedSubscription = ManagerMapper.Map<Subscription>(Subscription);
                    var result = service.CreateSubscription(mappedSubscription);

                    return result != null ? ManagerMapper.Map<Model.Subscription>(result) : null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Model.Subscription> GetSubscriptions()
        {
            using (var service = new TestDbServiceClient())
            {
                var res = service.GetSubscriptions();

                var mapped = ManagerMapper.Map<IEnumerable<Model.Subscription>>(res);

                return mapped;
            }
        }

        public Model.Subscription GetSubscription(Guid id)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var res = service.GetSubscription(id);
                    var mapped = ManagerMapper.Map<Model.Subscription>(res);

                    return mapped;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Model.Subscription UpdateSubscription(Guid id, Model.Subscription subscription)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var oldSubscription = service.GetSubscription(id);
                    var mappedSubscription = ManagerMapper.Map<Subscription>(subscription);
                    oldSubscription = mappedSubscription;
                    oldSubscription.Id = id;
                    var res = service.UpdateSubscription(oldSubscription);
                    var mapped = ManagerMapper.Map<Model.Subscription>(res);

                    return mapped;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool DeleteSubscription(Guid id)
        {
            try
            {
                using (var service = new TestDbServiceClient())
                {
                    var res = service.DeleteSubscription(id);

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
