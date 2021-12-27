using AutoMapper;
using System;
using System.Threading.Tasks;
using Deliveries.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Deliveries.Dtos;

namespace Deliveries.Controllers
{
    [ApiController]
    public class DeliveriesController : ControllerBase
    {
        readonly IDeliveriesRepository _deliveriesRepository;
        readonly IMapper _mapper;

        public DeliveriesController(IDeliveriesRepository deliveriesRepository, IMapper mapper)
        {
            _deliveriesRepository = deliveriesRepository ?? throw new ArgumentNullException(nameof(deliveriesRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("api/delivery/{orderId:guid}")]
        public async Task<IActionResult> GetByOrder([FromRoute]Guid orderId)
        {
            if (orderId == Guid.Empty)
                throw new ArgumentException(nameof(orderId));

            var deliveries = await _deliveriesRepository.GetByOrder(orderId);
            var dto = _mapper.Map<List<DeliveryDto>>(deliveries);
            return Ok(dto);
        }
    }
}
