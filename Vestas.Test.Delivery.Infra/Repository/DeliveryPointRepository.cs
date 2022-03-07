using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Vestas.Test.Delivery.Application.Model;
using Vestas.Test.Delivery.Application.Repository;

namespace Vestas.Test.Delivery.Infra.Repository
{
    public class DeliveryPointRepository : IDeliveryPointRepository
    {
        private readonly DeliveryPointContext _context;
        private readonly IMapper _mapper;

        public DeliveryPointRepository(DeliveryPointContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreatePoint(DeliveryPoint deliveryPoint)
        {
            try
            {
                await _context.AddAsync(deliveryPoint);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public async Task UpdatePoint(DeliveryPoint deliveryPoint)
        {
            try
            {
                var deliveryPointToUpdate = _context.DeliveryPoint.Find(deliveryPoint.Id);

                _mapper.Map(deliveryPoint, deliveryPointToUpdate);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public async Task DeletePoint(char pointA, char pointB)
        {
            try
            {
                var deliveryPointToDelete = _context.DeliveryPoint.FirstOrDefault(x => x.Origin == pointA && x.Destination == pointB);

                _context.Remove(deliveryPointToDelete);
               
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public DeliveryPoint GetPointsByNode(Expression<Func<DeliveryPoint, bool>> predicate)
        {
            try
            {
               return _context.DeliveryPoint.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public IEnumerable<DeliveryPoint> GetPoints()
        {
            return _context.DeliveryPoint.ToList();
        }
    }
}