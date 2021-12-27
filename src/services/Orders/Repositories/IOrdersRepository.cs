using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Orders.Models;

namespace Orders.Repositories
{
    public interface IOrdersRepository
    {
        Task<IList<Order>> Get(Guid id, Guid clientId); 
    }
}