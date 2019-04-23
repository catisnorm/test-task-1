using AutoMapper;
using System;
using System.Collections.Generic;
using System.Web.Http;
using TestWebApi.Core.Logic;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly UserManager _userManager;

        public UsersController(IMapper mapper, UserManager manager)
        {
            _userManager = manager;
            _mapper = mapper;
        }

        public IEnumerable<User> Get()
        {
            var res = _userManager.GetUsers();
            var mapped = _mapper.Map<IEnumerable<User>>(res);
            return mapped;
        }

        public User Get(int id)
        {
            var res = _userManager.GetUser(id);
            var mapped = _mapper.Map<User>(res);
            return mapped;
        }

        public void Post([FromBody]User value)
        {
            var mappedUser = _mapper.Map<Core.Model.User>(value);
            _userManager.CreateUser(mappedUser);
        }

        [Route("users/{id}/{subscriptionId}")]
        public bool Put(int id, Guid subscriptionId)
        {
            return _userManager.CreateSubscription(id, subscriptionId);
        }

        public void Delete(int id)
        {
            _userManager.DeleteUser(id);
        }
    }
}
