using AutoMapper;
using Deliveries.Dtos;
using Deliveries.Models;

namespace Deliveries.Maps
{
    public class DeliveryMap : Profile
    {
        public DeliveryMap()
        { 
            CreateMap<Delivery, DeliveryDto>();
            CreateMap<Address, AddressDto>();
        }
    }
}