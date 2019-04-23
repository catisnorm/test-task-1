using AutoMapper;
using System;
using System.Collections.Generic;
using System.Web.Http;
using TestWebApi.Core.Logic;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    public class SubscriptionsController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly SubscriptionManager _subscriptionManager;

        public SubscriptionsController(IMapper mapper, SubscriptionManager manager)
        {
            _subscriptionManager = manager;
            _mapper = mapper;
        }

        // GET api/values
        public IEnumerable<Subscription> Get()
        {
            var res = _subscriptionManager.GetSubscriptions();
            var mapped = _mapper.Map<IEnumerable<Subscription>>(res);
            return mapped;
        }

        public Subscription Get(Guid id)
        {
            var res = _subscriptionManager.GetSubscription(id);
            var mapped = _mapper.Map<Subscription>(res);
            return mapped;
        }

        public void Post([FromBody]Subscription value)
        {
            var mappedSubscription = _mapper.Map<Core.Model.Subscription>(value);
            _subscriptionManager.CreateSubscription(mappedSubscription);
        }

        public void Put(Guid id, [FromBody]Subscription value)
        {
            var mappedSubscription = _mapper.Map<Core.Model.Subscription>(value);
            _subscriptionManager.UpdateSubscription(id, mappedSubscription);
        }

        public void Delete(Guid id)
        {
            _subscriptionManager.DeleteSubscription(id);
        }
    }
}
