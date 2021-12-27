using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Deliveries.Models;

namespace Deliveries.Repositories
{
    public interface IDeliveriesRepository
    {
        Task<IEnumerable<Delivery>> GetByOrder(Guid orderId);
        Task<Delivery> Get(Guid id);
    }
}