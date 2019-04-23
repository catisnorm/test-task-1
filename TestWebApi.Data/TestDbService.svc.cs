using AutoMapper;
using System;
using System.Collections.Generic;
using TestWebApi.Data.Interface;

namespace TestWebApi.Data
{
    public class TestDbService : ITestDbService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public TestDbService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public Subscription CreateSubscription(Subscription subscription)
        {
            try
            {
                var mapped = _mapper.Map<Model.Subscription>(subscription);
                _unitOfWork.SubscriptionRepository.Add(mapped);
                _unitOfWork.Save();

                return _mapper.Map<Subscription>(mapped);
            }
            catch
            {
                return null;
            }
        }

        public User CreateUser(User user)
        {
            try
            {
                var mapped = _mapper.Map<Model.User>(user);
                _unitOfWork.UserRepository.Add(mapped);
                _unitOfWork.Save();

                return _mapper.Map<User>(mapped);
            }
            catch
            {
                return null;
            }
        }

        public SubscriptionResult DeleteSubscription(Guid id)
        {
            try
            {
                var item = _unitOfWork.SubscriptionRepository.Get(id);
                _unitOfWork.SubscriptionRepository.Delete(item);
                _unitOfWork.Save();

                return new SubscriptionResult
                {
                    Code = 0
                };
            }
            catch (Exception ex)
            {
                return new SubscriptionResult
                {
                    Code = 1,
                    Message = ex.Message
                };
            }
        }

        public UserResult DeleteUser(int id)
        {
            try
            {
                var item = _unitOfWork.UserRepository.Get(id);
                _unitOfWork.UserRepository.Delete(item);
                _unitOfWork.Save();

                return new UserResult
                {
                    Code = 0
                };
            }
            catch (Exception ex)
            {
                return new UserResult
                {
                    Code = 1,
                    Message = ex.Message
                };
            }
        }

        public Subscription GetSubscription(Guid id)
        {
            var dbSubscription = _unitOfWork.SubscriptionRepository.Get(id);
            var result = _mapper.Map<Subscription>(dbSubscription);
            return result;
        }

        public IEnumerable<Subscription> GetSubscriptions()
        {
            var list = _unitOfWork.SubscriptionRepository.Get();
            var result = _mapper.Map<IEnumerable<Subscription>>(list);
            return result;
        }

        public User GetUser(int id)
        {
            var dbUser = _unitOfWork.UserRepository.Get(id);
            var result = _mapper.Map<User>(dbUser);
            return result;
        }

        public IEnumerable<User> GetUsers()
        {
            var list = _unitOfWork.UserRepository.Get();
            var result = _mapper.Map<IEnumerable<User>>(list);
            return result;
        }

        public SubscriptionResult UpdateSubscription(Subscription subscription)
        {
            try
            {
                var mapped = _mapper.Map<Model.Subscription>(subscription);
                _unitOfWork.SubscriptionRepository.Update(mapped);
                _unitOfWork.Save();

                return new SubscriptionResult
                {
                    Code = 0,
                    Message = "Updated"
                };
            }
            catch (Exception ex)
            {
                return new SubscriptionResult
                {
                    Code = 1,
                    Message = ex.Message
                };
            }
        }

        public UserResult AddSubscription(int userId, Guid subscriptionId)
        {
            try
            {
                var user = _unitOfWork.UserRepository.Get(userId);
                var subscription = _unitOfWork.SubscriptionRepository.Get(subscriptionId);
                user.Subscriptions.Add(subscription);
                _unitOfWork.UserRepository.Update(user);
                _unitOfWork.Save();

                return new UserResult
                {
                    Code = 0,
                    Message = "Updated"
                };
            }
            catch (Exception ex)
            {
                return new UserResult
                {
                    Code = 0,
                    Message = ex.Message
                };
            }
        }
    }
}
