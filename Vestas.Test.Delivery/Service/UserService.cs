using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Repository;
using Vestas.Test.Delivery.Application.Service;

namespace Vestas.Test.Delivery.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(User user)
        {
            await _repository.Add(user);
        }

        public async Task Delete(Guid id)
        {
            await _repository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _repository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public async Task Update(User user)
        {
            await _repository.Update(user);
        }
    }
}