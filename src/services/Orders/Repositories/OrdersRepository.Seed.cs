using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure;
using Orders.Middlewares;
using Orders.Models;

namespace Orders.Repositories
{
    public class OrdersRepository : InMemRepository<Guid, Order>, IOrdersRepository
    {
        public OrdersRepository(): base(Seed(FakeClientMiddleware.ClientId)){}
        static ConcurrentDictionary<Guid, Order> Seed(Guid clientId) => new ConcurrentDictionary<Guid, Order> {
            [Guid.Parse("d228e1e1-5f4e-4b85-96ae-8c5dec9889c3")] = new Order { Id = Guid.Parse("d228e1e1-5f4e-4b85-96ae-8c5dec9889c3"), State = OrderStates.Created, ClientId = clientId },
            [Guid.Parse("b22213e7-8fc7-47e6-970a-251decca52d1")] = new Order { Id = Guid.Parse("b22213e7-8fc7-47e6-970a-251decca52d1"), State = OrderStates.Created, ClientId = clientId }
        };

        public async Task<IList<Order>> Get(Guid id, Guid clientId) => await Get(s=>s.Id == id && s.ClientId == clientId);
    }
}