using AutoMapper;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orders.Repositories;
using Orders.Dtos;
using System.Collections.Generic;

namespace Orders.Controllers
{
    [ApiController]
    public class OrdersController : ControllerBase
    {
        readonly IOrdersRepository _ordersRepository;
        readonly IMapper _mapper;

        public OrdersController(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository ?? throw new ArgumentNullException(nameof(ordersRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/order/{orderId:guid}")]
        public async Task<IActionResult> GetByClient([FromRoute]Guid orderId)
        {
            var clinetOrders = await _ordersRepository.Get(orderId, ClientId);
            var dto = _mapper.Map<List<OrderDto>>(clinetOrders);
            return Ok(dto);
        }

        Guid ClientId => Guid.Parse(User.Identity.Name);
    }
}
