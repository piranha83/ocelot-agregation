using AutoMapper;
using Orders.Dtos;
using Orders.Models;

namespace Orders.Maps
{
    public class OrderMap : Profile
    {
        public OrderMap() => CreateMap<Order, OrderDto>();
    }
}