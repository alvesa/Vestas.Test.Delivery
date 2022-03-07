using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vestas.Test.Delivery.Application.Model;

namespace Vestas.Test.Delivery.Application.Repository
{
    public interface IUserRepository
    {
        Task Add(User user); 
        Task Update(User user); 
        Task Delete(Guid id); 
        IEnumerable<User> GetAll();
        User GetById(Guid id);

    }
}