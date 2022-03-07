using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Repository;

namespace Vestas.Test.Delivery.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DeliveryPointContext _context;
        private readonly IMapper _mapper;

        public UserRepository(DeliveryPointContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task Add(User user)
        {
            await _context.AddAsync(user);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var user = await _context.User.FindAsync(id);

            _context.Remove(user);

            await _context.SaveChangesAsync();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User.ToList();
        }

        public User GetById(Guid id)
        {
            return _context.User.Find(id);
        }

        public async Task Update(User user)
        {
            var entity = _context.User.FirstOrDefault(x => x.Id == user.Id);

            _mapper.Map(entity, user);

            await _context.SaveChangesAsync();
        }

        public User GetUserByCredentials(string name, string passCode)
        {
           return  _context.User.FirstOrDefault(x => x.Name == name && x.PassCode == passCode);
        }
    }
}