using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Deliveries.Models;
using Infrastructure;

namespace Deliveries.Repositories
{
    public class DeliveriesRepository : InMemRepository<Guid, Delivery>, IDeliveriesRepository
    {
        public DeliveriesRepository(): base(Seed()){}
        static ConcurrentDictionary<Guid, Delivery> Seed() => new ConcurrentDictionary<Guid, Delivery> {
            [Guid.Parse("325a9391-cc32-42c4-b675-ebbd4edff7ad")] = new Delivery { Id = Guid.Parse("325a9391-cc32-42c4-b675-ebbd4edff7ad"), OrderId = Guid.Parse("d228e1e1-5f4e-4b85-96ae-8c5dec9889c3"), PhoneNumber = "01",
                From = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Улица строителей дом 25 квартира 12",
                    ZipCode = "11111",
                    City = "Москва"
                },
                To = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Улица строителей дом 25 квартира 12",
                    ZipCode = "22222",
                    City = "Cанкт петербург"
                } 
            }
        };
        public async Task<IEnumerable<Delivery>> GetByOrder(Guid orderId) => await Get(s=>s.OrderId == orderId);
        public new async Task<Delivery> Get(Guid id) => await Get(id);
    }
}